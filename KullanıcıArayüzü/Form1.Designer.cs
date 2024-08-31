namespace KullanıcıArayüzü
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_kadi = new TextBox();
            txt_şifre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_giriş = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_kadi
            // 
            txt_kadi.Location = new Point(251, 188);
            txt_kadi.Name = "txt_kadi";
            txt_kadi.Size = new Size(125, 27);
            txt_kadi.TabIndex = 0;
            // 
            // txt_şifre
            // 
            txt_şifre.Location = new Point(251, 235);
            txt_şifre.Name = "txt_şifre";
            txt_şifre.Size = new Size(125, 27);
            txt_şifre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 191);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 242);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(315, 325);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 6;
            label4.Text = "Kayıt Ol";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(124, 325);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 5;
            label5.Text = "Şifremi Unutmuşsum";
            label5.Click += label5_Click;
            // 
            // btn_giriş
            // 
            btn_giriş.Location = new Point(124, 279);
            btn_giriş.Name = "btn_giriş";
            btn_giriş.Size = new Size(252, 29);
            btn_giriş.TabIndex = 7;
            btn_giriş.Text = "Giriş Yap";
            btn_giriş.UseVisualStyleBackColor = true;
            btn_giriş.Click += btn_giriş_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(124, 110);
            label1.Name = "label1";
            label1.Size = new Size(252, 52);
            label1.TabIndex = 40;
            label1.Text = "KRAL OYUN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(515, 450);
            Controls.Add(label1);
            Controls.Add(btn_giriş);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_şifre);
            Controls.Add(txt_kadi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_kadi;
        private TextBox txt_şifre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_giriş;
        private Label label1;
    }
}
