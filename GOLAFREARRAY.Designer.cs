
namespace UF2
{
    partial class GOLAFREARRAY
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
            this.txMenjar = new System.Windows.Forms.TextBox();
            this.txProfessor = new System.Windows.Forms.TextBox();
            this.txAlumne = new System.Windows.Forms.TextBox();
            this.btGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txProva = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txMenjar
            // 
            this.txMenjar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMenjar.Location = new System.Drawing.Point(101, 22);
            this.txMenjar.Multiline = true;
            this.txMenjar.Name = "txMenjar";
            this.txMenjar.Size = new System.Drawing.Size(304, 65);
            this.txMenjar.TabIndex = 0;
            // 
            // txProfessor
            // 
            this.txProfessor.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txProfessor.Location = new System.Drawing.Point(100, 100);
            this.txProfessor.Multiline = true;
            this.txProfessor.Name = "txProfessor";
            this.txProfessor.Size = new System.Drawing.Size(304, 39);
            this.txProfessor.TabIndex = 1;
            // 
            // txAlumne
            // 
            this.txAlumne.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAlumne.Location = new System.Drawing.Point(100, 145);
            this.txAlumne.Multiline = true;
            this.txAlumne.Name = "txAlumne";
            this.txAlumne.Size = new System.Drawing.Size(304, 39);
            this.txAlumne.TabIndex = 2;
            // 
            // btGo
            // 
            this.btGo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGo.Location = new System.Drawing.Point(195, 198);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(80, 33);
            this.btGo.TabIndex = 3;
            this.btGo.Text = "START !";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menjar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Professor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alumne";
            // 
            // txProva
            // 
            this.txProva.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txProva.Location = new System.Drawing.Point(445, 22);
            this.txProva.Multiline = true;
            this.txProva.Name = "txProva";
            this.txProva.Size = new System.Drawing.Size(255, 162);
            this.txProva.TabIndex = 7;
            // 
            // GOLAFREARRAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 243);
            this.Controls.Add(this.txProva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.txAlumne);
            this.Controls.Add(this.txProfessor);
            this.Controls.Add(this.txMenjar);
            this.Name = "GOLAFREARRAY";
            this.Text = "GOLAFREARRAY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txMenjar;
        private System.Windows.Forms.TextBox txProfessor;
        private System.Windows.Forms.TextBox txAlumne;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txProva;
    }
}