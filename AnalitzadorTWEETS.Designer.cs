
namespace UF2
{
    partial class AnalitzadorTWEETS
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
            this.txBase = new System.Windows.Forms.TextBox();
            this.txLlindar = new System.Windows.Forms.TextBox();
            this.txAnalitzar = new System.Windows.Forms.TextBox();
            this.btAnalitzar = new System.Windows.Forms.Button();
            this.txPuntuació = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txBase
            // 
            this.txBase.Location = new System.Drawing.Point(50, 12);
            this.txBase.Name = "txBase";
            this.txBase.Size = new System.Drawing.Size(317, 20);
            this.txBase.TabIndex = 0;
            // 
            // txLlindar
            // 
            this.txLlindar.Location = new System.Drawing.Point(68, 48);
            this.txLlindar.Multiline = true;
            this.txLlindar.Name = "txLlindar";
            this.txLlindar.Size = new System.Drawing.Size(74, 39);
            this.txLlindar.TabIndex = 1;
            // 
            // txAnalitzar
            // 
            this.txAnalitzar.Location = new System.Drawing.Point(68, 93);
            this.txAnalitzar.Multiline = true;
            this.txAnalitzar.Name = "txAnalitzar";
            this.txAnalitzar.Size = new System.Drawing.Size(299, 67);
            this.txAnalitzar.TabIndex = 2;
            // 
            // btAnalitzar
            // 
            this.btAnalitzar.Location = new System.Drawing.Point(68, 166);
            this.btAnalitzar.Name = "btAnalitzar";
            this.btAnalitzar.Size = new System.Drawing.Size(154, 46);
            this.btAnalitzar.TabIndex = 3;
            this.btAnalitzar.Text = "Analitzar";
            this.btAnalitzar.UseVisualStyleBackColor = true;
            this.btAnalitzar.Click += new System.EventHandler(this.btAnalitzar_Click);
            // 
            // txPuntuació
            // 
            this.txPuntuació.Location = new System.Drawing.Point(373, 31);
            this.txPuntuació.Multiline = true;
            this.txPuntuació.Name = "txPuntuació";
            this.txPuntuació.Size = new System.Drawing.Size(177, 181);
            this.txPuntuació.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "BASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LLINDAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ANALITZA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PUNTUACIÓ";
            // 
            // AnalitzadorTWEETS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 229);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txPuntuació);
            this.Controls.Add(this.btAnalitzar);
            this.Controls.Add(this.txAnalitzar);
            this.Controls.Add(this.txLlindar);
            this.Controls.Add(this.txBase);
            this.Name = "AnalitzadorTWEETS";
            this.Text = "AnalitzadorTWEETS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBase;
        private System.Windows.Forms.TextBox txLlindar;
        private System.Windows.Forms.TextBox txAnalitzar;
        private System.Windows.Forms.Button btAnalitzar;
        private System.Windows.Forms.TextBox txPuntuació;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}