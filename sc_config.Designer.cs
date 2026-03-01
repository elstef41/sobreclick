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
            this.gbTeclas = new System.Windows.Forms.GroupBox();
            this.gbSonido = new System.Windows.Forms.GroupBox();
            this.cbSonidosSistema = new System.Windows.Forms.CheckBox();
            this.btnReproducir = new System.Windows.Forms.Button();
            this.tbSoundDir = new System.Windows.Forms.TextBox();
            this.btnExmnr = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbComp = new System.Windows.Forms.GroupBox();
            this.cbSinLimiteIniciar = new System.Windows.Forms.CheckBox();
            this.btnValoresPredeterminados = new System.Windows.Forms.Button();
            this.gbTeclas.SuspendLayout();
            this.gbSonido.SuspendLayout();
            this.gbComp.SuspendLayout();
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
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // gbTeclas
            // 
            this.gbTeclas.Controls.Add(this.label1);
            this.gbTeclas.Controls.Add(this.tbIni);
            this.gbTeclas.Controls.Add(this.label3);
            this.gbTeclas.Controls.Add(this.label2);
            this.gbTeclas.Controls.Add(this.pbDen);
            this.gbTeclas.Controls.Add(this.tbPR);
            resources.ApplyResources(this.gbTeclas, "gbTeclas");
            this.gbTeclas.Name = "gbTeclas";
            this.gbTeclas.TabStop = false;
            // 
            // gbSonido
            // 
            this.gbSonido.Controls.Add(this.cbSonidosSistema);
            this.gbSonido.Controls.Add(this.btnReproducir);
            this.gbSonido.Controls.Add(this.tbSoundDir);
            this.gbSonido.Controls.Add(this.btnExmnr);
            resources.ApplyResources(this.gbSonido, "gbSonido");
            this.gbSonido.Name = "gbSonido";
            this.gbSonido.TabStop = false;
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
            this.btnReproducir.Click += new System.EventHandler(this.btnReproducir_Click);
            // 
            // tbSoundDir
            // 
            resources.ApplyResources(this.tbSoundDir, "tbSoundDir");
            this.tbSoundDir.Name = "tbSoundDir";
            // 
            // btnExmnr
            // 
            resources.ApplyResources(this.btnExmnr, "btnExmnr");
            this.btnExmnr.Name = "btnExmnr";
            this.btnExmnr.UseVisualStyleBackColor = true;
            this.btnExmnr.Click += new System.EventHandler(this.btnExmnr_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbComp
            // 
            this.gbComp.Controls.Add(this.cbSinLimiteIniciar);
            resources.ApplyResources(this.gbComp, "gbComp");
            this.gbComp.Name = "gbComp";
            this.gbComp.TabStop = false;
            // 
            // cbSinLimiteIniciar
            // 
            resources.ApplyResources(this.cbSinLimiteIniciar, "cbSinLimiteIniciar");
            this.cbSinLimiteIniciar.Name = "cbSinLimiteIniciar";
            this.cbSinLimiteIniciar.UseVisualStyleBackColor = true;
            this.cbSinLimiteIniciar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btnValoresPredeterminados
            // 
            resources.ApplyResources(this.btnValoresPredeterminados, "btnValoresPredeterminados");
            this.btnValoresPredeterminados.Name = "btnValoresPredeterminados";
            this.btnValoresPredeterminados.UseVisualStyleBackColor = true;
            this.btnValoresPredeterminados.Click += new System.EventHandler(this.btnValoresPredeterminados_Click);
            // 
            // sc_config
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnValoresPredeterminados);
            this.Controls.Add(this.gbComp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbSonido);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbTeclas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sc_config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sc_config_FormClosing);
            this.Load += new System.EventHandler(this.sc_config_Load);
            this.gbTeclas.ResumeLayout(false);
            this.gbTeclas.PerformLayout();
            this.gbSonido.ResumeLayout(false);
            this.gbSonido.PerformLayout();
            this.gbComp.ResumeLayout(false);
            this.gbComp.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbTeclas;
        private System.Windows.Forms.GroupBox gbSonido;
        private System.Windows.Forms.CheckBox cbSonidosSistema;
        private System.Windows.Forms.Button btnReproducir;
        private System.Windows.Forms.TextBox tbSoundDir;
        private System.Windows.Forms.Button btnExmnr;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbComp;
        private System.Windows.Forms.CheckBox cbSinLimiteIniciar;
        private System.Windows.Forms.Button btnValoresPredeterminados;
    }
}