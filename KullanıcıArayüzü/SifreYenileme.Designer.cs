namespace KullanıcıArayüzü
{
    partial class SifreYenileme
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
            btn_giriş = new Button();
            lbl_anahtar = new Label();
            lbl_kadi = new Label();
            txt_anahtar = new TextBox();
            txt_kadi = new TextBox();
            btn_sifredegis = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_giriş
            // 
            btn_giriş.Location = new Point(76, 290);
            btn_giriş.Name = "btn_giriş";
            btn_giriş.Size = new Size(252, 29);
            btn_giriş.TabIndex = 15;
            btn_giriş.Text = "Yenile";
            btn_giriş.UseVisualStyleBackColor = true;
            btn_giriş.Click += btn_giriş_Click;
            // 
            // lbl_anahtar
            // 
            lbl_anahtar.AutoSize = true;
            lbl_anahtar.Location = new Point(77, 237);
            lbl_anahtar.Name = "lbl_anahtar";
            lbl_anahtar.Size = new Size(114, 20);
            lbl_anahtar.TabIndex = 12;
            lbl_anahtar.Text = "Anahtar Kelime:";
            // 
            // lbl_kadi
            // 
            lbl_kadi.AutoSize = true;
            lbl_kadi.Location = new Point(77, 183);
            lbl_kadi.Name = "lbl_kadi";
            lbl_kadi.Size = new Size(95, 20);
            lbl_kadi.TabIndex = 11;
            lbl_kadi.Text = "Kullanıcı Adı:";
            // 
            // txt_anahtar
            // 
            txt_anahtar.Location = new Point(204, 234);
            txt_anahtar.Name = "txt_anahtar";
            txt_anahtar.Size = new Size(125, 27);
            txt_anahtar.TabIndex = 9;
            // 
            // txt_kadi
            // 
            txt_kadi.Location = new Point(204, 180);
            txt_kadi.Name = "txt_kadi";
            txt_kadi.Size = new Size(125, 27);
            txt_kadi.TabIndex = 8;
            // 
            // btn_sifredegis
            // 
            btn_sifredegis.Location = new Point(77, 325);
            btn_sifredegis.Name = "btn_sifredegis";
            btn_sifredegis.Size = new Size(251, 29);
            btn_sifredegis.TabIndex = 16;
            btn_sifredegis.Text = "Yenile";
            btn_sifredegis.UseVisualStyleBackColor = true;
            btn_sifredegis.Click += btn_sifredegis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(77, 101);
            label1.Name = "label1";
            label1.Size = new Size(252, 52);
            label1.TabIndex = 41;
            label1.Text = "KRAL OYUN";
            // 
            // SifreYenileme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(416, 450);
            Controls.Add(label1);
            Controls.Add(btn_sifredegis);
            Controls.Add(btn_giriş);
            Controls.Add(lbl_anahtar);
            Controls.Add(lbl_kadi);
            Controls.Add(txt_anahtar);
            Controls.Add(txt_kadi);
            Name = "SifreYenileme";
            Text = "SifreYenileme";
            Load += SifreYenileme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_giriş;
        private Label lbl_anahtar;
        private Label lbl_kadi;
        private TextBox txt_anahtar;
        private TextBox txt_kadi;
        private Button btn_sifredegis;
        private Label label1;
    }
}