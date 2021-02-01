namespace Paint
{
    partial class Paint
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFile_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFile_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.spcPrincipal = new System.Windows.Forms.SplitContainer();
            this.btn_trianrect = new System.Windows.Forms.Button();
            this.btn_diamond = new System.Windows.Forms.Button();
            this.btn_trapezoid = new System.Windows.Forms.Button();
            this.btn_star = new System.Windows.Forms.Button();
            this.btn_curve = new System.Windows.Forms.Button();
            this.btn_spray = new System.Windows.Forms.Button();
            this.btn_selection = new System.Windows.Forms.Button();
            this.btn_arrow = new System.Windows.Forms.Button();
            this.btn_shape = new System.Windows.Forms.Button();
            this.btn_pick = new System.Windows.Forms.Button();
            this.btn_polygon = new System.Windows.Forms.Button();
            this.btn_brush = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_font = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_text = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_colores = new System.Windows.Forms.Button();
            this.btn_erase_all = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_pen = new System.Windows.Forms.Button();
            this.pnl_color = new System.Windows.Forms.Panel();
            this.btn_active = new System.Windows.Forms.Button();
            this.chk_fill = new System.Windows.Forms.CheckBox();
            this.lbl_2ndcolor = new System.Windows.Forms.Label();
            this.num_sides = new System.Windows.Forms.NumericUpDown();
            this.lbl_sides = new System.Windows.Forms.Label();
            this.pnl_color2 = new System.Windows.Forms.Panel();
            this.chk_outline = new System.Windows.Forms.CheckBox();
            this.lbl_red2 = new System.Windows.Forms.Label();
            this.lbl_green2 = new System.Windows.Forms.Label();
            this.lbl_blue2 = new System.Windows.Forms.Label();
            this.num_red2 = new System.Windows.Forms.NumericUpDown();
            this.num_green2 = new System.Windows.Forms.NumericUpDown();
            this.num_blue2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_red = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.num_width = new System.Windows.Forms.NumericUpDown();
            this.num_red = new System.Windows.Forms.NumericUpDown();
            this.lbl_width = new System.Windows.Forms.Label();
            this.num_green = new System.Windows.Forms.NumericUpDown();
            this.num_blue = new System.Windows.Forms.NumericUpDown();
            this.pnl_canvas = new System.Windows.Forms.Panel();
            this.cdgPaletadeColores = new System.Windows.Forms.ColorDialog();
            this.fdgTipoLetra = new System.Windows.Forms.FontDialog();
            this.ofdAbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.sfdGuardarArchivo = new System.Windows.Forms.SaveFileDialog();
            this.sts_status = new System.Windows.Forms.StatusStrip();
            this.lblCoordenadas = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_hidden = new System.Windows.Forms.TextBox();
            this.lbl_alpha = new System.Windows.Forms.Label();
            this.num_alpha = new System.Windows.Forms.NumericUpDown();
            this.lbl_alpha2 = new System.Windows.Forms.Label();
            this.num_alpha2 = new System.Windows.Forms.NumericUpDown();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).BeginInit();
            this.spcPrincipal.Panel1.SuspendLayout();
            this.spcPrincipal.Panel2.SuspendLayout();
            this.spcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_sides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_red2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blue)).BeginInit();
            this.sts_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_alpha2)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuAbout});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile_new,
            this.menuFile_open,
            this.menuFile_save,
            this.menuFile_saveAs,
            this.toolStripMenuItem1,
            this.menuFile_exit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuFile_new
            // 
            this.menuFile_new.Name = "menuFile_new";
            this.menuFile_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFile_new.Size = new System.Drawing.Size(211, 22);
            this.menuFile_new.Text = "New";
            this.menuFile_new.Click += new System.EventHandler(this.menuFile_new_Click);
            // 
            // menuFile_open
            // 
            this.menuFile_open.Name = "menuFile_open";
            this.menuFile_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuFile_open.Size = new System.Drawing.Size(211, 22);
            this.menuFile_open.Text = "Open";
            this.menuFile_open.Click += new System.EventHandler(this.menuFile_open_Click);
            // 
            // menuFile_save
            // 
            this.menuFile_save.Name = "menuFile_save";
            this.menuFile_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menuFile_save.Size = new System.Drawing.Size(211, 22);
            this.menuFile_save.Text = "Save";
            this.menuFile_save.Click += new System.EventHandler(this.menuFile_save_Click);
            // 
            // menuFile_saveAs
            // 
            this.menuFile_saveAs.Name = "menuFile_saveAs";
            this.menuFile_saveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.menuFile_saveAs.Size = new System.Drawing.Size(211, 22);
            this.menuFile_saveAs.Text = "Save As...";
            this.menuFile_saveAs.Click += new System.EventHandler(this.menuFile_saveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 6);
            // 
            // menuFile_exit
            // 
            this.menuFile_exit.Name = "menuFile_exit";
            this.menuFile_exit.Size = new System.Drawing.Size(211, 22);
            this.menuFile_exit.Text = "Exit";
            this.menuFile_exit.Click += new System.EventHandler(this.menuFile_exit_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(52, 20);
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // spcPrincipal
            // 
            this.spcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPrincipal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcPrincipal.IsSplitterFixed = true;
            this.spcPrincipal.Location = new System.Drawing.Point(0, 24);
            this.spcPrincipal.MinimumSize = new System.Drawing.Size(784, 537);
            this.spcPrincipal.Name = "spcPrincipal";
            // 
            // spcPrincipal.Panel1
            // 
            this.spcPrincipal.Panel1.BackColor = System.Drawing.Color.White;
            this.spcPrincipal.Panel1.Controls.Add(this.btn_trianrect);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_diamond);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_trapezoid);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_star);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_curve);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_spray);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_selection);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_arrow);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_shape);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_pick);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_polygon);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_brush);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_triangle);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_font);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_fill);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_text);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_circle);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_rect);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_colores);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_erase_all);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_eraser);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_line);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_pen);
            this.spcPrincipal.Panel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            // 
            // spcPrincipal.Panel2
            // 
            this.spcPrincipal.Panel2.BackColor = System.Drawing.Color.Silver;
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_alpha2);
            this.spcPrincipal.Panel2.Controls.Add(this.num_alpha2);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_alpha);
            this.spcPrincipal.Panel2.Controls.Add(this.num_alpha);
            this.spcPrincipal.Panel2.Controls.Add(this.pnl_color);
            this.spcPrincipal.Panel2.Controls.Add(this.btn_active);
            this.spcPrincipal.Panel2.Controls.Add(this.chk_fill);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_2ndcolor);
            this.spcPrincipal.Panel2.Controls.Add(this.num_sides);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_sides);
            this.spcPrincipal.Panel2.Controls.Add(this.pnl_color2);
            this.spcPrincipal.Panel2.Controls.Add(this.chk_outline);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_red2);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_green2);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_blue2);
            this.spcPrincipal.Panel2.Controls.Add(this.num_red2);
            this.spcPrincipal.Panel2.Controls.Add(this.num_green2);
            this.spcPrincipal.Panel2.Controls.Add(this.num_blue2);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_red);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_green);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_blue);
            this.spcPrincipal.Panel2.Controls.Add(this.num_width);
            this.spcPrincipal.Panel2.Controls.Add(this.num_red);
            this.spcPrincipal.Panel2.Controls.Add(this.lbl_width);
            this.spcPrincipal.Panel2.Controls.Add(this.num_green);
            this.spcPrincipal.Panel2.Controls.Add(this.num_blue);
            this.spcPrincipal.Panel2.Controls.Add(this.pnl_canvas);
            this.spcPrincipal.Panel2MinSize = 640;
            this.spcPrincipal.Size = new System.Drawing.Size(784, 537);
            this.spcPrincipal.SplitterDistance = 140;
            this.spcPrincipal.TabIndex = 1;
            // 
            // btn_trianrect
            // 
            this.btn_trianrect.BackgroundImage = global::Paint.Properties.Resources.trigonometry;
            this.btn_trianrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_trianrect.Location = new System.Drawing.Point(97, 285);
            this.btn_trianrect.Name = "btn_trianrect";
            this.btn_trianrect.Size = new System.Drawing.Size(40, 40);
            this.btn_trianrect.TabIndex = 31;
            this.btn_trianrect.UseVisualStyleBackColor = true;
            this.btn_trianrect.Click += new System.EventHandler(this.btn_trianrect_Click);
            // 
            // btn_diamond
            // 
            this.btn_diamond.BackgroundImage = global::Paint.Properties.Resources.rhomb_outline;
            this.btn_diamond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_diamond.Location = new System.Drawing.Point(51, 285);
            this.btn_diamond.Name = "btn_diamond";
            this.btn_diamond.Size = new System.Drawing.Size(40, 40);
            this.btn_diamond.TabIndex = 30;
            this.btn_diamond.UseVisualStyleBackColor = true;
            this.btn_diamond.Click += new System.EventHandler(this.btn_diamond_Click);
            // 
            // btn_trapezoid
            // 
            this.btn_trapezoid.BackgroundImage = global::Paint.Properties.Resources.trapezoid;
            this.btn_trapezoid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_trapezoid.Location = new System.Drawing.Point(5, 285);
            this.btn_trapezoid.Name = "btn_trapezoid";
            this.btn_trapezoid.Size = new System.Drawing.Size(40, 40);
            this.btn_trapezoid.TabIndex = 29;
            this.btn_trapezoid.UseVisualStyleBackColor = true;
            this.btn_trapezoid.Click += new System.EventHandler(this.btn_trapezoid_Click);
            // 
            // btn_star
            // 
            this.btn_star.BackgroundImage = global::Paint.Properties.Resources.star_1;
            this.btn_star.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_star.Location = new System.Drawing.Point(97, 239);
            this.btn_star.Name = "btn_star";
            this.btn_star.Size = new System.Drawing.Size(40, 40);
            this.btn_star.TabIndex = 28;
            this.btn_star.UseVisualStyleBackColor = true;
            this.btn_star.Click += new System.EventHandler(this.btn_star_Click);
            // 
            // btn_curve
            // 
            this.btn_curve.BackgroundImage = global::Paint.Properties.Resources.curved_line;
            this.btn_curve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_curve.Location = new System.Drawing.Point(51, 239);
            this.btn_curve.Name = "btn_curve";
            this.btn_curve.Size = new System.Drawing.Size(40, 40);
            this.btn_curve.TabIndex = 27;
            this.btn_curve.UseVisualStyleBackColor = true;
            this.btn_curve.Click += new System.EventHandler(this.btn_curve_Click);
            // 
            // btn_spray
            // 
            this.btn_spray.BackgroundImage = global::Paint.Properties.Resources._048_spray;
            this.btn_spray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_spray.Location = new System.Drawing.Point(5, 239);
            this.btn_spray.Name = "btn_spray";
            this.btn_spray.Size = new System.Drawing.Size(40, 40);
            this.btn_spray.TabIndex = 26;
            this.btn_spray.UseVisualStyleBackColor = true;
            this.btn_spray.Click += new System.EventHandler(this.btn_spray_Click);
            // 
            // btn_selection
            // 
            this.btn_selection.BackgroundImage = global::Paint.Properties.Resources.select;
            this.btn_selection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_selection.Location = new System.Drawing.Point(97, 193);
            this.btn_selection.Name = "btn_selection";
            this.btn_selection.Size = new System.Drawing.Size(40, 40);
            this.btn_selection.TabIndex = 25;
            this.btn_selection.UseVisualStyleBackColor = true;
            this.btn_selection.Click += new System.EventHandler(this.btn_selection_Click);
            // 
            // btn_arrow
            // 
            this.btn_arrow.BackgroundImage = global::Paint.Properties.Resources.long_arrow_pointing_to_the_right;
            this.btn_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_arrow.Location = new System.Drawing.Point(51, 193);
            this.btn_arrow.Name = "btn_arrow";
            this.btn_arrow.Size = new System.Drawing.Size(40, 40);
            this.btn_arrow.TabIndex = 24;
            this.btn_arrow.UseVisualStyleBackColor = true;
            this.btn_arrow.Click += new System.EventHandler(this.btn_arrow_Click);
            // 
            // btn_shape
            // 
            this.btn_shape.BackgroundImage = global::Paint.Properties.Resources.irregular_outlined_shape;
            this.btn_shape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_shape.Location = new System.Drawing.Point(5, 193);
            this.btn_shape.Name = "btn_shape";
            this.btn_shape.Size = new System.Drawing.Size(40, 40);
            this.btn_shape.TabIndex = 23;
            this.btn_shape.UseVisualStyleBackColor = true;
            this.btn_shape.Click += new System.EventHandler(this.btn_shape_Click);
            // 
            // btn_pick
            // 
            this.btn_pick.BackgroundImage = global::Paint.Properties.Resources._013_pipette;
            this.btn_pick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pick.Location = new System.Drawing.Point(97, 148);
            this.btn_pick.Name = "btn_pick";
            this.btn_pick.Size = new System.Drawing.Size(40, 40);
            this.btn_pick.TabIndex = 22;
            this.btn_pick.UseVisualStyleBackColor = true;
            this.btn_pick.Click += new System.EventHandler(this.btn_pick_Click);
            // 
            // btn_polygon
            // 
            this.btn_polygon.BackgroundImage = global::Paint.Properties.Resources.pentagon_outline_shape;
            this.btn_polygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_polygon.Location = new System.Drawing.Point(51, 147);
            this.btn_polygon.Name = "btn_polygon";
            this.btn_polygon.Size = new System.Drawing.Size(40, 40);
            this.btn_polygon.TabIndex = 21;
            this.btn_polygon.UseVisualStyleBackColor = true;
            this.btn_polygon.Click += new System.EventHandler(this.btn_polygon_Click);
            // 
            // btn_brush
            // 
            this.btn_brush.BackgroundImage = global::Paint.Properties.Resources.paintbrush;
            this.btn_brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_brush.Location = new System.Drawing.Point(97, 100);
            this.btn_brush.Name = "btn_brush";
            this.btn_brush.Size = new System.Drawing.Size(40, 40);
            this.btn_brush.TabIndex = 20;
            this.btn_brush.UseVisualStyleBackColor = true;
            this.btn_brush.Click += new System.EventHandler(this.btn_brush_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.BackgroundImage = global::Paint.Properties.Resources.triangle;
            this.btn_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_triangle.Location = new System.Drawing.Point(5, 147);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(40, 40);
            this.btn_triangle.TabIndex = 19;
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_font
            // 
            this.btn_font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_font.BackgroundImage = global::Paint.Properties.Resources.textformatting;
            this.btn_font.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_font.Location = new System.Drawing.Point(77, 452);
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(60, 60);
            this.btn_font.TabIndex = 18;
            this.btn_font.UseVisualStyleBackColor = true;
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.BackgroundImage = global::Paint.Properties.Resources.paintbucket;
            this.btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fill.Location = new System.Drawing.Point(51, 100);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(40, 40);
            this.btn_fill.TabIndex = 17;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_text
            // 
            this.btn_text.BackgroundImage = global::Paint.Properties.Resources.typography;
            this.btn_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_text.Location = new System.Drawing.Point(5, 100);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(40, 40);
            this.btn_text.TabIndex = 16;
            this.btn_text.UseVisualStyleBackColor = true;
            this.btn_text.Click += new System.EventHandler(this.btn_text_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.BackgroundImage = global::Paint.Properties.Resources.ellipse;
            this.btn_circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_circle.Location = new System.Drawing.Point(5, 54);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(40, 40);
            this.btn_circle.TabIndex = 15;
            this.btn_circle.UseVisualStyleBackColor = true;
            this.btn_circle.Click += new System.EventHandler(this.btn_circle_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackgroundImage = global::Paint.Properties.Resources.rectangle;
            this.btn_rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rect.Location = new System.Drawing.Point(97, 8);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(40, 40);
            this.btn_rect.TabIndex = 14;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_colores
            // 
            this.btn_colores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_colores.BackgroundImage = global::Paint.Properties.Resources.paintpalette;
            this.btn_colores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_colores.Location = new System.Drawing.Point(5, 452);
            this.btn_colores.Name = "btn_colores";
            this.btn_colores.Size = new System.Drawing.Size(60, 60);
            this.btn_colores.TabIndex = 13;
            this.btn_colores.UseVisualStyleBackColor = true;
            this.btn_colores.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_erase_all
            // 
            this.btn_erase_all.BackgroundImage = global::Paint.Properties.Resources.bomb;
            this.btn_erase_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_erase_all.Location = new System.Drawing.Point(97, 54);
            this.btn_erase_all.Name = "btn_erase_all";
            this.btn_erase_all.Size = new System.Drawing.Size(40, 40);
            this.btn_erase_all.TabIndex = 12;
            this.btn_erase_all.UseVisualStyleBackColor = true;
            this.btn_erase_all.Click += new System.EventHandler(this.btn_erase_all_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackgroundImage = global::Paint.Properties.Resources.eraser;
            this.btn_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eraser.Location = new System.Drawing.Point(51, 54);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(40, 40);
            this.btn_eraser.TabIndex = 9;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackgroundImage = global::Paint.Properties.Resources.diagonalline;
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_line.Location = new System.Drawing.Point(51, 8);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(40, 40);
            this.btn_line.TabIndex = 1;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_pen
            // 
            this.btn_pen.BackgroundImage = global::Paint.Properties.Resources.pencil;
            this.btn_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pen.Location = new System.Drawing.Point(5, 8);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(40, 40);
            this.btn_pen.TabIndex = 0;
            this.btn_pen.UseVisualStyleBackColor = true;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // pnl_color
            // 
            this.pnl_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_color.BackColor = System.Drawing.Color.Black;
            this.pnl_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_color.Location = new System.Drawing.Point(566, 71);
            this.pnl_color.Name = "pnl_color";
            this.pnl_color.Size = new System.Drawing.Size(62, 50);
            this.pnl_color.TabIndex = 2;
            this.pnl_color.DoubleClick += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_active
            // 
            this.btn_active.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_active.BackgroundImage = global::Paint.Properties.Resources.pencil;
            this.btn_active.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_active.Enabled = false;
            this.btn_active.Location = new System.Drawing.Point(566, 3);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(62, 62);
            this.btn_active.TabIndex = 17;
            this.btn_active.UseVisualStyleBackColor = true;
            // 
            // chk_fill
            // 
            this.chk_fill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chk_fill.AutoSize = true;
            this.chk_fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_fill.Location = new System.Drawing.Point(565, 479);
            this.chk_fill.Name = "chk_fill";
            this.chk_fill.Size = new System.Drawing.Size(47, 24);
            this.chk_fill.TabIndex = 18;
            this.chk_fill.Text = "Fill";
            this.chk_fill.UseVisualStyleBackColor = true;
            this.chk_fill.Visible = false;
            this.chk_fill.CheckedChanged += new System.EventHandler(this.chk_opt_CheckedChanged);
            // 
            // lbl_2ndcolor
            // 
            this.lbl_2ndcolor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_2ndcolor.AutoSize = true;
            this.lbl_2ndcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2ndcolor.Location = new System.Drawing.Point(559, 308);
            this.lbl_2ndcolor.Name = "lbl_2ndcolor";
            this.lbl_2ndcolor.Size = new System.Drawing.Size(84, 24);
            this.lbl_2ndcolor.TabIndex = 22;
            this.lbl_2ndcolor.Text = "2° Color";
            this.lbl_2ndcolor.Visible = false;
            // 
            // num_sides
            // 
            this.num_sides.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num_sides.Location = new System.Drawing.Point(564, 285);
            this.num_sides.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_sides.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_sides.Name = "num_sides";
            this.num_sides.Size = new System.Drawing.Size(73, 20);
            this.num_sides.TabIndex = 21;
            this.num_sides.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.num_sides.Visible = false;
            // 
            // lbl_sides
            // 
            this.lbl_sides.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_sides.AutoSize = true;
            this.lbl_sides.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sides.Location = new System.Drawing.Point(560, 258);
            this.lbl_sides.Name = "lbl_sides";
            this.lbl_sides.Size = new System.Drawing.Size(62, 24);
            this.lbl_sides.TabIndex = 20;
            this.lbl_sides.Text = "Sides";
            this.lbl_sides.Visible = false;
            // 
            // pnl_color2
            // 
            this.pnl_color2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnl_color2.BackColor = System.Drawing.Color.White;
            this.pnl_color2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_color2.Location = new System.Drawing.Point(566, 334);
            this.pnl_color2.Name = "pnl_color2";
            this.pnl_color2.Size = new System.Drawing.Size(62, 24);
            this.pnl_color2.TabIndex = 9;
            this.pnl_color2.Visible = false;
            this.pnl_color2.DoubleClick += new System.EventHandler(this.pnl_Color2_DoubleClick);
            // 
            // chk_outline
            // 
            this.chk_outline.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chk_outline.AutoSize = true;
            this.chk_outline.Checked = true;
            this.chk_outline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_outline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_outline.Location = new System.Drawing.Point(565, 448);
            this.chk_outline.Name = "chk_outline";
            this.chk_outline.Size = new System.Drawing.Size(78, 24);
            this.chk_outline.TabIndex = 19;
            this.chk_outline.Text = "Outline";
            this.chk_outline.UseVisualStyleBackColor = true;
            this.chk_outline.Visible = false;
            this.chk_outline.CheckedChanged += new System.EventHandler(this.chk_opt_CheckedChanged);
            // 
            // lbl_red2
            // 
            this.lbl_red2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_red2.AutoSize = true;
            this.lbl_red2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red2.Location = new System.Drawing.Point(563, 364);
            this.lbl_red2.Name = "lbl_red2";
            this.lbl_red2.Size = new System.Drawing.Size(16, 13);
            this.lbl_red2.TabIndex = 10;
            this.lbl_red2.Text = "R";
            this.lbl_red2.Visible = false;
            // 
            // lbl_green2
            // 
            this.lbl_green2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_green2.AutoSize = true;
            this.lbl_green2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green2.Location = new System.Drawing.Point(563, 387);
            this.lbl_green2.Name = "lbl_green2";
            this.lbl_green2.Size = new System.Drawing.Size(16, 13);
            this.lbl_green2.TabIndex = 11;
            this.lbl_green2.Text = "G";
            this.lbl_green2.Visible = false;
            // 
            // lbl_blue2
            // 
            this.lbl_blue2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_blue2.AutoSize = true;
            this.lbl_blue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue2.Location = new System.Drawing.Point(563, 409);
            this.lbl_blue2.Name = "lbl_blue2";
            this.lbl_blue2.Size = new System.Drawing.Size(15, 13);
            this.lbl_blue2.TabIndex = 12;
            this.lbl_blue2.Text = "B";
            this.lbl_blue2.Visible = false;
            // 
            // num_red2
            // 
            this.num_red2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num_red2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_red2.Location = new System.Drawing.Point(582, 362);
            this.num_red2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_red2.Name = "num_red2";
            this.num_red2.Size = new System.Drawing.Size(46, 20);
            this.num_red2.TabIndex = 13;
            this.num_red2.Visible = false;
            this.num_red2.ValueChanged += new System.EventHandler(this.num_color2_ValueChanged);
            // 
            // num_green2
            // 
            this.num_green2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num_green2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_green2.Location = new System.Drawing.Point(582, 385);
            this.num_green2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_green2.Name = "num_green2";
            this.num_green2.Size = new System.Drawing.Size(46, 20);
            this.num_green2.TabIndex = 14;
            this.num_green2.Visible = false;
            this.num_green2.ValueChanged += new System.EventHandler(this.num_color2_ValueChanged);
            // 
            // num_blue2
            // 
            this.num_blue2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.num_blue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_blue2.Location = new System.Drawing.Point(582, 407);
            this.num_blue2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_blue2.Name = "num_blue2";
            this.num_blue2.Size = new System.Drawing.Size(46, 20);
            this.num_blue2.TabIndex = 15;
            this.num_blue2.Visible = false;
            this.num_blue2.ValueChanged += new System.EventHandler(this.num_color2_ValueChanged);
            // 
            // lbl_red
            // 
            this.lbl_red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_red.AutoSize = true;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red.Location = new System.Drawing.Point(563, 125);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(16, 13);
            this.lbl_red.TabIndex = 3;
            this.lbl_red.Text = "R";
            // 
            // lbl_green
            // 
            this.lbl_green.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_green.AutoSize = true;
            this.lbl_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green.Location = new System.Drawing.Point(563, 147);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(16, 13);
            this.lbl_green.TabIndex = 4;
            this.lbl_green.Text = "G";
            // 
            // lbl_blue
            // 
            this.lbl_blue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue.Location = new System.Drawing.Point(563, 168);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(15, 13);
            this.lbl_blue.TabIndex = 5;
            this.lbl_blue.Text = "B";
            // 
            // num_width
            // 
            this.num_width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_width.Location = new System.Drawing.Point(564, 235);
            this.num_width.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.num_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_width.Name = "num_width";
            this.num_width.Size = new System.Drawing.Size(73, 20);
            this.num_width.TabIndex = 11;
            this.num_width.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_width.ValueChanged += new System.EventHandler(this.num_width_ValueChanged);
            // 
            // num_red
            // 
            this.num_red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_red.Location = new System.Drawing.Point(582, 123);
            this.num_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_red.Name = "num_red";
            this.num_red.Size = new System.Drawing.Size(46, 20);
            this.num_red.TabIndex = 6;
            this.num_red.ValueChanged += new System.EventHandler(this.num_color_ValueChanged);
            // 
            // lbl_width
            // 
            this.lbl_width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_width.AutoSize = true;
            this.lbl_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_width.Location = new System.Drawing.Point(560, 208);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(63, 24);
            this.lbl_width.TabIndex = 10;
            this.lbl_width.Text = "Width";
            // 
            // num_green
            // 
            this.num_green.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_green.Location = new System.Drawing.Point(582, 145);
            this.num_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_green.Name = "num_green";
            this.num_green.Size = new System.Drawing.Size(46, 20);
            this.num_green.TabIndex = 7;
            this.num_green.ValueChanged += new System.EventHandler(this.num_color_ValueChanged);
            // 
            // num_blue
            // 
            this.num_blue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_blue.Location = new System.Drawing.Point(582, 166);
            this.num_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_blue.Name = "num_blue";
            this.num_blue.Size = new System.Drawing.Size(46, 20);
            this.num_blue.TabIndex = 8;
            this.num_blue.ValueChanged += new System.EventHandler(this.num_color_ValueChanged);
            // 
            // pnl_canvas
            // 
            this.pnl_canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_canvas.BackColor = System.Drawing.Color.White;
            this.pnl_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnl_canvas.Location = new System.Drawing.Point(3, 3);
            this.pnl_canvas.MaximumSize = new System.Drawing.Size(1123, 681);
            this.pnl_canvas.MinimumSize = new System.Drawing.Size(2, 2);
            this.pnl_canvas.Name = "pnl_canvas";
            this.pnl_canvas.Size = new System.Drawing.Size(550, 500);
            this.pnl_canvas.TabIndex = 0;
            this.pnl_canvas.SizeChanged += new System.EventHandler(this.pnl_canvas_SizeChanged);
            this.pnl_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_canvas_Paint);
            this.pnl_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseDown);
            this.pnl_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseMove);
            this.pnl_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseUp);
            // 
            // ofdAbrirArchivo
            // 
            this.ofdAbrirArchivo.FileName = "openFileDialog1";
            // 
            // sts_status
            // 
            this.sts_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCoordenadas});
            this.sts_status.Location = new System.Drawing.Point(0, 539);
            this.sts_status.Name = "sts_status";
            this.sts_status.Size = new System.Drawing.Size(784, 22);
            this.sts_status.TabIndex = 2;
            this.sts_status.Text = "statusStrip1";
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(0, 17);
            // 
            // txt_hidden
            // 
            this.txt_hidden.Location = new System.Drawing.Point(0, -100);
            this.txt_hidden.Multiline = true;
            this.txt_hidden.Name = "txt_hidden";
            this.txt_hidden.Size = new System.Drawing.Size(100, 20);
            this.txt_hidden.TabIndex = 0;
            this.txt_hidden.TextChanged += new System.EventHandler(this.txt_hidden_TextChanged);
            this.txt_hidden.Leave += new System.EventHandler(this.txt_hidden_Leave);
            // 
            // lbl_alpha
            // 
            this.lbl_alpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_alpha.AutoSize = true;
            this.lbl_alpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alpha.Location = new System.Drawing.Point(563, 191);
            this.lbl_alpha.Name = "lbl_alpha";
            this.lbl_alpha.Size = new System.Drawing.Size(15, 13);
            this.lbl_alpha.TabIndex = 23;
            this.lbl_alpha.Text = "A";
            // 
            // num_alpha
            // 
            this.num_alpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_alpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_alpha.Location = new System.Drawing.Point(582, 189);
            this.num_alpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_alpha.Name = "num_alpha";
            this.num_alpha.Size = new System.Drawing.Size(46, 20);
            this.num_alpha.TabIndex = 24;
            this.num_alpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_alpha.ValueChanged += new System.EventHandler(this.num_color_ValueChanged);
            // 
            // lbl_alpha2
            // 
            this.lbl_alpha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_alpha2.AutoSize = true;
            this.lbl_alpha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alpha2.Location = new System.Drawing.Point(564, 432);
            this.lbl_alpha2.Name = "lbl_alpha2";
            this.lbl_alpha2.Size = new System.Drawing.Size(15, 13);
            this.lbl_alpha2.TabIndex = 25;
            this.lbl_alpha2.Text = "A";
            this.lbl_alpha2.Visible = false;
            // 
            // num_alpha2
            // 
            this.num_alpha2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_alpha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_alpha2.Location = new System.Drawing.Point(583, 430);
            this.num_alpha2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_alpha2.Name = "num_alpha2";
            this.num_alpha2.Size = new System.Drawing.Size(46, 20);
            this.num_alpha2.TabIndex = 26;
            this.num_alpha2.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_alpha2.Visible = false;
            this.num_alpha2.ValueChanged += new System.EventHandler(this.num_color2_ValueChanged);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txt_hidden);
            this.Controls.Add(this.sts_status);
            this.Controls.Add(this.spcPrincipal);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint ITH";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Paint_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Paint_KeyUp);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.spcPrincipal.Panel1.ResumeLayout(false);
            this.spcPrincipal.Panel2.ResumeLayout(false);
            this.spcPrincipal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).EndInit();
            this.spcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_sides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_red2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_blue)).EndInit();
            this.sts_status.ResumeLayout(false);
            this.sts_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_alpha2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFile_new;
        private System.Windows.Forms.ToolStripMenuItem menuFile_open;
        private System.Windows.Forms.ToolStripMenuItem menuFile_save;
        private System.Windows.Forms.ToolStripMenuItem menuFile_saveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuFile_exit;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.SplitContainer spcPrincipal;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Panel pnl_color;
        private System.Windows.Forms.NumericUpDown num_red;
        private System.Windows.Forms.NumericUpDown num_green;
        private System.Windows.Forms.NumericUpDown num_blue;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.NumericUpDown num_width;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Button btn_erase_all;
        private System.Windows.Forms.Panel pnl_canvas;
        private System.Windows.Forms.Button btn_colores;
        private System.Windows.Forms.ColorDialog cdgPaletadeColores;
        private System.Windows.Forms.FontDialog fdgTipoLetra;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArchivo;
        private System.Windows.Forms.SaveFileDialog sfdGuardarArchivo;
        private System.Windows.Forms.Button btn_circle;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.Button btn_active;
        private System.Windows.Forms.StatusStrip sts_status;
        private System.Windows.Forms.ToolStripStatusLabel lblCoordenadas;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.Button btn_font;
        private System.Windows.Forms.Button btn_polygon;
        private System.Windows.Forms.Button btn_brush;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.TextBox txt_hidden;
        private System.Windows.Forms.Label lbl_2ndcolor;
        private System.Windows.Forms.NumericUpDown num_sides;
        private System.Windows.Forms.Label lbl_sides;
        private System.Windows.Forms.Panel pnl_color2;
        private System.Windows.Forms.CheckBox chk_outline;
        private System.Windows.Forms.Label lbl_red2;
        private System.Windows.Forms.Label lbl_green2;
        private System.Windows.Forms.CheckBox chk_fill;
        private System.Windows.Forms.Label lbl_blue2;
        private System.Windows.Forms.NumericUpDown num_red2;
        private System.Windows.Forms.NumericUpDown num_green2;
        private System.Windows.Forms.NumericUpDown num_blue2;
        private System.Windows.Forms.Button btn_shape;
        private System.Windows.Forms.Button btn_pick;
        private System.Windows.Forms.Button btn_arrow;
        private System.Windows.Forms.Button btn_star;
        private System.Windows.Forms.Button btn_curve;
        private System.Windows.Forms.Button btn_spray;
        private System.Windows.Forms.Button btn_selection;
        private System.Windows.Forms.Button btn_trianrect;
        private System.Windows.Forms.Button btn_diamond;
        private System.Windows.Forms.Button btn_trapezoid;
        private System.Windows.Forms.Label lbl_alpha2;
        private System.Windows.Forms.NumericUpDown num_alpha2;
        private System.Windows.Forms.Label lbl_alpha;
        private System.Windows.Forms.NumericUpDown num_alpha;
    }
}

