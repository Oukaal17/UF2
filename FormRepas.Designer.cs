
namespace UF2
{
    partial class FormRepas
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
            this.btBT1 = new System.Windows.Forms.Button();
            this.txBox1 = new System.Windows.Forms.TextBox();
            this.txBox2 = new System.Windows.Forms.TextBox();
            this.txBox3 = new System.Windows.Forms.TextBox();
            this.btBT2 = new System.Windows.Forms.Button();
            this.txBoxTorreMata = new System.Windows.Forms.TextBox();
            this.btReinaApareix = new System.Windows.Forms.Button();
            this.btCavall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBT1
            // 
            this.btBT1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBT1.Location = new System.Drawing.Point(393, 3);
            this.btBT1.Name = "btBT1";
            this.btBT1.Size = new System.Drawing.Size(126, 51);
            this.btBT1.TabIndex = 0;
            this.btBT1.Text = "Torre";
            this.btBT1.UseVisualStyleBackColor = true;
            this.btBT1.Click += new System.EventHandler(this.btBT1_Click);
            // 
            // txBox1
            // 
            this.txBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBox1.Location = new System.Drawing.Point(12, 12);
            this.txBox1.Multiline = true;
            this.txBox1.Name = "txBox1";
            this.txBox1.Size = new System.Drawing.Size(364, 73);
            this.txBox1.TabIndex = 1;
            this.txBox1.Visible = false;
            // 
            // txBox2
            // 
            this.txBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBox2.Location = new System.Drawing.Point(12, 103);
            this.txBox2.Multiline = true;
            this.txBox2.Name = "txBox2";
            this.txBox2.Size = new System.Drawing.Size(364, 73);
            this.txBox2.TabIndex = 2;
            this.txBox2.Visible = false;
            // 
            // txBox3
            // 
            this.txBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBox3.Location = new System.Drawing.Point(12, 3);
            this.txBox3.Multiline = true;
            this.txBox3.Name = "txBox3";
            this.txBox3.Size = new System.Drawing.Size(364, 250);
            this.txBox3.TabIndex = 3;
            // 
            // btBT2
            // 
            this.btBT2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBT2.Location = new System.Drawing.Point(1, 259);
            this.btBT2.Name = "btBT2";
            this.btBT2.Size = new System.Drawing.Size(135, 51);
            this.btBT2.TabIndex = 4;
            this.btBT2.Text = "BOTÓ 2";
            this.btBT2.UseVisualStyleBackColor = true;
            this.btBT2.Visible = false;
            // 
            // txBoxTorreMata
            // 
            this.txBoxTorreMata.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxTorreMata.Location = new System.Drawing.Point(382, 144);
            this.txBoxTorreMata.Name = "txBoxTorreMata";
            this.txBoxTorreMata.Size = new System.Drawing.Size(386, 32);
            this.txBoxTorreMata.TabIndex = 5;
            // 
            // btReinaApareix
            // 
            this.btReinaApareix.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReinaApareix.Location = new System.Drawing.Point(393, 60);
            this.btReinaApareix.Name = "btReinaApareix";
            this.btReinaApareix.Size = new System.Drawing.Size(126, 51);
            this.btReinaApareix.TabIndex = 6;
            this.btReinaApareix.Text = "Reina";
            this.btReinaApareix.UseVisualStyleBackColor = true;
            this.btReinaApareix.Click += new System.EventHandler(this.btReinaApareix_Click);
            // 
            // btCavall
            // 
            this.btCavall.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCavall.Location = new System.Drawing.Point(525, 34);
            this.btCavall.Name = "btCavall";
            this.btCavall.Size = new System.Drawing.Size(126, 51);
            this.btCavall.TabIndex = 7;
            this.btCavall.Text = "Cavall";
            this.btCavall.UseVisualStyleBackColor = true;
            this.btCavall.Click += new System.EventHandler(this.btCavall_Click);
            // 
            // FormRepas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCavall);
            this.Controls.Add(this.btReinaApareix);
            this.Controls.Add(this.txBoxTorreMata);
            this.Controls.Add(this.btBT2);
            this.Controls.Add(this.txBox3);
            this.Controls.Add(this.txBox2);
            this.Controls.Add(this.txBox1);
            this.Controls.Add(this.btBT1);
            this.Name = "FormRepas";
            this.Text = "FormRepas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBT1;
        private System.Windows.Forms.TextBox txBox1;
        private System.Windows.Forms.TextBox txBox2;
        private System.Windows.Forms.TextBox txBox3;
        private System.Windows.Forms.Button btBT2;
        private System.Windows.Forms.TextBox txBoxTorreMata;
        private System.Windows.Forms.Button btReinaApareix;
        private System.Windows.Forms.Button btCavall;
    }
}