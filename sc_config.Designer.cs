namespace Sobreclick
{
    partial class sc_config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sc_config));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbIni = new System.Windows.Forms.TextBox();
            this.tbPR = new System.Windows.Forms.TextBox();
            this.pbDen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSonidosSistema = new System.Windows.Forms.CheckBox();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnExmnr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbIni
            // 
            this.tbIni.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tbIni, "tbIni");
            this.tbIni.Name = "tbIni";
            this.tbIni.ReadOnly = true;
            this.tbIni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // tbPR
            // 
            resources.ApplyResources(this.tbPR, "tbPR");
            this.tbPR.BackColor = System.Drawing.Color.White;
            this.tbPR.Name = "tbPR";
            this.tbPR.ReadOnly = true;
            this.tbPR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // pbDen
            // 
            resources.ApplyResources(this.pbDen, "pbDen");
            this.pbDen.BackColor = System.Drawing.Color.White;
            this.pbDen.Name = "pbDen";
            this.pbDen.ReadOnly = true;
            this.pbDen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnRestaurar
            // 
            resources.ApplyResources(this.btnRestaurar, "btnRestaurar");
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbIni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pbDen);
            this.groupBox1.Controls.Add(this.tbPR);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSonidosSistema);
            this.groupBox2.Controls.Add(this.btnReproducir);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.btnExmnr);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbSonidosSistema
            // 
            resources.ApplyResources(this.cbSonidosSistema, "cbSonidosSistema");
            this.cbSonidosSistema.Name = "cbSonidosSistema";
            this.cbSonidosSistema.UseVisualStyleBackColor = true;
            this.cbSonidosSistema.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnReproducir
            // 
            resources.ApplyResources(this.btnReproducir, "btnReproducir");
            this.btnReproducir.Name = "btnReproducir";
            this.btnReproducir.UseVisualStyleBackColor = true;
            this.btnReproducir.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // btnExmnr
            // 
            resources.ApplyResources(this.btnExmnr, "btnExmnr");
            this.btnExmnr.Name = "btnExmnr";
            this.btnExmnr.UseVisualStyleBackColor = true;
            this.btnExmnr.Click += new System.EventHandler(this.button3_Click);
            // 
            // sc_config
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sc_config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sc_config_FormClosing);
            this.Load += new System.EventHandler(this.sc_config_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbIni;
        private System.Windows.Forms.TextBox tbPR;
        private System.Windows.Forms.TextBox pbDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSonidosSistema;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnExmnr;
    }
}