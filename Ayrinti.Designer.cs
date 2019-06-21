namespace WindowsFormsApp3
{
    partial class Ayrinti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbKomite = new System.Windows.Forms.ComboBox();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rchEkstra = new System.Windows.Forms.RichTextBox();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.lstGorevler = new System.Windows.Forms.ListBox();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.txtFakulte = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.dtgVeri = new System.Windows.Forms.DataGridView();
            this.btnPuanEkle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.nmPuan = new System.Windows.Forms.NumericUpDown();
            this.lblToplamPuan = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPuanAciklama = new System.Windows.Forms.TextBox();
            this.cmbGorev = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPuan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbGorev);
            this.tabPage1.Controls.Add(this.cmbKomite);
            this.tabPage1.Controls.Add(this.btnUyeEkle);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.rchEkstra);
            this.tabPage1.Controls.Add(this.btnGorevEkle);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rchAdres);
            this.tabPage1.Controls.Add(this.lstGorevler);
            this.tabPage1.Controls.Add(this.txtSinif);
            this.tabPage1.Controls.Add(this.txtBolum);
            this.tabPage1.Controls.Add(this.txtFakulte);
            this.tabPage1.Controls.Add(this.txtMail);
            this.tabPage1.Controls.Add(this.txtTelefon);
            this.tabPage1.Controls.Add(this.txtSoyad);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(375, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Üye Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbKomite
            // 
            this.cmbKomite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbKomite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbKomite.FormattingEnabled = true;
            this.cmbKomite.Location = new System.Drawing.Point(76, 253);
            this.cmbKomite.Name = "cmbKomite";
            this.cmbKomite.Size = new System.Drawing.Size(273, 21);
            this.cmbKomite.TabIndex = 8;
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(232, 439);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(117, 23);
            this.btnUyeEkle.TabIndex = 13;
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(19, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ek Alan";
            // 
            // rchEkstra
            // 
            this.rchEkstra.Location = new System.Drawing.Point(76, 372);
            this.rchEkstra.Name = "rchEkstra";
            this.rchEkstra.Size = new System.Drawing.Size(273, 50);
            this.rchEkstra.TabIndex = 12;
            this.rchEkstra.Text = "";
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Location = new System.Drawing.Point(274, 287);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(75, 21);
            this.btnGorevEkle.TabIndex = 10;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(19, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Görevler";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(19, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Komite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(19, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sınıf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(19, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Bölüm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fakülte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad";
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(76, 128);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(273, 38);
            this.rchAdres.TabIndex = 4;
            this.rchAdres.Text = "";
            // 
            // lstGorevler
            // 
            this.lstGorevler.FormattingEnabled = true;
            this.lstGorevler.Location = new System.Drawing.Point(76, 310);
            this.lstGorevler.Name = "lstGorevler";
            this.lstGorevler.Size = new System.Drawing.Size(273, 56);
            this.lstGorevler.TabIndex = 11;
            this.lstGorevler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstGorevler_MouseDoubleClick);
            // 
            // txtSinif
            // 
            this.txtSinif.Location = new System.Drawing.Point(76, 224);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(154, 20);
            this.txtSinif.TabIndex = 7;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(76, 198);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(273, 20);
            this.txtBolum.TabIndex = 6;
            // 
            // txtFakulte
            // 
            this.txtFakulte.Location = new System.Drawing.Point(76, 172);
            this.txtFakulte.Name = "txtFakulte";
            this.txtFakulte.Size = new System.Drawing.Size(273, 20);
            this.txtFakulte.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(76, 102);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(192, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(76, 76);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(192, 20);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(76, 50);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(273, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(76, 24);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(273, 20);
            this.txtAd.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.dtgVeri);
            this.tabPage2.Controls.Add(this.btnPuanEkle);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.nmPuan);
            this.tabPage2.Controls.Add(this.lblToplamPuan);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtPuanAciklama);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(375, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Puan Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(6, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "Puanlar";
            // 
            // dtgVeri
            // 
            this.dtgVeri.AllowUserToAddRows = false;
            this.dtgVeri.AllowUserToDeleteRows = false;
            this.dtgVeri.AllowUserToOrderColumns = true;
            this.dtgVeri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVeri.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVeri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgVeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgVeri.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgVeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgVeri.Location = new System.Drawing.Point(3, 195);
            this.dtgVeri.Name = "dtgVeri";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgVeri.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgVeri.RowHeadersVisible = false;
            this.dtgVeri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgVeri.ShowEditingIcon = false;
            this.dtgVeri.Size = new System.Drawing.Size(369, 272);
            this.dtgVeri.TabIndex = 3;
            this.dtgVeri.VirtualMode = true;
            // 
            // btnPuanEkle
            // 
            this.btnPuanEkle.Location = new System.Drawing.Point(266, 153);
            this.btnPuanEkle.Name = "btnPuanEkle";
            this.btnPuanEkle.Size = new System.Drawing.Size(75, 23);
            this.btnPuanEkle.TabIndex = 2;
            this.btnPuanEkle.Text = "Puan Ekle";
            this.btnPuanEkle.UseVisualStyleBackColor = true;
            this.btnPuanEkle.Click += new System.EventHandler(this.btnPuanEkle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(20, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 15);
            this.label15.TabIndex = 16;
            this.label15.Text = "Eklenecek Puan";
            // 
            // nmPuan
            // 
            this.nmPuan.Location = new System.Drawing.Point(124, 126);
            this.nmPuan.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmPuan.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.nmPuan.Name = "nmPuan";
            this.nmPuan.Size = new System.Drawing.Size(120, 20);
            this.nmPuan.TabIndex = 1;
            // 
            // lblToplamPuan
            // 
            this.lblToplamPuan.AutoSize = true;
            this.lblToplamPuan.BackColor = System.Drawing.Color.Black;
            this.lblToplamPuan.Font = new System.Drawing.Font("Arial", 35F);
            this.lblToplamPuan.ForeColor = System.Drawing.Color.Yellow;
            this.lblToplamPuan.Location = new System.Drawing.Point(167, 6);
            this.lblToplamPuan.Name = "lblToplamPuan";
            this.lblToplamPuan.Size = new System.Drawing.Size(49, 53);
            this.lblToplamPuan.TabIndex = 14;
            this.lblToplamPuan.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(151, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Toplam Puan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(20, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "Açıklama";
            // 
            // txtPuanAciklama
            // 
            this.txtPuanAciklama.Location = new System.Drawing.Point(124, 97);
            this.txtPuanAciklama.Name = "txtPuanAciklama";
            this.txtPuanAciklama.Size = new System.Drawing.Size(217, 20);
            this.txtPuanAciklama.TabIndex = 0;
            // 
            // cmbGorev
            // 
            this.cmbGorev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGorev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGorev.FormattingEnabled = true;
            this.cmbGorev.Location = new System.Drawing.Point(76, 287);
            this.cmbGorev.Name = "cmbGorev";
            this.cmbGorev.Size = new System.Drawing.Size(192, 21);
            this.cmbGorev.TabIndex = 9;
            // 
            // Ayrinti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 496);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ayrinti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Başlık";
            this.Load += new System.EventHandler(this.Ayrinti_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchEkstra;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.ListBox lstGorevler;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.TextBox txtFakulte;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnPuanEkle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nmPuan;
        private System.Windows.Forms.Label lblToplamPuan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPuanAciklama;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView dtgVeri;
        private System.Windows.Forms.ComboBox cmbKomite;
        private System.Windows.Forms.ComboBox cmbGorev;
    }
}