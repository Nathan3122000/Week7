
namespace Week7
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.textBoxHurufAwal = new System.Windows.Forms.TextBox();
            this.textBoxHurufAkhir = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kalimat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Huruf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menjadi:";
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Location = new System.Drawing.Point(146, 13);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(309, 22);
            this.textBoxKalimat.TabIndex = 3;
            this.textBoxKalimat.TextChanged += new System.EventHandler(this.textBoxKalimat_TextChanged);
            // 
            // textBoxHurufAwal
            // 
            this.textBoxHurufAwal.Location = new System.Drawing.Point(135, 43);
            this.textBoxHurufAwal.Name = "textBoxHurufAwal";
            this.textBoxHurufAwal.Size = new System.Drawing.Size(100, 22);
            this.textBoxHurufAwal.TabIndex = 4;
            // 
            // textBoxHurufAkhir
            // 
            this.textBoxHurufAkhir.Location = new System.Drawing.Point(309, 42);
            this.textBoxHurufAkhir.Name = "textBoxHurufAkhir";
            this.textBoxHurufAkhir.Size = new System.Drawing.Size(100, 22);
            this.textBoxHurufAkhir.TabIndex = 5;
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(261, 89);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(194, 23);
            this.buttonKonversi.TabIndex = 6;
            this.buttonKonversi.Text = "Konversi";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(244, 134);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(0, 17);
            this.labelHasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxHurufAkhir);
            this.Controls.Add(this.textBoxHurufAwal);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKalimat;
        private System.Windows.Forms.TextBox textBoxHurufAwal;
        private System.Windows.Forms.TextBox textBoxHurufAkhir;
        private System.Windows.Forms.Button buttonKonversi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHasil;
    }
}

