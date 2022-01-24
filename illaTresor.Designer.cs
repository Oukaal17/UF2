
namespace UF2
{
    partial class illaTresor
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
            this.txIlla = new System.Windows.Forms.TextBox();
            this.txMatriu = new System.Windows.Forms.TextBox();
            this.txM1 = new System.Windows.Forms.TextBox();
            this.txM2 = new System.Windows.Forms.TextBox();
            this.txSortida = new System.Windows.Forms.TextBox();
            this.btINICIAR = new System.Windows.Forms.Button();
            this.btCAVAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txIlla
            // 
            this.txIlla.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txIlla.Location = new System.Drawing.Point(12, 12);
            this.txIlla.Multiline = true;
            this.txIlla.Name = "txIlla";
            this.txIlla.Size = new System.Drawing.Size(276, 167);
            this.txIlla.TabIndex = 0;
            // 
            // txMatriu
            // 
            this.txMatriu.Location = new System.Drawing.Point(346, 13);
            this.txMatriu.Name = "txMatriu";
            this.txMatriu.Size = new System.Drawing.Size(142, 20);
            this.txMatriu.TabIndex = 1;
            // 
            // txM1
            // 
            this.txM1.Location = new System.Drawing.Point(57, 185);
            this.txM1.Name = "txM1";
            this.txM1.Size = new System.Drawing.Size(99, 20);
            this.txM1.TabIndex = 2;
            // 
            // txM2
            // 
            this.txM2.Location = new System.Drawing.Point(150, 185);
            this.txM2.Name = "txM2";
            this.txM2.Size = new System.Drawing.Size(99, 20);
            this.txM2.TabIndex = 3;
            // 
            // txSortida
            // 
            this.txSortida.Location = new System.Drawing.Point(12, 256);
            this.txSortida.Name = "txSortida";
            this.txSortida.Size = new System.Drawing.Size(276, 20);
            this.txSortida.TabIndex = 4;
            // 
            // btINICIAR
            // 
            this.btINICIAR.Location = new System.Drawing.Point(346, 40);
            this.btINICIAR.Name = "btINICIAR";
            this.btINICIAR.Size = new System.Drawing.Size(142, 25);
            this.btINICIAR.TabIndex = 5;
            this.btINICIAR.Text = "INICIAR";
            this.btINICIAR.UseVisualStyleBackColor = true;
            this.btINICIAR.Click += new System.EventHandler(this.btINICIAR_Click);
            // 
            // btCAVAR
            // 
            this.btCAVAR.Location = new System.Drawing.Point(57, 211);
            this.btCAVAR.Name = "btCAVAR";
            this.btCAVAR.Size = new System.Drawing.Size(192, 25);
            this.btCAVAR.TabIndex = 6;
            this.btCAVAR.Text = "CAVAR";
            this.btCAVAR.UseVisualStyleBackColor = true;
            this.btCAVAR.Click += new System.EventHandler(this.btCAVAR_Click);
            // 
            // illaTresor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 288);
            this.Controls.Add(this.btCAVAR);
            this.Controls.Add(this.btINICIAR);
            this.Controls.Add(this.txSortida);
            this.Controls.Add(this.txM2);
            this.Controls.Add(this.txM1);
            this.Controls.Add(this.txMatriu);
            this.Controls.Add(this.txIlla);
            this.Name = "illaTresor";
            this.Text = "illaTresor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txIlla;
        private System.Windows.Forms.TextBox txMatriu;
        private System.Windows.Forms.TextBox txM1;
        private System.Windows.Forms.TextBox txM2;
        private System.Windows.Forms.TextBox txSortida;
        private System.Windows.Forms.Button btINICIAR;
        private System.Windows.Forms.Button btCAVAR;
    }
}