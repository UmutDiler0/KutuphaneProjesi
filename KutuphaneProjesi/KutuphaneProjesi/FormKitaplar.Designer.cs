namespace KutuphaneProjesi
{
    partial class FormKitaplar
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
            groupBox1 = new GroupBox();
            buttonKitapİadeEt = new Button();
            labelTL = new Label();
            labelGecikmeBedeli = new Label();
            buttonGecikmeBedeliHesapla = new Button();
            labelİadeGecikmeBedeli = new Label();
            groupBox2 = new GroupBox();
            buttonKitabıOduncVer = new Button();
            dateTimePickerOduncAlmaTarihi = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            labelTarih = new Label();
            labelOduncAlan = new Label();
            groupBox3 = new GroupBox();
            buttonKitapBilgiGuncelle = new Button();
            buttonKitapEkle = new Button();
            labelID = new Label();
            textBoxKitapTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyadi = new TextBox();
            textBoxYazarAdi = new TextBox();
            textBoxKitapAdi = new TextBox();
            labelKitapTurKodu = new Label();
            labelISBN = new Label();
            labelKitapAdi = new Label();
            labelYazarAdi = new Label();
            labelYazarSoyadi = new Label();
            label2 = new Label();
            labelKitapID = new Label();
            groupBox4 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonKitapİadeEt);
            groupBox1.Controls.Add(labelTL);
            groupBox1.Controls.Add(labelGecikmeBedeli);
            groupBox1.Controls.Add(buttonGecikmeBedeliHesapla);
            groupBox1.Controls.Add(labelİadeGecikmeBedeli);
            groupBox1.Location = new Point(478, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 474);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap İade";
            // 
            // buttonKitapİadeEt
            // 
            buttonKitapİadeEt.Location = new Point(62, 373);
            buttonKitapİadeEt.Name = "buttonKitapİadeEt";
            buttonKitapİadeEt.Size = new Size(96, 41);
            buttonKitapİadeEt.TabIndex = 10;
            buttonKitapİadeEt.Text = "Kitap İade Et";
            buttonKitapİadeEt.UseVisualStyleBackColor = true;
            buttonKitapİadeEt.Click += buttonKitapİadeEt_Click;
            // 
            // labelTL
            // 
            labelTL.AutoSize = true;
            labelTL.Location = new Point(198, 93);
            labelTL.Name = "labelTL";
            labelTL.Size = new Size(19, 15);
            labelTL.TabIndex = 9;
            labelTL.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Location = new Point(152, 93);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(13, 15);
            labelGecikmeBedeli.TabIndex = 8;
            labelGecikmeBedeli.Text = "0";
            // 
            // buttonGecikmeBedeliHesapla
            // 
            buttonGecikmeBedeliHesapla.Location = new Point(62, 295);
            buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            buttonGecikmeBedeliHesapla.Size = new Size(96, 41);
            buttonGecikmeBedeliHesapla.TabIndex = 7;
            buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            buttonGecikmeBedeliHesapla.Click += buttonGecikmeBedeliHesapla_Click;
            // 
            // labelİadeGecikmeBedeli
            // 
            labelİadeGecikmeBedeli.AutoSize = true;
            labelİadeGecikmeBedeli.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelİadeGecikmeBedeli.Location = new Point(6, 91);
            labelİadeGecikmeBedeli.Name = "labelİadeGecikmeBedeli";
            labelİadeGecikmeBedeli.Size = new Size(128, 17);
            labelİadeGecikmeBedeli.TabIndex = 6;
            labelİadeGecikmeBedeli.Text = "İade Gecikme Bedeli:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonKitabıOduncVer);
            groupBox2.Controls.Add(dateTimePickerOduncAlmaTarihi);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Controls.Add(labelTarih);
            groupBox2.Controls.Add(labelOduncAlan);
            groupBox2.Location = new Point(228, -3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 477);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Odunc Alma";
            // 
            // buttonKitabıOduncVer
            // 
            buttonKitabıOduncVer.Location = new Point(67, 233);
            buttonKitabıOduncVer.Name = "buttonKitabıOduncVer";
            buttonKitabıOduncVer.Size = new Size(96, 41);
            buttonKitabıOduncVer.TabIndex = 14;
            buttonKitabıOduncVer.Text = "Kitabı Odunc Ver";
            buttonKitabıOduncVer.UseVisualStyleBackColor = true;
            buttonKitabıOduncVer.Click += buttonKitabıOduncVer_Click;
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            dateTimePickerOduncAlmaTarihi.Location = new Point(117, 136);
            dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            dateTimePickerOduncAlmaTarihi.Size = new Size(116, 23);
            dateTimePickerOduncAlmaTarihi.TabIndex = 13;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(117, 88);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(121, 23);
            textBoxOduncAlan.TabIndex = 12;
            // 
            // labelTarih
            // 
            labelTarih.AutoSize = true;
            labelTarih.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTarih.Location = new Point(19, 137);
            labelTarih.Name = "labelTarih";
            labelTarih.Size = new Size(39, 17);
            labelTarih.TabIndex = 6;
            labelTarih.Text = "Tarih:";
            // 
            // labelOduncAlan
            // 
            labelOduncAlan.AutoSize = true;
            labelOduncAlan.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelOduncAlan.Location = new Point(19, 91);
            labelOduncAlan.Name = "labelOduncAlan";
            labelOduncAlan.Size = new Size(78, 17);
            labelOduncAlan.TabIndex = 5;
            labelOduncAlan.Text = "Odunc Alan:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonKitapBilgiGuncelle);
            groupBox3.Controls.Add(buttonKitapEkle);
            groupBox3.Controls.Add(labelID);
            groupBox3.Controls.Add(textBoxKitapTurKodu);
            groupBox3.Controls.Add(textBoxISBN);
            groupBox3.Controls.Add(textBoxYazarSoyadi);
            groupBox3.Controls.Add(textBoxYazarAdi);
            groupBox3.Controls.Add(textBoxKitapAdi);
            groupBox3.Controls.Add(labelKitapTurKodu);
            groupBox3.Controls.Add(labelISBN);
            groupBox3.Controls.Add(labelKitapAdi);
            groupBox3.Controls.Add(labelYazarAdi);
            groupBox3.Controls.Add(labelYazarSoyadi);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(labelKitapID);
            groupBox3.Location = new Point(1, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(221, 474);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap Kayit Ve Guncelleme";
            // 
            // buttonKitapBilgiGuncelle
            // 
            buttonKitapBilgiGuncelle.Location = new Point(94, 414);
            buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            buttonKitapBilgiGuncelle.Size = new Size(96, 41);
            buttonKitapBilgiGuncelle.TabIndex = 11;
            buttonKitapBilgiGuncelle.Text = "Kitap Bilgileri Guncelle";
            buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            buttonKitapBilgiGuncelle.Click += buttonKitapBilgiGuncelle_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(94, 346);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(96, 41);
            buttonKitapEkle.TabIndex = 0;
            buttonKitapEkle.Text = "Yeni Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(94, 36);
            labelID.Name = "labelID";
            labelID.Size = new Size(12, 15);
            labelID.TabIndex = 0;
            labelID.Text = "_";
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Location = new Point(94, 278);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(121, 23);
            textBoxKitapTurKodu.TabIndex = 10;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(94, 235);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(121, 23);
            textBoxISBN.TabIndex = 9;
            // 
            // textBoxYazarSoyadi
            // 
            textBoxYazarSoyadi.Location = new Point(94, 187);
            textBoxYazarSoyadi.Name = "textBoxYazarSoyadi";
            textBoxYazarSoyadi.Size = new Size(121, 23);
            textBoxYazarSoyadi.TabIndex = 8;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Location = new Point(94, 131);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(121, 23);
            textBoxYazarAdi.TabIndex = 7;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Location = new Point(94, 80);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(121, 23);
            textBoxKitapAdi.TabIndex = 0;
            // 
            // labelKitapTurKodu
            // 
            labelKitapTurKodu.AutoSize = true;
            labelKitapTurKodu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelKitapTurKodu.Location = new Point(0, 284);
            labelKitapTurKodu.Name = "labelKitapTurKodu";
            labelKitapTurKodu.Size = new Size(96, 17);
            labelKitapTurKodu.TabIndex = 6;
            labelKitapTurKodu.Text = "Kitap Tur Kodu";
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelISBN.Location = new Point(0, 241);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(38, 17);
            labelISBN.TabIndex = 5;
            labelISBN.Text = "ISBN:";
            // 
            // labelKitapAdi
            // 
            labelKitapAdi.AutoSize = true;
            labelKitapAdi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelKitapAdi.Location = new Point(0, 86);
            labelKitapAdi.Name = "labelKitapAdi";
            labelKitapAdi.Size = new Size(64, 17);
            labelKitapAdi.TabIndex = 4;
            labelKitapAdi.Text = "Kitap Adi:";
            // 
            // labelYazarAdi
            // 
            labelYazarAdi.AutoSize = true;
            labelYazarAdi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelYazarAdi.Location = new Point(0, 137);
            labelYazarAdi.Name = "labelYazarAdi";
            labelYazarAdi.Size = new Size(65, 17);
            labelYazarAdi.TabIndex = 3;
            labelYazarAdi.Text = "Yazar Adi:";
            // 
            // labelYazarSoyadi
            // 
            labelYazarSoyadi.AutoSize = true;
            labelYazarSoyadi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelYazarSoyadi.Location = new Point(0, 193);
            labelYazarSoyadi.Name = "labelYazarSoyadi";
            labelYazarSoyadi.Size = new Size(85, 17);
            labelYazarSoyadi.TabIndex = 2;
            labelYazarSoyadi.Text = "Yazar Soyadi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // labelKitapID
            // 
            labelKitapID.AutoSize = true;
            labelKitapID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelKitapID.Location = new Point(0, 34);
            labelKitapID.Name = "labelKitapID";
            labelKitapID.Size = new Size(57, 17);
            labelKitapID.TabIndex = 0;
            labelKitapID.Text = "KitapI D:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKitaplar);
            groupBox4.Location = new Point(1, 471);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(698, 135);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "KitapListesi";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 19);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowTemplate.Height = 25;
            dataGridViewKitaplar.Size = new Size(692, 113);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(701, 609);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormKitaplar";
            Text = "FormKitaplar";
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label labelKitapTurKodu;
        private Label labelISBN;
        private Label labelKitapAdi;
        private Label labelYazarAdi;
        private Label labelYazarSoyadi;
        private Label label2;
        private Label labelKitapID;
        private Label labelID;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyadi;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonKitapEkle;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private Label labelTarih;
        private Label labelOduncAlan;
        private Label labelTL;
        private Label labelGecikmeBedeli;
        private Button buttonGecikmeBedeliHesapla;
        private Label labelİadeGecikmeBedeli;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private TextBox textBoxOduncAlan;
        private Button buttonKitapİadeEt;
        private Button buttonKitabıOduncVer;
    }
}