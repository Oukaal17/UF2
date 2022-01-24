
namespace UF2
{
    partial class Reordenarfrase
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
            this.txFrase = new System.Windows.Forms.TextBox();
            this.txReordenat = new System.Windows.Forms.TextBox();
            this.btProcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txFrase
            // 
            this.txFrase.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFrase.Location = new System.Drawing.Point(9, 15);
            this.txFrase.Name = "txFrase";
            this.txFrase.Size = new System.Drawing.Size(312, 28);
            this.txFrase.TabIndex = 0;
            // 
            // txReordenat
            // 
            this.txReordenat.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txReordenat.Location = new System.Drawing.Point(9, 75);
            this.txReordenat.Name = "txReordenat";
            this.txReordenat.Size = new System.Drawing.Size(312, 28);
            this.txReordenat.TabIndex = 1;
            // 
            // btProcessar
            // 
            this.btProcessar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessar.Location = new System.Drawing.Point(91, 129);
            this.btProcessar.Name = "btProcessar";
            this.btProcessar.Size = new System.Drawing.Size(154, 36);
            this.btProcessar.TabIndex = 2;
            this.btProcessar.Text = "REORDENAR";
            this.btProcessar.UseVisualStyleBackColor = true;
            this.btProcessar.Click += new System.EventHandler(this.btProcessar_Click);
            // 
            // Reordenarfrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 184);
            this.Controls.Add(this.btProcessar);
            this.Controls.Add(this.txReordenat);
            this.Controls.Add(this.txFrase);
            this.Name = "Reordenarfrase";
            this.Text = "Reordenarfrase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txFrase;
        private System.Windows.Forms.TextBox txReordenat;
        private System.Windows.Forms.Button btProcessar;
    }
}