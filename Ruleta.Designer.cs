
namespace UF2
{
    partial class Ruleta
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
            this.btNext = new System.Windows.Forms.Button();
            this.gbRuleta = new System.Windows.Forms.GroupBox();
            this.txFraseOculta = new System.Windows.Forms.TextBox();
            this.btGirarRuleta = new System.Windows.Forms.Button();
            this.txPunts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txLletra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txSolucionar = new System.Windows.Forms.TextBox();
            this.btSolucionar = new System.Windows.Forms.Button();
            this.txPuntuacio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btRestart = new System.Windows.Forms.Button();
            this.gbRuleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txFrase
            // 
            this.txFrase.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFrase.Location = new System.Drawing.Point(103, 49);
            this.txFrase.Multiline = true;
            this.txFrase.Name = "txFrase";
            this.txFrase.Size = new System.Drawing.Size(621, 66);
            this.txFrase.TabIndex = 0;
            // 
            // btNext
            // 
            this.btNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.Location = new System.Drawing.Point(318, 159);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(184, 61);
            this.btNext.TabIndex = 1;
            this.btNext.Text = "GIRAR RULETA";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // gbRuleta
            // 
            this.gbRuleta.Controls.Add(this.btRestart);
            this.gbRuleta.Controls.Add(this.label3);
            this.gbRuleta.Controls.Add(this.txPuntuacio);
            this.gbRuleta.Controls.Add(this.btSolucionar);
            this.gbRuleta.Controls.Add(this.txSolucionar);
            this.gbRuleta.Controls.Add(this.label2);
            this.gbRuleta.Controls.Add(this.txLletra);
            this.gbRuleta.Controls.Add(this.label1);
            this.gbRuleta.Controls.Add(this.txPunts);
            this.gbRuleta.Controls.Add(this.btGirarRuleta);
            this.gbRuleta.Controls.Add(this.txFraseOculta);
            this.gbRuleta.Location = new System.Drawing.Point(13, 12);
            this.gbRuleta.Name = "gbRuleta";
            this.gbRuleta.Size = new System.Drawing.Size(816, 319);
            this.gbRuleta.TabIndex = 2;
            this.gbRuleta.TabStop = false;
            this.gbRuleta.Text = "La Ruleta de la Suerte";
            // 
            // txFraseOculta
            // 
            this.txFraseOculta.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txFraseOculta.Location = new System.Drawing.Point(37, 20);
            this.txFraseOculta.Multiline = true;
            this.txFraseOculta.Name = "txFraseOculta";
            this.txFraseOculta.Size = new System.Drawing.Size(723, 105);
            this.txFraseOculta.TabIndex = 0;
            // 
            // btGirarRuleta
            // 
            this.btGirarRuleta.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGirarRuleta.Location = new System.Drawing.Point(37, 123);
            this.btGirarRuleta.Name = "btGirarRuleta";
            this.btGirarRuleta.Size = new System.Drawing.Size(723, 32);
            this.btGirarRuleta.TabIndex = 1;
            this.btGirarRuleta.Text = "GIRAR LA RULETA";
            this.btGirarRuleta.UseVisualStyleBackColor = true;
            this.btGirarRuleta.Click += new System.EventHandler(this.btGirarRuleta_Click);
            // 
            // txPunts
            // 
            this.txPunts.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPunts.Location = new System.Drawing.Point(37, 197);
            this.txPunts.Multiline = true;
            this.txPunts.Name = "txPunts";
            this.txPunts.Size = new System.Drawing.Size(212, 112);
            this.txPunts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruleta punts :";
            // 
            // txLletra
            // 
            this.txLletra.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLletra.Location = new System.Drawing.Point(340, 180);
            this.txLletra.Multiline = true;
            this.txLletra.Name = "txLletra";
            this.txLletra.Size = new System.Drawing.Size(149, 28);
            this.txLletra.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lletra :";
            // 
            // txSolucionar
            // 
            this.txSolucionar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSolucionar.Location = new System.Drawing.Point(340, 214);
            this.txSolucionar.Multiline = true;
            this.txSolucionar.Name = "txSolucionar";
            this.txSolucionar.Size = new System.Drawing.Size(342, 35);
            this.txSolucionar.TabIndex = 6;
            // 
            // btSolucionar
            // 
            this.btSolucionar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSolucionar.Location = new System.Drawing.Point(689, 214);
            this.btSolucionar.Name = "btSolucionar";
            this.btSolucionar.Size = new System.Drawing.Size(121, 35);
            this.btSolucionar.TabIndex = 7;
            this.btSolucionar.Text = "Soluciona";
            this.btSolucionar.UseVisualStyleBackColor = true;
            // 
            // txPuntuacio
            // 
            this.txPuntuacio.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPuntuacio.Location = new System.Drawing.Point(394, 255);
            this.txPuntuacio.Multiline = true;
            this.txPuntuacio.Name = "txPuntuacio";
            this.txPuntuacio.Size = new System.Drawing.Size(252, 36);
            this.txPuntuacio.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "PUNTUACIÓ";
            // 
            // btRestart
            // 
            this.btRestart.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestart.ForeColor = System.Drawing.Color.Red;
            this.btRestart.Location = new System.Drawing.Point(717, 296);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(99, 23);
            this.btRestart.TabIndex = 10;
            this.btRestart.Text = "RESTART ALL";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // Ruleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 333);
            this.Controls.Add(this.gbRuleta);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.txFrase);
            this.Name = "Ruleta";
            this.Text = "Ruleta";
            this.gbRuleta.ResumeLayout(false);
            this.gbRuleta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txFrase;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.GroupBox gbRuleta;
        private System.Windows.Forms.Button btGirarRuleta;
        private System.Windows.Forms.TextBox txFraseOculta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPuntuacio;
        private System.Windows.Forms.Button btSolucionar;
        private System.Windows.Forms.TextBox txSolucionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txLletra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txPunts;
        private System.Windows.Forms.Button btRestart;
    }
}