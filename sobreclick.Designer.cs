namespace Sobreclick
{
    partial class sobreclick
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sobreclick));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sobreclickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.restaurarValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.visitarRepositorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAlTerminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreclickToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sobreclickToolStripMenuItem
            // 
            this.sobreclickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarValoresToolStripMenuItem,
            this.toolStripSeparator1,
            this.cerrarAlTerminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sobreclickToolStripMenuItem.Name = "sobreclickToolStripMenuItem";
            this.sobreclickToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.sobreclickToolStripMenuItem.Text = "&Sobreclick";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenciaToolStripMenuItem,
            this.visitarRepositorioToolStripMenuItem,
            this.ascercaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            this.licenciaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.licenciaToolStripMenuItem.Text = "&Licencia";
            this.licenciaToolStripMenuItem.Click += new System.EventHandler(this.licenciaToolStripMenuItem_Click);
            // 
            // ascercaToolStripMenuItem
            // 
            this.ascercaToolStripMenuItem.Name = "ascercaToolStripMenuItem";
            this.ascercaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ascercaToolStripMenuItem.Text = "&Acerca de Sobreclick";
            this.ascercaToolStripMenuItem.Click += new System.EventHandler(this.ascercaToolStripMenuItem_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(13, 176);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 52);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "&Iniciar (F6)";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonP
            // 
            this.buttonP.Enabled = false;
            this.buttonP.Location = new System.Drawing.Point(94, 176);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(75, 52);
            this.buttonP.TabIndex = 2;
            this.buttonP.Text = "&Pausar (F7)";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonD
            // 
            this.buttonD.Enabled = false;
            this.buttonD.Location = new System.Drawing.Point(176, 176);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(75, 52);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "&Detener (F8)";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(193, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // buttonR
            // 
            this.buttonR.Enabled = false;
            this.buttonR.Location = new System.Drawing.Point(94, 176);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(75, 52);
            this.buttonR.TabIndex = 5;
            this.buttonR.Text = "&Reanudar";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de clicks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Duración (ms)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(193, 69);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Izquierdo",
            "Central",
            "Derecho"});
            this.comboBox1.Location = new System.Drawing.Point(145, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timerClick
            // 
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Cantidad ilimitada";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // restaurarValoresToolStripMenuItem
            // 
            this.restaurarValoresToolStripMenuItem.Enabled = false;
            this.restaurarValoresToolStripMenuItem.Name = "restaurarValoresToolStripMenuItem";
            this.restaurarValoresToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.restaurarValoresToolStripMenuItem.Text = "&Restaurar valores";
            this.restaurarValoresToolStripMenuItem.Click += new System.EventHandler(this.restaurarValoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // visitarRepositorioToolStripMenuItem
            // 
            this.visitarRepositorioToolStripMenuItem.Name = "visitarRepositorioToolStripMenuItem";
            this.visitarRepositorioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.visitarRepositorioToolStripMenuItem.Text = "&Visitar repositorio";
            // 
            // cerrarAlTerminarToolStripMenuItem
            // 
            this.cerrarAlTerminarToolStripMenuItem.Name = "cerrarAlTerminarToolStripMenuItem";
            this.cerrarAlTerminarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cerrarAlTerminarToolStripMenuItem.Text = "S&alir al terminar";
            this.cerrarAlTerminarToolStripMenuItem.Click += new System.EventHandler(this.cerrarAlTerminarToolStripMenuItem_Click);
            // 
            // sobreclick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 248);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "sobreclick";
            this.Text = "Sobreclick";
            this.Load += new System.EventHandler(this.sobreclick_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreclickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem ascercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenciaToolStripMenuItem;
        private System.Windows.Forms.Timer timerClick;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem restaurarValoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem visitarRepositorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAlTerminarToolStripMenuItem;
    }
}

