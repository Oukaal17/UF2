
namespace UF2
{
    partial class Bingo21
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
            this.label3 = new System.Windows.Forms.Label();
            this.txBox11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCartro = new System.Windows.Forms.Button();
            this.btBola = new System.Windows.Forms.Button();
            this.txBox2 = new System.Windows.Forms.TextBox();
            this.txBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cartró J2";
            // 
            // txBox11
            // 
            this.txBox11.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBox11.Location = new System.Drawing.Point(94, 147);
            this.txBox11.Multiline = true;
            this.txBox11.Name = "txBox11";
            this.txBox11.Size = new System.Drawing.Size(240, 114);
            this.txBox11.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cartró J1";
            // 
            // btCartro
            // 
            this.btCartro.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCartro.Location = new System.Drawing.Point(94, 300);
            this.btCartro.Name = "btCartro";
            this.btCartro.Size = new System.Drawing.Size(98, 52);
            this.btCartro.TabIndex = 12;
            this.btCartro.Text = "Generar Cartró";
            this.btCartro.UseVisualStyleBackColor = true;
            this.btCartro.Click += new System.EventHandler(this.btCartro_Click_1);
            // 
            // btBola
            // 
            this.btBola.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBola.Location = new System.Drawing.Point(283, 300);
            this.btBola.Name = "btBola";
            this.btBola.Size = new System.Drawing.Size(78, 49);
            this.btBola.TabIndex = 11;
            this.btBola.Text = "Caure Bola";
            this.btBola.UseVisualStyleBackColor = true;
            this.btBola.Click += new System.EventHandler(this.btBola_Click);
            // 
            // txBox2
            // 
            this.txBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBox2.Location = new System.Drawing.Point(94, 267);
            this.txBox2.Name = "txBox2";
            this.txBox2.Size = new System.Drawing.Size(240, 27);
            this.txBox2.TabIndex = 10;
            // 
            // txBox1
            // 
            this.txBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBox1.Location = new System.Drawing.Point(94, 12);
            this.txBox1.Multiline = true;
            this.txBox1.Name = "txBox1";
            this.txBox1.Size = new System.Drawing.Size(240, 129);
            this.txBox1.TabIndex = 9;
            // 
            // Bingo21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txBox11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCartro);
            this.Controls.Add(this.btBola);
            this.Controls.Add(this.txBox2);
            this.Controls.Add(this.txBox1);
            this.Name = "Bingo21";
            this.Text = "Bingo21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txBox11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCartro;
        private System.Windows.Forms.Button btBola;
        private System.Windows.Forms.TextBox txBox2;
        private System.Windows.Forms.TextBox txBox1;
    }
}