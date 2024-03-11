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
            this.restaurarValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarAlTerminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducirSonidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarElEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarValoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siempreVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarTamañoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitarRepositorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.cbSinLimite = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDur = new System.Windows.Forms.ComboBox();
            this.cbDClick = new System.Windows.Forms.CheckBox();
            this.statusSC = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.statusSC.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreclickToolStripMenuItem,
            this.ventanaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // sobreclickToolStripMenuItem
            // 
            this.sobreclickToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarValoresToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.toolStripSeparator1,
            this.cerrarAlTerminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sobreclickToolStripMenuItem.Name = "sobreclickToolStripMenuItem";
            resources.ApplyResources(this.sobreclickToolStripMenuItem, "sobreclickToolStripMenuItem");
            // 
            // restaurarValoresToolStripMenuItem
            // 
            resources.ApplyResources(this.restaurarValoresToolStripMenuItem, "restaurarValoresToolStripMenuItem");
            this.restaurarValoresToolStripMenuItem.Name = "restaurarValoresToolStripMenuItem";
            this.restaurarValoresToolStripMenuItem.Click += new System.EventHandler(this.restaurarValoresToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            resources.ApplyResources(this.configuraciónToolStripMenuItem, "configuraciónToolStripMenuItem");
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // cerrarAlTerminarToolStripMenuItem
            // 
            this.cerrarAlTerminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1,
            this.reproducirSonidoToolStripMenuItem,
            this.apagarElEquipoToolStripMenuItem,
            this.restaurarValoresToolStripMenuItem1,
            this.masToolStripMenuItem});
            this.cerrarAlTerminarToolStripMenuItem.Name = "cerrarAlTerminarToolStripMenuItem";
            resources.ApplyResources(this.cerrarAlTerminarToolStripMenuItem, "cerrarAlTerminarToolStripMenuItem");
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.CheckOnClick = true;
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            resources.ApplyResources(this.salirToolStripMenuItem1, "salirToolStripMenuItem1");
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // reproducirSonidoToolStripMenuItem
            // 
            this.reproducirSonidoToolStripMenuItem.CheckOnClick = true;
            this.reproducirSonidoToolStripMenuItem.Name = "reproducirSonidoToolStripMenuItem";
            resources.ApplyResources(this.reproducirSonidoToolStripMenuItem, "reproducirSonidoToolStripMenuItem");
            this.reproducirSonidoToolStripMenuItem.Click += new System.EventHandler(this.reproducirSonidoToolStripMenuItem_Click);
            // 
            // apagarElEquipoToolStripMenuItem
            // 
            this.apagarElEquipoToolStripMenuItem.CheckOnClick = true;
            this.apagarElEquipoToolStripMenuItem.Name = "apagarElEquipoToolStripMenuItem";
            resources.ApplyResources(this.apagarElEquipoToolStripMenuItem, "apagarElEquipoToolStripMenuItem");
            this.apagarElEquipoToolStripMenuItem.Click += new System.EventHandler(this.apagarElEquipoToolStripMenuItem_Click);
            // 
            // restaurarValoresToolStripMenuItem1
            // 
            this.restaurarValoresToolStripMenuItem1.CheckOnClick = true;
            this.restaurarValoresToolStripMenuItem1.Name = "restaurarValoresToolStripMenuItem1";
            resources.ApplyResources(this.restaurarValoresToolStripMenuItem1, "restaurarValoresToolStripMenuItem1");
            this.restaurarValoresToolStripMenuItem1.Click += new System.EventHandler(this.restaurarValoresToolStripMenuItem1_Click);
            // 
            // masToolStripMenuItem
            // 
            this.masToolStripMenuItem.Name = "masToolStripMenuItem";
            resources.ApplyResources(this.masToolStripMenuItem, "masToolStripMenuItem");
            this.masToolStripMenuItem.Click += new System.EventHandler(this.masToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siempreVisibleToolStripMenuItem,
            this.restaurarTamañoToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            resources.ApplyResources(this.ventanaToolStripMenuItem, "ventanaToolStripMenuItem");
            // 
            // siempreVisibleToolStripMenuItem
            // 
            this.siempreVisibleToolStripMenuItem.Name = "siempreVisibleToolStripMenuItem";
            resources.ApplyResources(this.siempreVisibleToolStripMenuItem, "siempreVisibleToolStripMenuItem");
            this.siempreVisibleToolStripMenuItem.Click += new System.EventHandler(this.siempreVisibleToolStripMenuItem_Click_1);
            // 
            // restaurarTamañoToolStripMenuItem
            // 
            resources.ApplyResources(this.restaurarTamañoToolStripMenuItem, "restaurarTamañoToolStripMenuItem");
            this.restaurarTamañoToolStripMenuItem.Name = "restaurarTamañoToolStripMenuItem";
            this.restaurarTamañoToolStripMenuItem.Click += new System.EventHandler(this.restaurarTamañoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenciaToolStripMenuItem,
            this.visitarRepositorioToolStripMenuItem,
            this.toolStripSeparator2,
            this.ascercaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            // 
            // licenciaToolStripMenuItem
            // 
            this.licenciaToolStripMenuItem.Name = "licenciaToolStripMenuItem";
            resources.ApplyResources(this.licenciaToolStripMenuItem, "licenciaToolStripMenuItem");
            this.licenciaToolStripMenuItem.Click += new System.EventHandler(this.licenciaToolStripMenuItem_Click);
            // 
            // visitarRepositorioToolStripMenuItem
            // 
            this.visitarRepositorioToolStripMenuItem.Name = "visitarRepositorioToolStripMenuItem";
            resources.ApplyResources(this.visitarRepositorioToolStripMenuItem, "visitarRepositorioToolStripMenuItem");
            this.visitarRepositorioToolStripMenuItem.Click += new System.EventHandler(this.visitarRepositorioToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // ascercaToolStripMenuItem
            // 
            this.ascercaToolStripMenuItem.Name = "ascercaToolStripMenuItem";
            resources.ApplyResources(this.ascercaToolStripMenuItem, "ascercaToolStripMenuItem");
            this.ascercaToolStripMenuItem.Click += new System.EventHandler(this.ascercaToolStripMenuItem_Click);
            // 
            // buttonC
            // 
            resources.ApplyResources(this.buttonC, "buttonC");
            this.buttonC.Name = "buttonC";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonP
            // 
            resources.ApplyResources(this.buttonP, "buttonP");
            this.buttonP.Name = "buttonP";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonP_Click);
            // 
            // buttonD
            // 
            resources.ApplyResources(this.buttonD, "buttonD");
            this.buttonD.Name = "buttonD";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
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
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // buttonR
            // 
            resources.ApplyResources(this.buttonR, "buttonR");
            this.buttonR.Name = "buttonR";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // numericUpDown2
            // 
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
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
            this.numericUpDown2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbTipo
            // 
            resources.ApplyResources(this.cbTipo, "cbTipo");
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            resources.GetString("cbTipo.Items"),
            resources.GetString("cbTipo.Items1"),
            resources.GetString("cbTipo.Items2")});
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timerClick
            // 
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // cbSinLimite
            // 
            resources.ApplyResources(this.cbSinLimite, "cbSinLimite");
            this.cbSinLimite.Name = "cbSinLimite";
            this.cbSinLimite.UseVisualStyleBackColor = true;
            this.cbSinLimite.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // cbDur
            // 
            resources.ApplyResources(this.cbDur, "cbDur");
            this.cbDur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDur.FormattingEnabled = true;
            this.cbDur.Items.AddRange(new object[] {
            resources.GetString("cbDur.Items"),
            resources.GetString("cbDur.Items1"),
            resources.GetString("cbDur.Items2"),
            resources.GetString("cbDur.Items3")});
            this.cbDur.Name = "cbDur";
            this.cbDur.Tag = "";
            this.cbDur.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbDClick
            // 
            resources.ApplyResources(this.cbDClick, "cbDClick");
            this.cbDClick.Name = "cbDClick";
            this.cbDClick.UseVisualStyleBackColor = true;
            this.cbDClick.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // statusSC
            // 
            this.statusSC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusText});
            resources.ApplyResources(this.statusSC, "statusSC");
            this.statusSC.Name = "statusSC";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            resources.ApplyResources(this.statusText, "statusText");
            // 
            // timerStatus
            // 
            this.timerStatus.Interval = 5000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // sobreclick
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusSC);
            this.Controls.Add(this.cbDClick);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.cbDur);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbSinLimite);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonR);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sobreclick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sobreclick_FormClosing);
            this.Load += new System.EventHandler(this.sobreclick_Load);
            this.SizeChanged += new System.EventHandler(this.sobreclick_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.statusSC.ResumeLayout(false);
            this.statusSC.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ToolStripMenuItem ascercaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenciaToolStripMenuItem;
        private System.Windows.Forms.Timer timerClick;
        private System.Windows.Forms.CheckBox cbSinLimite;
        private System.Windows.Forms.ToolStripMenuItem restaurarValoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem visitarRepositorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAlTerminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbDur;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siempreVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarTamañoToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbDClick;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reproducirSonidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarElEquipoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusSC;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripMenuItem restaurarValoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem masToolStripMenuItem;
    }
}

