namespace SleepTimer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.minlabel = new System.Windows.Forms.Label();
            this.optLabel = new System.Windows.Forms.Label();
            this.normLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelMin = new System.Windows.Forms.Label();
            this.labelOpt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNorm = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // minlabel
            // 
            resources.ApplyResources(this.minlabel, "minlabel");
            this.minlabel.Name = "minlabel";
            // 
            // optLabel
            // 
            resources.ApplyResources(this.optLabel, "optLabel");
            this.optLabel.Name = "optLabel";
            // 
            // normLabel
            // 
            resources.ApplyResources(this.normLabel, "normLabel");
            this.normLabel.Name = "normLabel";
            // 
            // maxLabel
            // 
            resources.ApplyResources(this.maxLabel, "maxLabel");
            this.maxLabel.Name = "maxLabel";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelMin
            // 
            resources.ApplyResources(this.labelMin, "labelMin");
            this.labelMin.Name = "labelMin";
            // 
            // labelOpt
            // 
            resources.ApplyResources(this.labelOpt, "labelOpt");
            this.labelOpt.Name = "labelOpt";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // labelNorm
            // 
            resources.ApplyResources(this.labelNorm, "labelNorm");
            this.labelNorm.Name = "labelNorm";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // labelMax
            // 
            resources.ApplyResources(this.labelMax, "labelMax");
            this.labelMax.Name = "labelMax";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBox1.DropDownHeight = 100;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 50;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Name = "comboBox2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNorm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelOpt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.normLabel);
            this.Controls.Add(this.optLabel);
            this.Controls.Add(this.minlabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minlabel;
        private System.Windows.Forms.Label optLabel;
        public System.Windows.Forms.Label normLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelOpt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNorm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

