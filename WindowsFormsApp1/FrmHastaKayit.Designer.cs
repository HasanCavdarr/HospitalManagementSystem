namespace WindowsFormsApp1
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdKayıt = new System.Windows.Forms.TextBox();
            this.TxtSoyadKayıt = new System.Windows.Forms.TextBox();
            this.TxtEpostaKayıt = new System.Windows.Forms.TextBox();
            this.TxtSifreKayıt = new System.Windows.Forms.TextBox();
            this.BtnKayıtOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Posta: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(96, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre: ";
            // 
            // TxtAdKayıt
            // 
            this.TxtAdKayıt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAdKayıt.Location = new System.Drawing.Point(178, 55);
            this.TxtAdKayıt.Name = "TxtAdKayıt";
            this.TxtAdKayıt.Size = new System.Drawing.Size(136, 31);
            this.TxtAdKayıt.TabIndex = 1;
            // 
            // TxtSoyadKayıt
            // 
            this.TxtSoyadKayıt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyadKayıt.Location = new System.Drawing.Point(178, 112);
            this.TxtSoyadKayıt.Name = "TxtSoyadKayıt";
            this.TxtSoyadKayıt.Size = new System.Drawing.Size(136, 31);
            this.TxtSoyadKayıt.TabIndex = 2;
            // 
            // TxtEpostaKayıt
            // 
            this.TxtEpostaKayıt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtEpostaKayıt.Location = new System.Drawing.Point(178, 156);
            this.TxtEpostaKayıt.Name = "TxtEpostaKayıt";
            this.TxtEpostaKayıt.Size = new System.Drawing.Size(136, 31);
            this.TxtEpostaKayıt.TabIndex = 3;
            // 
            // TxtSifreKayıt
            // 
            this.TxtSifreKayıt.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSifreKayıt.Location = new System.Drawing.Point(178, 207);
            this.TxtSifreKayıt.Name = "TxtSifreKayıt";
            this.TxtSifreKayıt.Size = new System.Drawing.Size(136, 31);
            this.TxtSifreKayıt.TabIndex = 4;
            // 
            // BtnKayıtOl
            // 
            this.BtnKayıtOl.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnKayıtOl.Location = new System.Drawing.Point(212, 244);
            this.BtnKayıtOl.Name = "BtnKayıtOl";
            this.BtnKayıtOl.Size = new System.Drawing.Size(102, 27);
            this.BtnKayıtOl.TabIndex = 8;
            this.BtnKayıtOl.Text = "Kayıt Ol";
            this.BtnKayıtOl.UseVisualStyleBackColor = false;
            this.BtnKayıtOl.Click += new System.EventHandler(this.BtnKayıtOl_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayıtOl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(489, 351);
            this.Controls.Add(this.BtnKayıtOl);
            this.Controls.Add(this.TxtSifreKayıt);
            this.Controls.Add(this.TxtEpostaKayıt);
            this.Controls.Add(this.TxtSoyadKayıt);
            this.Controls.Add(this.TxtAdKayıt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdKayıt;
        private System.Windows.Forms.TextBox TxtSoyadKayıt;
        private System.Windows.Forms.TextBox TxtEpostaKayıt;
        private System.Windows.Forms.TextBox TxtSifreKayıt;
        private System.Windows.Forms.Button BtnKayıtOl;
    }
}