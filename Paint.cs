using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Paint
{
    public partial class Paint : Form
    {
        Tools activeTool = Tools.Pen;
        enum Tools
        {
            Pen, Brush, Line, Rectangle, Circle, Triangle, RegularPolygon,
            Bucket, Eraser, Text, Picker, IrregularPolygon, Arrow, Selection,
            Spray, Curve, Star, Trapezoid, RightTriangle, Diamond
        }

        Color current_color = Color.Black, second_color = Color.White;
        Font current_font;
        bool isClicking = false, isWriting = false, squareMode = false, isHolding = false, isPasted = false;
        Point firstPoint, lastPoint;

        Point[] points;

        int relativeX, relativeY;

        Rectangle lastShape, lastSelection;
        Bitmap lastImageSelection, lastPenDrawing;
        RectangleF outlineCircle;
        Point[] lastTriangle = new Point[3];
        Point[] lastRegularPolygon = new Point[5];
        Point[] lastStar = new Point[6];
        Point[] lastLine = new Point[2];
        Point[] lastArrow = new Point[7];
        Point[] lastCurve = new Point[4];
        Point[] lastQuad = new Point[4];
        List<Point> lastIrregularPolygon = new List<Point>();
        string lastString = "";

        int maxWidth, maxHeight;

        Graphics objDrawer;
        Pen normalPen, roundedPen, eraserPen, dottedPen;
        SolidBrush fillBrush;
        Bitmap canvas;
        Stack<Bitmap> ctrlZStack = new Stack<Bitmap>();
        Stack<Bitmap> ctrlYStack = new Stack<Bitmap>();

        string filename = null;

        public Paint()
        {
            InitializeComponent();

            //Dark Magic invocation to stop flickering brought to you by Internet TM
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty |
            BindingFlags.Instance | BindingFlags.NonPublic,
            null, pnl_canvas, new object[] { true });
            //End of Dark Magic 

            maxHeight = pnl_canvas.Height;
            maxWidth = pnl_canvas.Width;
            canvas = new Bitmap(pnl_canvas.Width, pnl_canvas.Height);
            normalPen = new Pen(current_color, (float)num_width.Value);
            roundedPen = new Pen(current_color, (float)num_width.Value);
            eraserPen = new Pen(Color.White, (float)num_width.Value);
            dottedPen = new Pen(SystemColors.HotTrack, 2);

            fillBrush = new SolidBrush(second_color);

            dottedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            roundedPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            roundedPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraserPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraserPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            current_font = Font;

            points = new Point[0];

            using (objDrawer = Graphics.FromImage(canvas))
            {
                objDrawer.Clear(Color.White);
            }

        }

        //START: Menu Methods
        private void menuFile_open_Click(object sender, EventArgs e)
        {
            closeToolProcesses();

            ofdAbrirArchivo.Filter = "Archivos JPEG (*.jpg, *jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (ofdAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                maxHeight = 0;
                maxWidth = 0;
                this.WindowState = FormWindowState.Normal;
                Bitmap new_canvas = new Bitmap(ofdAbrirArchivo.FileName);
                int deltaX = new_canvas.Width > 550 ? new_canvas.Width - 550 : 0;
                int deltaY = new_canvas.Height > 500 ? new_canvas.Height - 500 : 0;
                this.Size = new Size(800 + deltaX, 600 + deltaY);
                canvas = new_canvas;
                pnl_canvas.Size = canvas.Size;
                pnl_canvas.Refresh();
            }
        }
        private void menuFile_save_Click(object sender, EventArgs e)
        {
            closeToolProcesses();

            sfdGuardarArchivo.Filter = "Archivos JPEG (*.jpg, *jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (filename != null)
            {
                canvas.Save(filename);
                return;
            }
            if (sfdGuardarArchivo.ShowDialog() == DialogResult.OK)
            {
                filename = sfdGuardarArchivo.FileName;
                canvas.Save(filename);
            }
        }
        private void menuFile_saveAs_Click(object sender, EventArgs e)
        {
            closeToolProcesses();

            sfdGuardarArchivo.Filter = "Archivos JPEG (*.jpg, *jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (sfdGuardarArchivo.ShowDialog() == DialogResult.OK)
            {
                canvas.Save(sfdGuardarArchivo.FileName);
            }
        }
        private void menuFile_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void menuFile_new_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            maxHeight = 0;
            maxWidth = 0;
            this.Size = new Size(800, 600);
            this.WindowState = FormWindowState.Normal;
            filename = null;
            using (objDrawer = Graphics.FromImage(canvas))
            {
                objDrawer.Clear(Color.White);
            }
            pnl_canvas.Refresh();
        }
        private void menuAbout_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is AcercaDe)
                {
                    form.Focus();
                    return;
                }
            }
            AcercaDe acerca = new AcercaDe();
            acerca.Show();
        }

        //START: ToolBox Methods
        private void btn_pen_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            setActives(btn_pen, Tools.Pen);
        }
        private void btn_line_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            setActives(btn_line, Tools.Line);
        }
        private void btn_eraser_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            setActives(btn_eraser, Tools.Eraser);
        }
        private void btn_circle_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            set2ndVisible();
            setActives(btn_circle, Tools.Circle);
        }
        private void btn_rect_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            set2ndVisible();
            setActives(btn_rect, Tools.Rectangle);
        }
        private void btn_text_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            setActives(btn_text, Tools.Text);
        }
        private void btn_fill_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            setActives(btn_fill, Tools.Bucket);
        }
        private void btn_triangle_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            set2ndVisible();
            setActives(btn_triangle, Tools.Triangle);
        }
        private void btn_brush_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            setActives(btn_brush, Tools.Brush);
        }
        private void btn_polygon_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            set2ndVisible();
            setActives(btn_polygon, Tools.RegularPolygon);
            lbl_sides.Visible = true;
            num_sides.Visible = true;
        }
        private void btn_erase_all_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            canvas = new Bitmap(pnl_canvas.Width, pnl_canvas.Height);
            using (objDrawer = Graphics.FromImage(canvas))
            {
                objDrawer.Clear(Color.White);
            }
            pnl_canvas.Refresh();
        }
        private void btn_pick_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            set2ndVisible();
            setActives(btn_pick, Tools.Picker);
        }
        private void btn_shape_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            set2ndVisible();
            setActives(btn_shape, Tools.IrregularPolygon);
        }
        private void btn_arrow_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            set2ndVisible();
            setActives(btn_arrow, Tools.Arrow);
        }
        private void btn_selection_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            setActives(btn_selection, Tools.Selection);
        }
        private void btn_spray_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            setActives(btn_spray, Tools.Spray);
        }
        private void btn_curve_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            setActives(btn_curve, Tools.Curve);
        }
        private void btn_star_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            set2ndVisible();
            setActives(btn_star, Tools.Star);
            lbl_sides.Visible = true;
            num_sides.Visible = true;
        }
        private void btn_trapezoid_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            set2ndVisible();
            setActives(btn_trapezoid, Tools.Trapezoid);
        }
        private void btn_diamond_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            set2ndVisible();
            setActives(btn_diamond, Tools.Diamond);
        }
        private void btn_trianrect_Click(object sender, EventArgs e)
        {
            closeToolProcesses();
            resetVisibles();
            set2ndVisible();
            setActives(btn_trianrect, Tools.RightTriangle);
        }



        //START: Associate Tool Box and GUI methods
        private void setActives(Button btn_sender, Tools tool)
        {
            activeTool = tool;
            btn_active.BackgroundImage = btn_sender.BackgroundImage;
        }
        private void resetVisibles()
        {
            lbl_2ndcolor.Visible = false;
            lbl_sides.Visible = false;
            num_sides.Visible = false;
            lbl_red2.Visible = false;
            lbl_green2.Visible = false;
            lbl_blue2.Visible = false;
            lbl_alpha2.Visible = false;
            num_red2.Visible = false;
            num_green2.Visible = false;
            num_blue2.Visible = false;
            num_alpha2.Visible = false;
            chk_fill.Visible = false;
            chk_outline.Visible = false;
            pnl_color2.Visible = false;
        }
        private void set2ndVisible()
        {
            lbl_2ndcolor.Visible = true;
            lbl_red2.Visible = true;
            lbl_green2.Visible = true;
            lbl_blue2.Visible = true;
            lbl_alpha2.Visible = true;
            num_red2.Visible = true;
            num_green2.Visible = true;
            num_blue2.Visible = true;
            num_alpha2.Visible = true;
            chk_fill.Visible = true;
            chk_outline.Visible = true;
            pnl_color2.Visible = true;
        }
        private void chk_opt_CheckedChanged(object sender, EventArgs e)
        {
            if (!chk_outline.Checked && !chk_fill.Checked)
            {
                ((CheckBox)sender).Checked = true;
            }
        }
        private void pnl_canvas_SizeChanged(object sender, EventArgs e)
        {

            maxWidth = Math.Max(pnl_canvas.Width, maxWidth);
            maxHeight = Math.Max(pnl_canvas.Height, maxHeight);
            Bitmap new_canvas = new Bitmap(maxWidth, maxHeight);
            using (objDrawer = Graphics.FromImage(new_canvas))
            {
                objDrawer.Clear(Color.White);
                objDrawer.DrawImage(canvas, 0, 0, canvas.Width, canvas.Height);
            }
            canvas = new_canvas;
        }

        //START: Color/Width/Font Methods
        private void num_color_ValueChanged(object sender, EventArgs e)
        {
            current_color = Color.FromArgb((int)num_alpha.Value, (int)num_red.Value, (int)num_green.Value, (int)num_blue.Value);
            pnl_color.BackColor = current_color;
            normalPen.Color = current_color;
            roundedPen.Color = current_color;
        }
        private void num_color2_ValueChanged(object sender, EventArgs e)
        {
            second_color = Color.FromArgb((int)num_alpha2.Value, (int)num_red2.Value, (int)num_green2.Value, (int)num_blue2.Value);
            pnl_color2.BackColor = second_color;
            fillBrush.Color = second_color;
        }
        private void btn_color_Click(object sender, EventArgs e)
        {
            if (cdgPaletadeColores.ShowDialog() == DialogResult.OK)
            {
                Color new_color = cdgPaletadeColores.Color;
                num_alpha.Value = 255;
                num_red.Value = new_color.R;
                num_blue.Value = new_color.B;
                num_green.Value = new_color.G;
            }
        }
        private void pnl_Color2_DoubleClick(object sender, EventArgs e)
        {
            if (cdgPaletadeColores.ShowDialog() == DialogResult.OK)
            {
                Color new_color = cdgPaletadeColores.Color;
                num_alpha2.Value = 255;
                num_red2.Value = new_color.R;
                num_blue2.Value = new_color.B;
                num_green2.Value = new_color.G;
            }
        }
        private void btn_font_Click(object sender, EventArgs e)
        {
            if (fdgTipoLetra.ShowDialog() == DialogResult.OK)
            {
                current_font = fdgTipoLetra.Font;
            }
        }
        private void num_width_ValueChanged(object sender, EventArgs e)
        {
            normalPen.Width = (float)num_width.Value;
            roundedPen.Width = (float)num_width.Value;
            eraserPen.Width = (float)num_width.Value;
        }

        //START: Actual drawing methods
        private void pnl_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isClicking = true;
            firstPoint = e.Location;

            ctrlYStack.Clear();
            ctrlZStack.Push(new Bitmap(canvas));

            int width = (int)num_width.Value;
            Rectangle firstDrawablePoint = new Rectangle(firstPoint.X - width/2, firstPoint.Y - width/2, width, width);

            stampText();
            using (objDrawer = Graphics.FromImage(canvas))
            {
                switch (activeTool)
                {
                    case Tools.Pen:
                        lastPenDrawing = new Bitmap(canvas.Width, canvas.Height);
                        objDrawer = Graphics.FromImage(lastPenDrawing); 
                        objDrawer.FillEllipse(new SolidBrush(current_color), firstDrawablePoint);
                        break;
                    case Tools.Eraser:
                        objDrawer.FillEllipse(new SolidBrush(Color.White), firstDrawablePoint);
                        break;
                    case Tools.Brush:
                        lastPenDrawing = new Bitmap(canvas.Width, canvas.Height);
                        objDrawer = Graphics.FromImage(lastPenDrawing);
                        objDrawer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        objDrawer.FillEllipse(new SolidBrush(current_color), firstDrawablePoint);
                        break;
                    case Tools.Spray:
                        createSpray(firstPoint);
                        break;
                    case Tools.Bucket:
                        fillBucket(e.X, e.Y);
                        break;
                    case Tools.Text:
                        isWriting = true;
                        txt_hidden.Focus();
                        break;
                    case Tools.Picker:
                        if (e.Button == MouseButtons.Left)
                        {
                            Color new_color = canvas.GetPixel(e.X, e.Y);
                            num_red.Value = new_color.R;
                            num_blue.Value = new_color.B;
                            num_green.Value = new_color.G;
                        }
                        else if (e.Button == MouseButtons.Right)
                        {
                            Color new_color = canvas.GetPixel(e.X, e.Y);
                            num_red2.Value = new_color.R;
                            num_blue2.Value = new_color.B;
                            num_green2.Value = new_color.G;
                        }
                        break;
                    case Tools.IrregularPolygon:
                        createIrregularPolygon(e.Location);
                        break;
                    case Tools.Selection:
                        if (lastSelection.Contains(e.Location))
                        {
                            isHolding = true;
                            if (!isPasted)
                            {
                                objDrawer.FillRectangle(new SolidBrush(Color.White), lastSelection);
                            }
                            isPasted = false;
                            relativeX = e.X - lastSelection.X;
                            relativeY = e.Y - lastSelection.Y;;
                        }
                        else
                        {
                            isHolding = false;
                            lastImageSelection = null;
                            lastSelection = new Rectangle();
                        }
                        break;
                    case Tools.Curve:
                        if (lastCurve[0].IsEmpty)
                        {
                            lastCurve[0] = e.Location;
                            lastCurve[1] = e.Location;
                        }
                        else if (lastCurve[2].IsEmpty)
                        {
                            lastCurve[2] = e.Location;
                        }
                        else if (lastCurve[3].IsEmpty)
                        {
                            lastCurve[3] = e.Location;
                        }
                        break;
                    default:
                        break;
                }
            }
            pnl_canvas.Refresh();
            lastPoint = firstPoint;
        }
        private void pnl_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordenadas.Text = e.X.ToString() + ", " + e.Y.ToString();
            if (isClicking)
            {
                using (objDrawer = Graphics.FromImage(canvas))
                {
                    switch (activeTool)
                    {
                        case Tools.Pen:
                            objDrawer = Graphics.FromImage(lastPenDrawing);
                            objDrawer.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                            objDrawer.DrawLine(roundedPen, lastPoint, e.Location);
                            break;
                        case Tools.Eraser:
                            objDrawer.DrawLine(eraserPen, lastPoint, e.Location);
                            break;
                        case Tools.Brush:
                            objDrawer = Graphics.FromImage(lastPenDrawing);
                            objDrawer.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                            objDrawer.DrawLine(roundedPen, lastPoint, e.Location);
                            break;
                        case Tools.Line:
                            lastLine = createLine(firstPoint, e.Location);
                            break;
                        case Tools.Rectangle:
                        case Tools.Circle:
                            lastShape = createRectangle(firstPoint, e.Location);
                            break;
                        case Tools.Triangle:
                            lastTriangle = createTriangle(firstPoint, e.Location);
                            break;
                        case Tools.RegularPolygon:
                            lastRegularPolygon = createRegularPolygon(firstPoint, e.Location);
                            outlineCircle = createCircle(firstPoint, e.Location);
                            break;
                        case Tools.IrregularPolygon:
                            createIrregularPolygon(e.Location, true);
                            break;
                        case Tools.Arrow:
                            lastArrow = createArrow(firstPoint, e.Location);
                            break;
                        case Tools.Selection:
                            if (isHolding)
                            {
                                lastSelection.Location = new Point(e.X - relativeX, e.Y-relativeY);
                            }
                            else
                            {
                                lastSelection = createRectangle(firstPoint, e.Location);
                            }
                            break;
                        case Tools.Spray:
                            createSpray(e.Location);
                            break;
                        case Tools.Curve:
                            for (int i = 3; i >= 0; i--)
                            {
                                if (!lastCurve[i].IsEmpty)
                                {
                                    lastCurve[i] = e.Location;
                                    break;
                                }
                            }
                            break;
                        case Tools.Star:
                            lastStar = createStar(firstPoint, e.Location);
                            outlineCircle = createCircle(firstPoint, e.Location);
                            break;
                        case Tools.Trapezoid:
                            lastQuad = createTrapezoid(firstPoint, e.Location);
                            break;
                        case Tools.Diamond:
                            lastQuad = createDiamond(firstPoint, e.Location);
                            break;
                        case Tools.RightTriangle:
                            lastTriangle = createRightTriangle(firstPoint, e.Location);
                            break;
                        default:
                            break;
                    }
                    lastPoint = e.Location;
                }
                pnl_canvas.Refresh();
            }
        }
        private void pnl_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isClicking = false;
            using (objDrawer = Graphics.FromImage(canvas))
            {
                switch (activeTool)
                {
                    case Tools.Brush:
                    case Tools.Pen:
                        objDrawer.DrawImage(lastPenDrawing, 0, 0);
                        lastPenDrawing = null;
                        break;
                    case Tools.Line:
                        objDrawer.DrawLine(normalPen, lastLine[0], lastLine[1]);
                        lastLine = new Point[2];
                        break;
                    case Tools.Rectangle:
                        lastShape = new Rectangle(0, 0, 0, 0);
                        drawFillables(objDrawer.DrawRectangle, objDrawer.FillRectangle, createRectangle(firstPoint, lastPoint));
                        break;
                    case Tools.Circle:
                        lastShape = new Rectangle(0, 0, 0, 0);
                        drawFillables(objDrawer.DrawEllipse, objDrawer.FillEllipse, createRectangle(firstPoint, lastPoint));
                        break;
                    case Tools.Triangle:
                        lastTriangle = new Point[3];
                        drawFillables(objDrawer.DrawPolygon, objDrawer.FillPolygon, createTriangle(firstPoint, lastPoint));
                        break;
                    case Tools.RegularPolygon:
                        lastRegularPolygon = new Point[5];
                        outlineCircle = new RectangleF();
                        drawFillables(objDrawer.DrawPolygon, objDrawer.FillPolygon, createRegularPolygon(firstPoint, lastPoint));
                        break;
                    case Tools.IrregularPolygon:
                        if (checkIrregularPolygon())
                        {
                            drawFillables(objDrawer.DrawPolygon, objDrawer.FillPolygon, lastIrregularPolygon.ToArray());
                            lastIrregularPolygon = new List<Point>();
                        }
                        break;
                    case Tools.Arrow:
                        lastArrow = new Point[7];
                        drawFillables(objDrawer.DrawPolygon, objDrawer.FillPolygon, createArrow(firstPoint, lastPoint));
                        break;
                    case Tools.Selection:
                        if (isHolding)
                        {
                            objDrawer.DrawImage(lastImageSelection, lastSelection.Location);
                        }
                        else if (lastSelection.Width > 0 && lastSelection.Height > 0)
                        {
                            lastImageSelection = new Bitmap(lastSelection.Width, lastSelection.Height);
                            Graphics objSelect = Graphics.FromImage(lastImageSelection);
                            objSelect.DrawImage(canvas, 0, 0, lastSelection, GraphicsUnit.Pixel);
                            objSelect.Dispose();
                        }
                        break;
                    case Tools.Curve:
                        if (!lastCurve[3].IsEmpty)
                        {
                            objDrawer.DrawBezier(normalPen, lastCurve[0], lastCurve[2], lastCurve[3], lastCurve[1]);
                            lastCurve = new Point[4];
                        }
                        break;
                    case Tools.Star:
                        lastStar = new Point[6];
                        outlineCircle = new RectangleF();
                        drawFillables(objDrawer.DrawPolygon, objDrawer.FillPolygon, createStar(firstPoint, lastPoint));
                        break;
                    case Tools.Trapezoid:
                        lastQuad = new Point[4];
                        drawFillables(objDrawer.DrawPolygon, objDrawer.FillPolygon, createTrapezoid(firstPoint, lastPoint));
                        break;
                    case Tools.Diamond:
                        lastQuad = new Point[4];
                        drawFillables(objDrawer.DrawPolygon, objDrawer.FillPolygon, createDiamond(firstPoint, lastPoint));
                        break;
                    case Tools.RightTriangle:
                        lastTriangle = new Point[3];
                        drawFillables(objDrawer.DrawPolygon, objDrawer.FillPolygon, createRightTriangle(firstPoint, lastPoint));
                        break;
                    default:
                        break;
                }
                pnl_canvas.Refresh();
            }
        }
        private void pnl_canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvas, 0 , 0);
            switch (activeTool)
            {
                case Tools.Pen:
                case Tools.Brush:
                    if (lastPenDrawing != null)
                    {
                        e.Graphics.DrawImage(lastPenDrawing, 0, 0);
                    }
                    break;
                case Tools.Line:
                    e.Graphics.DrawLine(normalPen, lastLine[0], lastLine[1]);
                    break;
                case Tools.Rectangle:
                    drawFillables(e.Graphics.DrawRectangle, e.Graphics.FillRectangle, lastShape);
                    break;
                case Tools.Circle:
                    drawFillables(e.Graphics.DrawEllipse, e.Graphics.FillEllipse, lastShape);
                    break;
                case Tools.RightTriangle:
                case Tools.Triangle:
                    drawFillables(e.Graphics.DrawPolygon, e.Graphics.FillPolygon, lastTriangle);
                    break;
                case Tools.RegularPolygon:
                    drawFillables(e.Graphics.DrawPolygon, e.Graphics.FillPolygon, lastRegularPolygon);
                    e.Graphics.DrawEllipse(dottedPen, outlineCircle);
                    break;
                case Tools.IrregularPolygon:
                    if (chk_fill.Checked && lastIrregularPolygon.Count > 2)
                    {
                        e.Graphics.FillPolygon(fillBrush, lastIrregularPolygon.ToArray());
                    }
                    if (chk_outline.Checked && lastIrregularPolygon.Count > 1)
                    {
                        e.Graphics.DrawLines(normalPen, lastIrregularPolygon.ToArray());
                    }
                    e.Graphics.DrawEllipse(dottedPen, outlineCircle);
                    break;
                case Tools.Arrow:
                    drawFillables(e.Graphics.DrawPolygon, e.Graphics.FillPolygon, lastArrow);
                    break;
                case Tools.Text:
                    SizeF textSize = e.Graphics.MeasureString(lastString, current_font);
                    e.Graphics.DrawRectangle(dottedPen, firstPoint.X, firstPoint.Y, textSize.Width, textSize.Height);
                    SolidBrush sb = new SolidBrush(current_color);
                    e.Graphics.DrawString(lastString, current_font, sb, firstPoint);
                    break;
                case Tools.Selection:
                    e.Graphics.DrawRectangle(dottedPen, lastSelection);
                    if (lastImageSelection != null)
                    {
                        e.Graphics.DrawImage(lastImageSelection, lastSelection.Location);
                    }
                    break;
                case Tools.Curve:
                    if (lastCurve[2].IsEmpty)
                    {
                        e.Graphics.DrawLine(normalPen, lastCurve[0], lastCurve[1]);
                    }
                    else if (lastCurve[3].IsEmpty)
                    {
                        e.Graphics.DrawBezier(normalPen, lastCurve[0], lastCurve[2], lastCurve[2], lastCurve[1]);
                    }
                    else
                    {
                        e.Graphics.DrawBezier(normalPen, lastCurve[0], lastCurve[2], lastCurve[3], lastCurve[1]);
                    }
                    break;
                case Tools.Star:
                    drawFillables(e.Graphics.DrawPolygon, e.Graphics.FillPolygon, lastStar);
                    e.Graphics.DrawEllipse(dottedPen, outlineCircle);
                    break;
                case Tools.Trapezoid:
                case Tools.Diamond:
                    drawFillables(e.Graphics.DrawPolygon, e.Graphics.FillPolygon, lastQuad);
                    break;
                default:
                    break;
            }
        }

        //START: Hidden TextBox methods
        private void txt_hidden_TextChanged(object sender, EventArgs e)
        {
            lastString = txt_hidden.Text;
            pnl_canvas.Refresh();
        }
        private void txt_hidden_Leave(object sender, EventArgs e)
        {
            stampText();
        }
        
        //START: KeyBoard methods
        private void Paint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                squareMode = true;
            }
            else if (e.KeyCode == Keys.Z && e.Control && ctrlZStack.Count > 0)
            {
                using (objDrawer = Graphics.FromImage(canvas))
                {
                    if (isWriting && !(txt_hidden.Text==""))
                    {
                        txt_hidden.ClearUndo();
                        txt_hidden.Text = "";
                        return;
                    }
                    ctrlYStack.Push(new Bitmap(canvas));
                    Bitmap poppedBitmap = ctrlZStack.Pop();
                    objDrawer.DrawImage(poppedBitmap, 0, 0);
                    pnl_canvas.Refresh();
                }
            }
            else if (e.KeyCode == Keys.Y && e.Control && ctrlYStack.Count > 0)
            {
                using (objDrawer = Graphics.FromImage(canvas))
                {
                    if (isWriting)
                    {
                        txt_hidden.ClearUndo();
                        txt_hidden.Text = "";
                    }
                    ctrlZStack.Push(new Bitmap(canvas));
                    Bitmap poppedBitmap = ctrlYStack.Pop();
                    objDrawer.DrawImage(poppedBitmap, 0, 0);
                    pnl_canvas.Refresh();
                }
            }
            else if(e.KeyCode == Keys.X && e.Control && activeTool == Tools.Selection)
            {
                using (objDrawer = Graphics.FromImage(canvas))
                {
                    Clipboard.SetImage(lastImageSelection);
                    objDrawer.FillRectangle(new SolidBrush(Color.White), lastSelection);
                    lastSelection = new Rectangle();
                    lastImageSelection = null;
                    pnl_canvas.Refresh();
                }
            }
            else if (e.KeyCode == Keys.C && e.Control && activeTool == Tools.Selection)
            {
                Clipboard.SetImage(lastImageSelection);
            }
            else if (e.KeyCode == Keys.V && e.Control && activeTool == Tools.Selection)
            {
                using (objDrawer = Graphics.FromImage(canvas))
                {
                    closeToolProcesses();
                    resetVisibles();
                    activeTool = Tools.Selection;
                    btn_active.BackgroundImage = btn_selection.BackgroundImage;
                    isPasted = true;
                    lastImageSelection = (Bitmap)Clipboard.GetImage();
                    lastSelection = new Rectangle(0, 0, lastImageSelection.Width, lastImageSelection.Height);
                    pnl_canvas.Refresh();
                }
            }
        }
        private void Paint_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                squareMode = false;
            }

        }

        //START: Utilities (Such as creators, and other tools)
        private Point[] createLine(Point first, Point last)
        {
            if (squareMode)
            {
                int deltaX = last.X - first.X;
                int deltaY = last.Y - first.Y;
                if (deltaX != 0 && deltaY != 0)

                {
                    double ratio = Math.Abs((double)deltaX)/ Math.Abs((double)deltaY);
                    if (ratio > .5 && ratio < 2)
                    {
                        int minDelta = Math.Min(Math.Abs(deltaY), Math.Abs(deltaX));

                        Point normPoint = new Point(first.X + (minDelta * Math.Sign(deltaX)), first.Y + (minDelta * Math.Sign(deltaY)));
                        return new Point[] { first, normPoint };

                    }
                }
                if (Math.Abs(deltaX) > Math.Abs(deltaY))
                {
                    return new Point[] { first, new Point(last.X, first.Y)};
                }
                else
                {
                    return new Point[] { first, new Point(first.X, last.Y) };
                }
            }
            return new Point[] { first, last };
        }
        private Rectangle createRectangle(Point first, Point last)
        {
            Point p1 = new Point();
            p1.X = Math.Min(first.X, last.X);
            p1.Y = Math.Min(first.Y, last.Y);
            int deltaX, deltaY;
            deltaX = Math.Abs(first.X - last.X);
            deltaY = Math.Abs(first.Y - last.Y);
            if (squareMode)
            {
                int smaller = deltaX < deltaY ? deltaX : deltaY;
                deltaX = smaller;
                deltaY = smaller;
                p1.X = first.X > last.X ? first.X - smaller : first.X;
                p1.Y = first.Y > last.Y ? first.Y - smaller : first.Y;
            }
            return new Rectangle(p1, new Size(deltaX, deltaY));
        }
        private Point[] createTriangle(Point first, Point last)
        {
            Rectangle rectHelper = createRectangle(first, last);
            Point pointA = new Point(rectHelper.X, rectHelper.Y+rectHelper.Height);
            Point pointB = new Point(rectHelper.X + rectHelper.Width / 2, rectHelper.Y);
            Point pointC = new Point(rectHelper.X + rectHelper.Width, rectHelper.Y + rectHelper.Height);

            return new Point[] {pointA, pointB, pointC };
        }
        private Point[] createRegularPolygon(Point first, Point last)
        {
            int sides = (int)num_sides.Value;
            Point[] polygon = new Point[sides];
            double deltaX = last.X - first.X;
            double deltaY = last.Y - first.Y;
            double ratio = Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2);
            ratio = Math.Sqrt(ratio);
            double angle = getAngle(deltaX, deltaY);
            for (int i = 0; i < sides; i++)
            {
                double x = first.X - ratio * Math.Sin(2.0 * i * Math.PI / sides - angle);
                double y = first.Y - ratio * Math.Cos(2.0 * i * Math.PI / sides - angle);
                polygon[i] = new Point((int)Math.Round(x), (int)Math.Round(y));
            }
            return polygon;
        }
        private Point[] createStar(Point first, Point last)
        {
            int sides = (int)num_sides.Value;
            Point[] star = new Point[sides*2];
            double deltaX = last.X - first.X;
            double deltaY = last.Y - first.Y;
            double ratio = Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2);
            ratio = Math.Sqrt(ratio);
            double angle = getAngle(deltaX, deltaY);
            for (int i = 0; i < sides; i++)
            {
                double x = first.X - ratio * Math.Sin(2 * i * Math.PI / sides - angle);
                double y = first.Y - ratio * Math.Cos(2 * i * Math.PI / sides - angle);
                star[2*i] = new Point((int)Math.Round(x), (int)Math.Round(y));
            }
            angle -= Math.PI / sides;
            for (int i = 0; i < sides; i++)
            {
                double x = first.X - ratio * Math.Sin(2 * i * Math.PI / sides - angle)/3;
                double y = first.Y - ratio * Math.Cos(2 * i * Math.PI / sides - angle)/3;
                star[2 * i + 1] = new Point((int)Math.Round(x), (int)Math.Round(y));
            }

            return star;
        }
        private double getAngle(double deltaX, double deltaY)
        {
            double angle;
            if (deltaX == 0)
            {
                angle = deltaY < 0 ? 0 : Math.PI;
            }
            else
            {
                if (deltaX < 0)
                {
                    angle = 3 * Math.PI / 2 - (Math.Atan(deltaY / -deltaX));
                }
                else
                {
                    angle = Math.PI / 2 + (Math.Atan(deltaY / deltaX));
                }
            }
            if (squareMode)
            {
                angle = normalizeAngle(angle);
            }
            return angle;
        }
        private double normalizeAngle(double angle)
        {
            if (angle > Math.PI/4 && angle <= 3*Math.PI/4)
            {
                return Math.PI / 2;
            }
            if (angle > 3 * Math.PI / 4 && angle <= 5*Math.PI/4)
            {
                return Math.PI;
            }
            if (angle > 5*Math.PI/4 &&  angle <= 7*Math.PI/4)
            {
                return 3 * Math.PI / 2;
            }
            if (angle > 7*Math.PI/4 || angle <= Math.PI/4)
            {
                return 0;
            }
            return angle;
        }
        private RectangleF createCircle(Point first, Point last)
        {
            float ratio = (last.X - first.X) * (last.X - first.X) + (last.Y - first.Y) * (last.Y - first.Y);
            ratio = (float)Math.Sqrt(ratio);
            PointF corner = new PointF(first.X - ratio, first.Y - ratio);
            return new RectangleF(corner, new SizeF(2*ratio, 2*ratio));
        }
        private void createIrregularPolygon(Point p, bool moveLast = false)
        {
            if (squareMode && lastIrregularPolygon.Count > 0)
            {
                if (moveLast)
                {
                    p = createLine(lastIrregularPolygon[lastIrregularPolygon.Count - 2], p)[1];
                }
                else
                {
                    p = createLine(lastIrregularPolygon[lastIrregularPolygon.Count - 1], p)[1];
                }
            }
            if (moveLast)
            {
                lastIrregularPolygon[lastIrregularPolygon.Count - 1] = p;
            }
            else
            {
                if (lastIrregularPolygon.Count == 0)
                {
                    lastIrregularPolygon.Add(p);
                }
                lastIrregularPolygon.Add(p);
            }
        }
        private bool checkIrregularPolygon()
        {
            if (lastIrregularPolygon.Count < 3)
            {
                return false;
            }
            Point first = lastIrregularPolygon[0];
            Point last = lastIrregularPolygon[lastIrregularPolygon.Count - 1];
            double deltaX = last.X - first.X;
            double deltaY = last.Y - first.Y;
            double ratio = Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2);
            ratio = Math.Sqrt(ratio);
            if (ratio < 10)
            {
                lastIrregularPolygon[lastIrregularPolygon.Count - 1] = first;
                return true;
            }
            return false;
        }
        private void closeToolProcesses()
        {
            lastSelection = new Rectangle();
			lastImageSelection = null;
            isPasted = false;
            lastCurve = new Point[4];
            if (lastIrregularPolygon.Count > 0)
            {
                using (objDrawer = Graphics.FromImage(canvas))
                {
                    if (chk_fill.Checked)
                    {
                        objDrawer.FillPolygon(fillBrush, lastIrregularPolygon.ToArray());
                    }
                    if (chk_outline.Checked)
                    {
                        objDrawer.DrawPolygon(normalPen, lastIrregularPolygon.ToArray());
                    }
                    lastIrregularPolygon = new List<Point>();
                }
            }
            pnl_canvas.Refresh();
        }
        private Point[] createArrow(Point first, Point last)
        {
            int deltaX = last.X - first.X;
            int deltaY = last.Y - first.Y;

            Point[] newArrow = new Point[7];
            newArrow[0] = new Point(first.X, first.Y + deltaY / 4);
            newArrow[1] = new Point(first.X, last.Y - deltaY / 4);
            newArrow[2] = new Point(first.X + 3*deltaX / 5, last.Y - deltaY / 4);
            newArrow[3] = new Point(first.X + 3*deltaX / 5, last.Y);
            newArrow[4] = new Point(last.X, first.Y + deltaY / 2);
            newArrow[5] = new Point(first.X + 3*deltaX / 5, first.Y);
            newArrow[6] = new Point(first.X + 3*deltaX / 5, first.Y + deltaY / 4);

            return newArrow;
        }
        private void createSpray(Point p)
        {
            Random rand = new Random();
            double radius, angle;
            Point sprayPoint;
            for (int i = 0; i < (int)num_width.Value * 3; i++)
            {
                radius = rand.NextDouble() * (double)num_width.Value;
                angle = rand.NextDouble() * 2 * Math.PI;
                sprayPoint = new Point(p.X + (int)(radius * Math.Cos(angle)),p.Y + (int)(radius * Math.Sin(angle)));
                if (sprayPoint.X > 0 && sprayPoint.Y > 0 && sprayPoint.X < pnl_canvas.Width && sprayPoint.Y < pnl_canvas.Height)
                {
                    canvas.SetPixel(sprayPoint.X, sprayPoint.Y, current_color);
                }
            }
        }
        private Point[] createTrapezoid(Point first, Point last)
        {
            Rectangle rectHelper = createRectangle(first, last);
            Point pointA = new Point(rectHelper.X, rectHelper.Y + rectHelper.Height);
            Point pointB = new Point(rectHelper.X + rectHelper.Width /5, rectHelper.Y);
            Point pointC = new Point(rectHelper.X + 4*rectHelper.Width / 5, rectHelper.Y);
            Point pointD = new Point(rectHelper.X + rectHelper.Width, rectHelper.Y + rectHelper.Height);
            return new Point[] { pointA, pointB, pointC, pointD };
        }
        private Point[] createDiamond(Point first, Point last)
        {
            Rectangle rectHelper = createRectangle(first, last);
            Point pointA = new Point(rectHelper.X + rectHelper.Width / 2, rectHelper.Y);
            Point pointB = new Point(rectHelper.X + rectHelper.Width, rectHelper.Y+rectHelper.Height/2);
            Point pointC = new Point(rectHelper.X + rectHelper.Width / 2, rectHelper.Y + rectHelper.Height);
            Point pointD = new Point(rectHelper.X, rectHelper.Y + rectHelper.Height / 2);
            return new Point[] { pointA, pointB, pointC, pointD };
        }
        private Point[] createRightTriangle(Point first, Point last)
        {
            int deltaX = last.X - first.X;
            Rectangle rectHelper = createRectangle(first, last);
            Point pointA = new Point(first.X, rectHelper.Y);
            Point pointB = new Point(first.X, rectHelper.Y + rectHelper.Height);
            Point pointC = new Point(first.X + deltaX, rectHelper.Y + rectHelper.Height);

            return new Point[] { pointA, pointB, pointC };
        }
        private void fillBucket(int x, int y)
        {
            Color check_color = canvas.GetPixel(x, y);
            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(new Point(x, y));
            Point pixel;
            if (check_color.ToArgb() == current_color.ToArgb())
            {
                return;
            }
            while (pixels.Count > 0)
            {
                pixel = pixels.Dequeue();
                if (canvas.GetPixel(pixel.X, pixel.Y) == check_color)
                {
                    canvas.SetPixel(pixel.X, pixel.Y, current_color);
                    if (pixel.X != 0)
                    {
                        pixels.Enqueue(new Point(pixel.X - 1, pixel.Y));
                    }
                    if (pixel.X != canvas.Width - 1)
                    {
                        pixels.Enqueue(new Point(pixel.X + 1, pixel.Y));
                    }
                    if (pixel.Y != 0)
                    {
                        pixels.Enqueue(new Point(pixel.X, pixel.Y - 1));
                    }
                    if (pixel.Y != canvas.Height - 1)
                    {
                        pixels.Enqueue(new Point(pixel.X, pixel.Y + 1));
                    }
                }
            } 
        }
        private void stampText()
        {
            if (isWriting)
            {
                isWriting = false;
                using (objDrawer = Graphics.FromImage(canvas))
                {
                    SolidBrush sb = new SolidBrush(current_color);
                    objDrawer.DrawString(lastString, current_font, sb, lastPoint);
                    lastString = "";
                    txt_hidden.Text = "";
                }
            }
        }
        private void drawFillables<T>(Action<Pen, T> lineFunction, Action<SolidBrush, T> fillFunction, T figure)
        {
            if (chk_fill.Checked)
            {
                fillFunction(fillBrush, figure);
            }
            if (chk_outline.Checked)
            {
                lineFunction(normalPen, figure);
            }
        }
    }
}
