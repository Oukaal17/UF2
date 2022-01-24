
namespace UF2
{
    partial class Memory
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
            this.txTauler = new System.Windows.Forms.TextBox();
            this.btIniciar = new System.Windows.Forms.Button();
            this.txM1C1 = new System.Windows.Forms.TextBox();
            this.txM2C1 = new System.Windows.Forms.TextBox();
            this.txM2C2 = new System.Windows.Forms.TextBox();
            this.txM1C2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDestapar = new System.Windows.Forms.Button();
            this.txVisualitzacio = new System.Windows.Forms.TextBox();
            this.tx2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txTauler
            // 
            this.txTauler.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTauler.Location = new System.Drawing.Point(13, 13);
            this.txTauler.Multiline = true;
            this.txTauler.Name = "txTauler";
            this.txTauler.Size = new System.Drawing.Size(439, 238);
            this.txTauler.TabIndex = 0;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(458, 36);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(176, 32);
            this.btIniciar.TabIndex = 1;
            this.btIniciar.Text = "START";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // txM1C1
            // 
            this.txM1C1.Location = new System.Drawing.Point(512, 98);
            this.txM1C1.Name = "txM1C1";
            this.txM1C1.Size = new System.Drawing.Size(58, 20);
            this.txM1C1.TabIndex = 2;
            // 
            // txM2C1
            // 
            this.txM2C1.Location = new System.Drawing.Point(576, 98);
            this.txM2C1.Name = "txM2C1";
            this.txM2C1.Size = new System.Drawing.Size(58, 20);
            this.txM2C1.TabIndex = 3;
            // 
            // txM2C2
            // 
            this.txM2C2.Location = new System.Drawing.Point(576, 136);
            this.txM2C2.Name = "txM2C2";
            this.txM2C2.Size = new System.Drawing.Size(58, 20);
            this.txM2C2.TabIndex = 5;
            // 
            // txM1C2
            // 
            this.txM1C2.Location = new System.Drawing.Point(512, 136);
            this.txM1C2.Name = "txM1C2";
            this.txM1C2.Size = new System.Drawing.Size(58, 20);
            this.txM1C2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CARTA 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CARTA 2";
            // 
            // btDestapar
            // 
            this.btDestapar.Location = new System.Drawing.Point(458, 174);
            this.btDestapar.Name = "btDestapar";
            this.btDestapar.Size = new System.Drawing.Size(176, 31);
            this.btDestapar.TabIndex = 8;
            this.btDestapar.Text = "DESTAPAR";
            this.btDestapar.UseVisualStyleBackColor = true;
            this.btDestapar.Click += new System.EventHandler(this.btDestapar_Click);
            // 
            // txVisualitzacio
            // 
            this.txVisualitzacio.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txVisualitzacio.Location = new System.Drawing.Point(13, 267);
            this.txVisualitzacio.Multiline = true;
            this.txVisualitzacio.Name = "txVisualitzacio";
            this.txVisualitzacio.Size = new System.Drawing.Size(621, 81);
            this.txVisualitzacio.TabIndex = 9;
            // 
            // tx2
            // 
            this.tx2.Location = new System.Drawing.Point(674, 13);
            this.tx2.Multiline = true;
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(221, 139);
            this.tx2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "FILA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "COLUMNA";
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx2);
            this.Controls.Add(this.txVisualitzacio);
            this.Controls.Add(this.btDestapar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txM2C2);
            this.Controls.Add(this.txM1C2);
            this.Controls.Add(this.txM2C1);
            this.Controls.Add(this.txM1C1);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.txTauler);
            this.Name = "Memory";
            this.Text = "Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txTauler;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.TextBox txM1C1;
        private System.Windows.Forms.TextBox txM2C1;
        private System.Windows.Forms.TextBox txM2C2;
        private System.Windows.Forms.TextBox txM1C2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDestapar;
        private System.Windows.Forms.TextBox txVisualitzacio;
        private System.Windows.Forms.TextBox tx2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}