namespace WindowsFormsApp1
{
    partial class FrmHastaSifreUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaSifreUnuttum));
            this.BtnSifreDegistir = new System.Windows.Forms.Button();
            this.TxtSifreDegistir = new System.Windows.Forms.TextBox();
            this.TxtEpostaKayıt = new System.Windows.Forms.TextBox();
            this.TxtSoyadKayıt = new System.Windows.Forms.TextBox();
            this.TxtAdKayıt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSifreDegistir
            // 
            this.BtnSifreDegistir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnSifreDegistir.Location = new System.Drawing.Point(166, 283);
            this.BtnSifreDegistir.Name = "BtnSifreDegistir";
            this.BtnSifreDegistir.Size = new System.Drawing.Size(102, 27);
            this.BtnSifreDegistir.TabIndex = 17;
            this.BtnSifreDegistir.Text = "Şifremi Değiştir";
            this.BtnSifreDegistir.UseVisualStyleBackColor = false;
            this.BtnSifreDegistir.Click += new System.EventHandler(this.BtnSifreDegistir_Click);
            // 
            // TxtSifreDegistir
            // 
            this.TxtSifreDegistir.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifreDegistir.Location = new System.Drawing.Point(132, 246);
            this.TxtSifreDegistir.Name = "TxtSifreDegistir";
            this.TxtSifreDegistir.Size = new System.Drawing.Size(136, 31);
            this.TxtSifreDegistir.TabIndex = 4;
            // 
            // TxtEpostaKayıt
            // 
            this.TxtEpostaKayıt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEpostaKayıt.Location = new System.Drawing.Point(132, 196);
            this.TxtEpostaKayıt.Name = "TxtEpostaKayıt";
            this.TxtEpostaKayıt.Size = new System.Drawing.Size(136, 31);
            this.TxtEpostaKayıt.TabIndex = 3;
            // 
            // TxtSoyadKayıt
            // 
            this.TxtSoyadKayıt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyadKayıt.Location = new System.Drawing.Point(132, 151);
            this.TxtSoyadKayıt.Name = "TxtSoyadKayıt";
            this.TxtSoyadKayıt.Size = new System.Drawing.Size(136, 31);
            this.TxtSoyadKayıt.TabIndex = 2;
            // 
            // TxtAdKayıt
            // 
            this.TxtAdKayıt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdKayıt.Location = new System.Drawing.Point(132, 94);
            this.TxtAdKayıt.Name = "TxtAdKayıt";
            this.TxtAdKayıt.Size = new System.Drawing.Size(136, 31);
            this.TxtAdKayıt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yeni Şifre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(34, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-Posta: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Soyad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(480, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Şifrenizi Değiştirmek İçin Aşağıdaki Bilgileri Eksiksiz Doldurun";
            // 
            // FrmHastaSifreUnuttum
            // 
            this.AcceptButton = this.BtnSifreDegistir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(523, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSifreDegistir);
            this.Controls.Add(this.TxtSifreDegistir);
            this.Controls.Add(this.TxtEpostaKayıt);
            this.Controls.Add(this.TxtSoyadKayıt);
            this.Controls.Add(this.TxtAdKayıt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHastaSifreUnuttum";
            this.Text = "Şifre Değiştir";
            this.Load += new System.EventHandler(this.FrmHastaSifreUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSifreDegistir;
        private System.Windows.Forms.TextBox TxtSifreDegistir;
        private System.Windows.Forms.TextBox TxtEpostaKayıt;
        private System.Windows.Forms.TextBox TxtSoyadKayıt;
        private System.Windows.Forms.TextBox TxtAdKayıt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}