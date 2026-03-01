namespace Sobreclick
{
    partial class sc_exe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sc_exe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAcpt = new System.Windows.Forms.Button();
            this.tbDirExe = new System.Windows.Forms.TextBox();
            this.btnExmnr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.cbArgs = new System.Windows.Forms.CheckBox();
            this.tbArgsExe = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCanc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnAcpt
            // 
            resources.ApplyResources(this.btnAcpt, "btnAcpt");
            this.btnAcpt.Name = "btnAcpt";
            this.btnAcpt.UseVisualStyleBackColor = true;
            this.btnAcpt.Click += new System.EventHandler(this.btnAcpt_Click);
            // 
            // tbDirExe
            // 
            resources.ApplyResources(this.tbDirExe, "tbDirExe");
            this.tbDirExe.Name = "tbDirExe";
            this.tbDirExe.TextChanged += new System.EventHandler(this.tbDirExe_TextChanged);
            // 
            // btnExmnr
            // 
            resources.ApplyResources(this.btnExmnr, "btnExmnr");
            this.btnExmnr.Name = "btnExmnr";
            this.btnExmnr.UseVisualStyleBackColor = true;
            this.btnExmnr.Click += new System.EventHandler(this.btnExmnr_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnProbar
            // 
            resources.ApplyResources(this.btnProbar, "btnProbar");
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // cbArgs
            // 
            resources.ApplyResources(this.cbArgs, "cbArgs");
            this.cbArgs.Name = "cbArgs";
            this.cbArgs.UseVisualStyleBackColor = true;
            this.cbArgs.CheckedChanged += new System.EventHandler(this.cbArgs_CheckedChanged);
            // 
            // tbArgsExe
            // 
            resources.ApplyResources(this.tbArgsExe, "tbArgsExe");
            this.tbArgsExe.Name = "tbArgsExe";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnCanc
            // 
            resources.ApplyResources(this.btnCanc, "btnCanc");
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // sc_exe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbArgsExe);
            this.Controls.Add(this.cbArgs);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExmnr);
            this.Controls.Add(this.tbDirExe);
            this.Controls.Add(this.btnAcpt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sc_exe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAcpt;
        private System.Windows.Forms.TextBox tbDirExe;
        private System.Windows.Forms.Button btnExmnr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.CheckBox cbArgs;
        private System.Windows.Forms.TextBox tbArgsExe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCanc;
    }
}