
namespace Spor_Salonu_Otomasyonu
{
    partial class Uye_Ara
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.maskedTc = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridListele = new System.Windows.Forms.DataGridView();
            this.btn_Ara = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_AnaSayfa = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Listele = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Kapat = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListele)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTc
            // 
            this.maskedTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maskedTc.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTc.Location = new System.Drawing.Point(35, 158);
            this.maskedTc.Mask = "00000000000";
            this.maskedTc.Name = "maskedTc";
            this.maskedTc.Size = new System.Drawing.Size(212, 32);
            this.maskedTc.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(31, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(342, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Üye Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fitness Center";
            // 
            // DataGridListele
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridListele.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridListele.Location = new System.Drawing.Point(12, 290);
            this.DataGridListele.Name = "DataGridListele";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridListele.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridListele.Size = new System.Drawing.Size(776, 148);
            this.DataGridListele.TabIndex = 43;
            // 
            // btn_Ara
            // 
            this.btn_Ara.BorderRadius = 7;
            this.btn_Ara.BorderThickness = 3;
            this.btn_Ara.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ara.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ara.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ara.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Ara.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Ara.ForeColor = System.Drawing.Color.White;
            this.btn_Ara.Location = new System.Drawing.Point(128, 227);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(141, 57);
            this.btn_Ara.TabIndex = 44;
            this.btn_Ara.Text = " Üye Ara";
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // Btn_AnaSayfa
            // 
            this.Btn_AnaSayfa.BorderRadius = 7;
            this.Btn_AnaSayfa.BorderThickness = 3;
            this.Btn_AnaSayfa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AnaSayfa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AnaSayfa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_AnaSayfa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_AnaSayfa.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_AnaSayfa.ForeColor = System.Drawing.Color.White;
            this.Btn_AnaSayfa.Location = new System.Drawing.Point(518, 227);
            this.Btn_AnaSayfa.Name = "Btn_AnaSayfa";
            this.Btn_AnaSayfa.Size = new System.Drawing.Size(141, 57);
            this.Btn_AnaSayfa.TabIndex = 45;
            this.Btn_AnaSayfa.Text = "Ana Sayfa";
            this.Btn_AnaSayfa.Click += new System.EventHandler(this.Btn_AnaSayfa_Click);
            // 
            // Btn_Listele
            // 
            this.Btn_Listele.BorderRadius = 7;
            this.Btn_Listele.BorderThickness = 3;
            this.Btn_Listele.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Listele.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Listele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Listele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Listele.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Listele.ForeColor = System.Drawing.Color.White;
            this.Btn_Listele.Location = new System.Drawing.Point(322, 227);
            this.Btn_Listele.Name = "Btn_Listele";
            this.Btn_Listele.Size = new System.Drawing.Size(141, 57);
            this.Btn_Listele.TabIndex = 46;
            this.Btn_Listele.Text = "Listele";
            this.Btn_Listele.Click += new System.EventHandler(this.Btn_Listele_Click);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.BorderRadius = 7;
            this.btn_Kapat.BorderThickness = 3;
            this.btn_Kapat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Kapat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Kapat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Kapat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Kapat.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_Kapat.ForeColor = System.Drawing.Color.White;
            this.btn_Kapat.Location = new System.Drawing.Point(726, 9);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(62, 47);
            this.btn_Kapat.TabIndex = 47;
            this.btn_Kapat.Text = "X";
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // Uye_Ara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.Btn_Listele);
            this.Controls.Add(this.Btn_AnaSayfa);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.DataGridListele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTc);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Uye_Ara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uye_Ara";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridListele;
        private Guna.UI2.WinForms.Guna2Button btn_Ara;
        private Guna.UI2.WinForms.Guna2Button Btn_AnaSayfa;
        private Guna.UI2.WinForms.Guna2Button Btn_Listele;
        private Guna.UI2.WinForms.Guna2Button btn_Kapat;
    }
}