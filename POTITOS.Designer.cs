
namespace UF2
{
    partial class POTITOS
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
            this.txEntrada = new System.Windows.Forms.TextBox();
            this.txEntrada2 = new System.Windows.Forms.TextBox();
            this.btSTART = new System.Windows.Forms.Button();
            this.txEntrada3 = new System.Windows.Forms.TextBox();
            this.txEntrada4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txEntrada
            // 
            this.txEntrada.Location = new System.Drawing.Point(12, 12);
            this.txEntrada.Multiline = true;
            this.txEntrada.Name = "txEntrada";
            this.txEntrada.Size = new System.Drawing.Size(497, 106);
            this.txEntrada.TabIndex = 0;
            // 
            // txEntrada2
            // 
            this.txEntrada2.Location = new System.Drawing.Point(13, 124);
            this.txEntrada2.Multiline = true;
            this.txEntrada2.Name = "txEntrada2";
            this.txEntrada2.Size = new System.Drawing.Size(497, 48);
            this.txEntrada2.TabIndex = 1;
            this.txEntrada2.Visible = false;
            // 
            // btSTART
            // 
            this.btSTART.Location = new System.Drawing.Point(212, 288);
            this.btSTART.Name = "btSTART";
            this.btSTART.Size = new System.Drawing.Size(75, 48);
            this.btSTART.TabIndex = 2;
            this.btSTART.Text = "COMENÇA !";
            this.btSTART.UseVisualStyleBackColor = true;
            this.btSTART.Click += new System.EventHandler(this.btSTART_Click);
            // 
            // txEntrada3
            // 
            this.txEntrada3.Location = new System.Drawing.Point(12, 178);
            this.txEntrada3.Multiline = true;
            this.txEntrada3.Name = "txEntrada3";
            this.txEntrada3.Size = new System.Drawing.Size(497, 48);
            this.txEntrada3.TabIndex = 3;
            // 
            // txEntrada4
            // 
            this.txEntrada4.Location = new System.Drawing.Point(13, 232);
            this.txEntrada4.Multiline = true;
            this.txEntrada4.Name = "txEntrada4";
            this.txEntrada4.Size = new System.Drawing.Size(497, 48);
            this.txEntrada4.TabIndex = 4;
            this.txEntrada4.Visible = false;
            // 
            // POTITOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 348);
            this.Controls.Add(this.txEntrada4);
            this.Controls.Add(this.txEntrada3);
            this.Controls.Add(this.btSTART);
            this.Controls.Add(this.txEntrada2);
            this.Controls.Add(this.txEntrada);
            this.Name = "POTITOS";
            this.Text = "POTITOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txEntrada;
        private System.Windows.Forms.TextBox txEntrada2;
        private System.Windows.Forms.Button btSTART;
        private System.Windows.Forms.TextBox txEntrada3;
        private System.Windows.Forms.TextBox txEntrada4;
    }
}