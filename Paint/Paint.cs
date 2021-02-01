using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        string mouseStatus = "None";

        Color current_color = Color.Black;

        bool isClicking = false;

        Point firstPoint, lastPoint;

        public Paint()
        {
            InitializeComponent();
        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
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

        private void num_color_ValueChanged(object sender, EventArgs e)
        {
            current_color = Color.FromArgb(255, (int)num_red.Value, (int)num_green.Value, (int)num_blue.Value);
            pnl_Color.BackColor = current_color;
        }

        private void btn_pen_Click(object sender, EventArgs e)
        {
            mouseStatus = "pen";
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            mouseStatus = "line";
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            mouseStatus = "eraser";
        }

        private void spcPrincipal_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isClicking = true;
            firstPoint = new Point(e.X, e.Y);
        }

        private void spcPrincipal_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isClicking = false;
            if (mouseStatus == "line")
            {
                Graphics g = spcPrincipal.Panel2.CreateGraphics();

                g.DrawLine(new Pen(current_color, 5), firstPoint, lastPoint);
            }
        }

        private void spcPrincipal_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicking)
            {
                lastPoint = new Point(e.X, e.Y);
                Graphics g = spcPrincipal.Panel2.CreateGraphics();
                switch (mouseStatus)
                {
                    case "pen":
                        g.FillEllipse(new SolidBrush(current_color), e.X, e.Y, 4, 4);
                        break;
                    case "eraser":
                        g.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, 10, 10);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
