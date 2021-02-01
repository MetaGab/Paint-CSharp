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
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivo_nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivo_abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivo_guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArchivo_guardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuArchivo_salir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.spcPrincipal = new System.Windows.Forms.SplitContainer();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.num_blue = new System.Windows.Forms.NumericUpDown();
            this.num_green = new System.Windows.Forms.NumericUpDown();
            this.num_red = new System.Windows.Forms.NumericUpDown();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.pnl_Color = new System.Windows.Forms.Panel();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_pen = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).BeginInit();
            this.spcPrincipal.Panel1.SuspendLayout();
            this.spcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_red)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuAcercaDe});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo_nuevo,
            this.menuArchivo_abrir,
            this.menuArchivo_guardar,
            this.menuArchivo_guardarComo,
            this.toolStripMenuItem1,
            this.menuArchivo_salir});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // menuArchivo_nuevo
            // 
            this.menuArchivo_nuevo.Image = global::Paint.Properties.Resources.add_1;
            this.menuArchivo_nuevo.Name = "menuArchivo_nuevo";
            this.menuArchivo_nuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuArchivo_nuevo.Size = new System.Drawing.Size(240, 22);
            this.menuArchivo_nuevo.Text = "Nuevo";
            // 
            // menuArchivo_abrir
            // 
            this.menuArchivo_abrir.Image = global::Paint.Properties.Resources.file_1;
            this.menuArchivo_abrir.Name = "menuArchivo_abrir";
            this.menuArchivo_abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuArchivo_abrir.Size = new System.Drawing.Size(240, 22);
            this.menuArchivo_abrir.Text = "Abrir";
            // 
            // menuArchivo_guardar
            // 
            this.menuArchivo_guardar.Image = global::Paint.Properties.Resources.save;
            this.menuArchivo_guardar.Name = "menuArchivo_guardar";
            this.menuArchivo_guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menuArchivo_guardar.Size = new System.Drawing.Size(240, 22);
            this.menuArchivo_guardar.Text = "Guardar";
            // 
            // menuArchivo_guardarComo
            // 
            this.menuArchivo_guardarComo.Name = "menuArchivo_guardarComo";
            this.menuArchivo_guardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.menuArchivo_guardarComo.Size = new System.Drawing.Size(240, 22);
            this.menuArchivo_guardarComo.Text = "Guardar Como";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // menuArchivo_salir
            // 
            this.menuArchivo_salir.Name = "menuArchivo_salir";
            this.menuArchivo_salir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuArchivo_salir.Size = new System.Drawing.Size(240, 22);
            this.menuArchivo_salir.Text = "Salir";
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(72, 20);
            this.menuAcercaDe.Text = "Acerca De";
            this.menuAcercaDe.Click += new System.EventHandler(this.menuAcercaDe_Click);
            // 
            // spcPrincipal
            // 
            this.spcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcPrincipal.IsSplitterFixed = true;
            this.spcPrincipal.Location = new System.Drawing.Point(0, 24);
            this.spcPrincipal.Name = "spcPrincipal";
            // 
            // spcPrincipal.Panel1
            // 
            this.spcPrincipal.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.spcPrincipal.Panel1.Controls.Add(this.btn_eraser);
            this.spcPrincipal.Panel1.Controls.Add(this.num_blue);
            this.spcPrincipal.Panel1.Controls.Add(this.num_green);
            this.spcPrincipal.Panel1.Controls.Add(this.num_red);
            this.spcPrincipal.Panel1.Controls.Add(this.lbl_blue);
            this.spcPrincipal.Panel1.Controls.Add(this.lbl_green);
            this.spcPrincipal.Panel1.Controls.Add(this.lbl_red);
            this.spcPrincipal.Panel1.Controls.Add(this.pnl_Color);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_line);
            this.spcPrincipal.Panel1.Controls.Add(this.btn_pen);
            this.spcPrincipal.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            // 
            // spcPrincipal.Panel2
            // 
            this.spcPrincipal.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spcPrincipal_Panel2_MouseDown);
            this.spcPrincipal.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.spcPrincipal_Panel2_MouseMove);
            this.spcPrincipal.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spcPrincipal_Panel2_MouseUp);
            this.spcPrincipal.Size = new System.Drawing.Size(784, 537);
            this.spcPrincipal.SplitterDistance = 140;
            this.spcPrincipal.TabIndex = 1;
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackgroundImage = global::Paint.Properties.Resources._022_eraser;
            this.btn_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eraser.Location = new System.Drawing.Point(13, 69);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(50, 50);
            this.btn_eraser.TabIndex = 9;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // num_blue
            // 
            this.num_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_blue.Location = new System.Drawing.Point(44, 333);
            this.num_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_blue.Name = "num_blue";
            this.num_blue.Size = new System.Drawing.Size(83, 22);
            this.num_blue.TabIndex = 8;
            this.num_blue.ValueChanged += new System.EventHandler(this.num_color_ValueChanged);
            // 
            // num_green
            // 
            this.num_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_green.Location = new System.Drawing.Point(44, 305);
            this.num_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_green.Name = "num_green";
            this.num_green.Size = new System.Drawing.Size(83, 22);
            this.num_green.TabIndex = 7;
            this.num_green.ValueChanged += new System.EventHandler(this.num_color_ValueChanged);
            // 
            // num_red
            // 
            this.num_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_red.Location = new System.Drawing.Point(44, 277);
            this.num_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_red.Name = "num_red";
            this.num_red.Size = new System.Drawing.Size(83, 22);
            this.num_red.TabIndex = 6;
            this.num_red.ValueChanged += new System.EventHandler(this.num_color_ValueChanged);
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue.Location = new System.Drawing.Point(16, 329);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(23, 24);
            this.lbl_blue.TabIndex = 5;
            this.lbl_blue.Text = "B";
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green.Location = new System.Drawing.Point(14, 301);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(25, 24);
            this.lbl_green.TabIndex = 4;
            this.lbl_green.Text = "G";
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red.Location = new System.Drawing.Point(15, 273);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(24, 24);
            this.lbl_red.TabIndex = 3;
            this.lbl_red.Text = "R";
            // 
            // pnl_Color
            // 
            this.pnl_Color.BackColor = System.Drawing.Color.Black;
            this.pnl_Color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Color.Location = new System.Drawing.Point(13, 160);
            this.pnl_Color.Name = "pnl_Color";
            this.pnl_Color.Size = new System.Drawing.Size(114, 100);
            this.pnl_Color.TabIndex = 2;
            // 
            // btn_line
            // 
            this.btn_line.BackgroundImage = global::Paint.Properties.Resources.substract;
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_line.Location = new System.Drawing.Point(77, 13);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(50, 50);
            this.btn_line.TabIndex = 1;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_pen
            // 
            this.btn_pen.BackgroundImage = global::Paint.Properties.Resources._027_pencil;
            this.btn_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pen.Location = new System.Drawing.Point(13, 13);
            this.btn_pen.Name = "btn_pen";
            this.btn_pen.Size = new System.Drawing.Size(50, 50);
            this.btn_pen.TabIndex = 0;
            this.btn_pen.UseVisualStyleBackColor = true;
            this.btn_pen.Click += new System.EventHandler(this.btn_pen_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.spcPrincipal);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint ITH";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.spcPrincipal.Panel1.ResumeLayout(false);
            this.spcPrincipal.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcPrincipal)).EndInit();
            this.spcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo_nuevo;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo_abrir;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo_guardar;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo_guardarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo_salir;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.SplitContainer spcPrincipal;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_pen;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Panel pnl_Color;
        private System.Windows.Forms.NumericUpDown num_red;
        private System.Windows.Forms.NumericUpDown num_green;
        private System.Windows.Forms.NumericUpDown num_blue;
        private System.Windows.Forms.Button btn_eraser;
    }
}

