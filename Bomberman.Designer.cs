
namespace UF2
{
    partial class Bomberman
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
            this.txPantalla = new System.Windows.Forms.TextBox();
            this.btAdalt = new System.Windows.Forms.Button();
            this.btAvall = new System.Windows.Forms.Button();
            this.btDreta = new System.Windows.Forms.Button();
            this.btEsquerre = new System.Windows.Forms.Button();
            this.btInici = new System.Windows.Forms.Button();
            this.btFantasma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txPantalla
            // 
            this.txPantalla.Enabled = false;
            this.txPantalla.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPantalla.Location = new System.Drawing.Point(144, 12);
            this.txPantalla.Multiline = true;
            this.txPantalla.Name = "txPantalla";
            this.txPantalla.Size = new System.Drawing.Size(213, 208);
            this.txPantalla.TabIndex = 0;
            this.txPantalla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPantalla_KeyDown);
            // 
            // btAdalt
            // 
            this.btAdalt.AutoSize = true;
            this.btAdalt.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdalt.Location = new System.Drawing.Point(212, 271);
            this.btAdalt.Name = "btAdalt";
            this.btAdalt.Size = new System.Drawing.Size(74, 50);
            this.btAdalt.TabIndex = 1;
            this.btAdalt.Text = "˄";
            this.btAdalt.UseVisualStyleBackColor = true;
            this.btAdalt.Click += new System.EventHandler(this.btAdalt_Click);
            // 
            // btAvall
            // 
            this.btAvall.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvall.Location = new System.Drawing.Point(212, 321);
            this.btAvall.Name = "btAvall";
            this.btAvall.Size = new System.Drawing.Size(74, 50);
            this.btAvall.TabIndex = 2;
            this.btAvall.Text = "˅";
            this.btAvall.UseVisualStyleBackColor = true;
            this.btAvall.Click += new System.EventHandler(this.btAvall_Click);
            // 
            // btDreta
            // 
            this.btDreta.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDreta.Location = new System.Drawing.Point(292, 298);
            this.btDreta.Name = "btDreta";
            this.btDreta.Size = new System.Drawing.Size(74, 50);
            this.btDreta.TabIndex = 3;
            this.btDreta.Text = "˃";
            this.btDreta.UseVisualStyleBackColor = true;
            this.btDreta.Click += new System.EventHandler(this.btDreta_Click);
            // 
            // btEsquerre
            // 
            this.btEsquerre.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEsquerre.Location = new System.Drawing.Point(132, 298);
            this.btEsquerre.Name = "btEsquerre";
            this.btEsquerre.Size = new System.Drawing.Size(74, 50);
            this.btEsquerre.TabIndex = 4;
            this.btEsquerre.Text = "˂";
            this.btEsquerre.UseVisualStyleBackColor = true;
            this.btEsquerre.Click += new System.EventHandler(this.btEsquerre_Click);
            // 
            // btInici
            // 
            this.btInici.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInici.Location = new System.Drawing.Point(132, 227);
            this.btInici.Name = "btInici";
            this.btInici.Size = new System.Drawing.Size(234, 38);
            this.btInici.TabIndex = 5;
            this.btInici.Text = "START";
            this.btInici.UseVisualStyleBackColor = true;
            this.btInici.Click += new System.EventHandler(this.btInici_Click);
            // 
            // btFantasma
            // 
            this.btFantasma.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFantasma.Location = new System.Drawing.Point(10, 294);
            this.btFantasma.Name = "btFantasma";
            this.btFantasma.Size = new System.Drawing.Size(116, 61);
            this.btFantasma.TabIndex = 7;
            this.btFantasma.Text = "ACTIVAR FANTASMA";
            this.btFantasma.UseVisualStyleBackColor = true;
            this.btFantasma.Click += new System.EventHandler(this.btFantasma_Click);
            // 
            // Bomberman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 374);
            this.Controls.Add(this.btFantasma);
            this.Controls.Add(this.btInici);
            this.Controls.Add(this.btEsquerre);
            this.Controls.Add(this.btDreta);
            this.Controls.Add(this.btAvall);
            this.Controls.Add(this.btAdalt);
            this.Controls.Add(this.txPantalla);
            this.Name = "Bomberman";
            this.Text = "Bomberman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txPantalla;
        private System.Windows.Forms.Button btAdalt;
        private System.Windows.Forms.Button btAvall;
        private System.Windows.Forms.Button btDreta;
        private System.Windows.Forms.Button btEsquerre;
        private System.Windows.Forms.Button btInici;
        private System.Windows.Forms.Button btFantasma;
    }
}