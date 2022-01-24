
namespace UF2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txBox1 = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txBox1
            // 
            this.txBox1.Location = new System.Drawing.Point(12, 12);
            this.txBox1.Multiline = true;
            this.txBox1.Name = "txBox1";
            this.txBox1.Size = new System.Drawing.Size(399, 174);
            this.txBox1.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(118, 202);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(172, 40);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "button1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 263);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBox1;
        private System.Windows.Forms.Button bt1;
    }
}

