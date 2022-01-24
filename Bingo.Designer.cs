
namespace UF2
{
    partial class Bingo
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
            this.txBox1 = new System.Windows.Forms.TextBox();
            this.txBox2 = new System.Windows.Forms.TextBox();
            this.btBola = new System.Windows.Forms.Button();
            this.btCartro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txBox11 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txBox1
            // 
            this.txBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBox1.Location = new System.Drawing.Point(83, 12);
            this.txBox1.Multiline = true;
            this.txBox1.Name = "txBox1";
            this.txBox1.Size = new System.Drawing.Size(267, 30);
            this.txBox1.TabIndex = 0;
            // 
            // txBox2
            // 
            this.txBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBox2.Location = new System.Drawing.Point(83, 90);
            this.txBox2.Name = "txBox2";
            this.txBox2.Size = new System.Drawing.Size(267, 27);
            this.txBox2.TabIndex = 1;
            // 
            // btBola
            // 
            this.btBola.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBola.Location = new System.Drawing.Point(272, 123);
            this.btBola.Name = "btBola";
            this.btBola.Size = new System.Drawing.Size(78, 49);
            this.btBola.TabIndex = 2;
            this.btBola.Text = "Caure Bola";
            this.btBola.UseVisualStyleBackColor = true;
            this.btBola.Click += new System.EventHandler(this.btBola_Click);
            // 
            // btCartro
            // 
            this.btCartro.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCartro.Location = new System.Drawing.Point(83, 123);
            this.btCartro.Name = "btCartro";
            this.btCartro.Size = new System.Drawing.Size(98, 52);
            this.btCartro.TabIndex = 3;
            this.btCartro.Text = "Generar Cartró";
            this.btCartro.UseVisualStyleBackColor = true;
            this.btCartro.Click += new System.EventHandler(this.btCartro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cartró J1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bola";
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(187, 139);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "RESET";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cartró J2";
            // 
            // txBox11
            // 
            this.txBox11.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBox11.Location = new System.Drawing.Point(83, 48);
            this.txBox11.Multiline = true;
            this.txBox11.Name = "txBox11";
            this.txBox11.Size = new System.Drawing.Size(267, 30);
            this.txBox11.TabIndex = 7;
            // 
            // Bingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txBox11);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCartro);
            this.Controls.Add(this.btBola);
            this.Controls.Add(this.txBox2);
            this.Controls.Add(this.txBox1);
            this.Name = "Bingo";
            this.Text = "Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBox1;
        private System.Windows.Forms.TextBox txBox2;
        private System.Windows.Forms.Button btBola;
        private System.Windows.Forms.Button btCartro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txBox11;
    }
}