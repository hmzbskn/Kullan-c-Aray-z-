namespace KullanıcıArayüzü
{
    partial class KayıtOl
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
            label3 = new Label();
            label2 = new Label();
            txt_şifre = new TextBox();
            txt_kadi = new TextBox();
            label4 = new Label();
            txt_anahtar = new TextBox();
            label5 = new Label();
            txt_bakiye = new TextBox();
            btn_giriş = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 238);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 8;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 133);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 7;
            label2.Text = "Kullanıcı Adı:";
            // 
            // txt_şifre
            // 
            txt_şifre.Location = new Point(212, 231);
            txt_şifre.Name = "txt_şifre";
            txt_şifre.Size = new Size(125, 27);
            txt_şifre.TabIndex = 6;
            // 
            // txt_kadi
            // 
            txt_kadi.Location = new Point(212, 130);
            txt_kadi.Name = "txt_kadi";
            txt_kadi.Size = new Size(125, 27);
            txt_kadi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 188);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 10;
            label4.Text = "Anahtar Kelime:";
            // 
            // txt_anahtar
            // 
            txt_anahtar.Location = new Point(212, 181);
            txt_anahtar.Name = "txt_anahtar";
            txt_anahtar.Size = new Size(125, 27);
            txt_anahtar.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 285);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 12;
            label5.Text = "Bakiye";
            // 
            // txt_bakiye
            // 
            txt_bakiye.Location = new Point(212, 278);
            txt_bakiye.Name = "txt_bakiye";
            txt_bakiye.Size = new Size(125, 27);
            txt_bakiye.TabIndex = 11;
            // 
            // btn_giriş
            // 
            btn_giriş.Location = new Point(85, 332);
            btn_giriş.Name = "btn_giriş";
            btn_giriş.Size = new Size(252, 29);
            btn_giriş.TabIndex = 13;
            btn_giriş.Text = "Kayıt Ol";
            btn_giriş.UseVisualStyleBackColor = true;
            btn_giriş.Click += btn_giriş_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(85, 54);
            label1.Name = "label1";
            label1.Size = new Size(252, 52);
            label1.TabIndex = 41;
            label1.Text = "KRAL OYUN";
            // 
            // KayıtOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(452, 450);
            Controls.Add(label1);
            Controls.Add(btn_giriş);
            Controls.Add(label5);
            Controls.Add(txt_bakiye);
            Controls.Add(label4);
            Controls.Add(txt_anahtar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_şifre);
            Controls.Add(txt_kadi);
            Name = "KayıtOl";
            Text = "KayıtOl";
            Load += KayıtOl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private TextBox txt_şifre;
        private TextBox txt_kadi;
        private Label label4;
        private TextBox txt_anahtar;
        private Label label5;
        private TextBox txt_bakiye;
        private Button btn_giriş;
        private Label label1;
    }
}