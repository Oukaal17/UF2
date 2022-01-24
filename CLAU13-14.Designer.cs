
namespace UF2
{
    partial class CLAU13_14
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
            this.txClau = new System.Windows.Forms.TextBox();
            this.txComprovació = new System.Windows.Forms.TextBox();
            this.btSTART = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txClau
            // 
            this.txClau.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txClau.Location = new System.Drawing.Point(94, 32);
            this.txClau.Multiline = true;
            this.txClau.Name = "txClau";
            this.txClau.Size = new System.Drawing.Size(271, 41);
            this.txClau.TabIndex = 0;
            // 
            // txComprovació
            // 
            this.txComprovació.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txComprovació.Location = new System.Drawing.Point(94, 98);
            this.txComprovació.Multiline = true;
            this.txComprovació.Name = "txComprovació";
            this.txComprovació.Size = new System.Drawing.Size(271, 41);
            this.txComprovació.TabIndex = 1;
            // 
            // btSTART
            // 
            this.btSTART.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSTART.Location = new System.Drawing.Point(94, 162);
            this.btSTART.Name = "btSTART";
            this.btSTART.Size = new System.Drawing.Size(271, 32);
            this.btSTART.TabIndex = 2;
            this.btSTART.Text = "¿EXISTEIX?";
            this.btSTART.UseVisualStyleBackColor = true;
            this.btSTART.Click += new System.EventHandler(this.btSTART_Click);
            // 
            // CLAU13_14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 219);
            this.Controls.Add(this.btSTART);
            this.Controls.Add(this.txComprovació);
            this.Controls.Add(this.txClau);
            this.Name = "CLAU13_14";
            this.Text = "CLAU13_14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txClau;
        private System.Windows.Forms.TextBox txComprovació;
        private System.Windows.Forms.Button btSTART;
    }
}