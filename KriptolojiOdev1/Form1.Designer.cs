namespace KriptolojiOdev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreBox = new System.Windows.Forms.TextBox();
            this.sifreleButton = new System.Windows.Forms.Button();
            this.cozButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kaydirmaliSifrelemePanel = new System.Windows.Forms.Panel();
            this.kaydirmaliKey = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sonucBox = new System.Windows.Forms.RichTextBox();
            this.affinePanel = new System.Windows.Forms.Panel();
            this.affineKeyB = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.affineKeyA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.yerDegistirmePanel = new System.Windows.Forms.Panel();
            this.seed = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.sayiAnahtarliPanel = new System.Windows.Forms.Panel();
            this.sayiAnahtarlamaKey = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.permutasyonPanel = new System.Windows.Forms.Panel();
            this.permutasyonSeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.permutasyonKey = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.rotaPanel = new System.Windows.Forms.Panel();
            this.rotaKey = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.zikzakPanel = new System.Windows.Forms.Panel();
            this.zikzakKey = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.mail_yolla = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.vigenerePanel = new System.Windows.Forms.Panel();
            this.vigenereKey = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DortKarePanel = new System.Windows.Forms.Panel();
            this.dortKareSeed = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.dortKareKey = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.hillPanel = new System.Windows.Forms.Panel();
            this.hillSeed = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.hillKey = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.kaydirmaliSifrelemePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaydirmaliKey)).BeginInit();
            this.affinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affineKeyB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affineKeyA)).BeginInit();
            this.yerDegistirmePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seed)).BeginInit();
            this.sayiAnahtarliPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sayiAnahtarlamaKey)).BeginInit();
            this.permutasyonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permutasyonSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permutasyonKey)).BeginInit();
            this.rotaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotaKey)).BeginInit();
            this.zikzakPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zikzakKey)).BeginInit();
            this.vigenerePanel.SuspendLayout();
            this.DortKarePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dortKareSeed)).BeginInit();
            this.hillPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hillSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hillKey)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kaydırmalı Şifreleme",
            "Doğrusal Şifreleme (Affine)",
            "Yer Değiştirme Şifreleme",
            "Yer Değiştirme Şifreleme (Sayı Anahtarlı)",
            "Permütasyon Şifreleme",
            "Rota Şifreleme",
            "Zikzak Şifreleme",
            "Vigenere Şifreleme",
            "4 Kare Şifreleme",
            "Hill Şifreleme"});
            this.comboBox1.Location = new System.Drawing.Point(90, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Kullanmak İstediğiniz Algoritmayı Seçiniz";
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "233301079 Emre Yaşar Çiftçi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(62, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "233301070 Osman Melih Kocaoğlu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kriptoloji Dersi Ödev-2";
            // 
            // sifreBox
            // 
            this.sifreBox.Location = new System.Drawing.Point(52, 198);
            this.sifreBox.Name = "sifreBox";
            this.sifreBox.Size = new System.Drawing.Size(264, 22);
            this.sifreBox.TabIndex = 4;
            // 
            // sifreleButton
            // 
            this.sifreleButton.BackColor = System.Drawing.Color.Lime;
            this.sifreleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreleButton.Location = new System.Drawing.Point(49, 250);
            this.sifreleButton.Name = "sifreleButton";
            this.sifreleButton.Size = new System.Drawing.Size(99, 52);
            this.sifreleButton.TabIndex = 5;
            this.sifreleButton.Text = "Şifrele";
            this.sifreleButton.UseVisualStyleBackColor = false;
            this.sifreleButton.Click += new System.EventHandler(this.sifreleButton_Click);
            // 
            // cozButton
            // 
            this.cozButton.BackColor = System.Drawing.Color.Red;
            this.cozButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cozButton.Location = new System.Drawing.Point(183, 250);
            this.cozButton.Name = "cozButton";
            this.cozButton.Size = new System.Drawing.Size(99, 52);
            this.cozButton.TabIndex = 6;
            this.cozButton.Text = "Çöz";
            this.cozButton.UseVisualStyleBackColor = false;
            this.cozButton.Click += new System.EventHandler(this.cozButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Key:";
            // 
            // kaydirmaliSifrelemePanel
            // 
            this.kaydirmaliSifrelemePanel.Controls.Add(this.kaydirmaliKey);
            this.kaydirmaliSifrelemePanel.Controls.Add(this.label5);
            this.kaydirmaliSifrelemePanel.Location = new System.Drawing.Point(169, 129);
            this.kaydirmaliSifrelemePanel.Name = "kaydirmaliSifrelemePanel";
            this.kaydirmaliSifrelemePanel.Size = new System.Drawing.Size(111, 51);
            this.kaydirmaliSifrelemePanel.TabIndex = 9;
            this.kaydirmaliSifrelemePanel.Visible = false;
            // 
            // kaydirmaliKey
            // 
            this.kaydirmaliKey.Location = new System.Drawing.Point(51, 17);
            this.kaydirmaliKey.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.kaydirmaliKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kaydirmaliKey.Name = "kaydirmaliKey";
            this.kaydirmaliKey.Size = new System.Drawing.Size(53, 22);
            this.kaydirmaliKey.TabIndex = 9;
            this.kaydirmaliKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sonucBox
            // 
            this.sonucBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucBox.Location = new System.Drawing.Point(47, 318);
            this.sonucBox.Name = "sonucBox";
            this.sonucBox.Size = new System.Drawing.Size(374, 67);
            this.sonucBox.TabIndex = 11;
            this.sonucBox.Text = "";
            // 
            // affinePanel
            // 
            this.affinePanel.Controls.Add(this.affineKeyB);
            this.affinePanel.Controls.Add(this.label6);
            this.affinePanel.Controls.Add(this.affineKeyA);
            this.affinePanel.Controls.Add(this.label4);
            this.affinePanel.Location = new System.Drawing.Point(141, 129);
            this.affinePanel.Name = "affinePanel";
            this.affinePanel.Size = new System.Drawing.Size(179, 51);
            this.affinePanel.TabIndex = 12;
            this.affinePanel.Visible = false;
            // 
            // affineKeyB
            // 
            this.affineKeyB.Location = new System.Drawing.Point(123, 19);
            this.affineKeyB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.affineKeyB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.affineKeyB.Name = "affineKeyB";
            this.affineKeyB.Size = new System.Drawing.Size(53, 22);
            this.affineKeyB.TabIndex = 13;
            this.affineKeyB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(97, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "B:";
            // 
            // affineKeyA
            // 
            this.affineKeyA.Location = new System.Drawing.Point(35, 18);
            this.affineKeyA.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.affineKeyA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.affineKeyA.Name = "affineKeyA";
            this.affineKeyA.Size = new System.Drawing.Size(53, 22);
            this.affineKeyA.TabIndex = 11;
            this.affineKeyA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "A:";
            // 
            // yerDegistirmePanel
            // 
            this.yerDegistirmePanel.Controls.Add(this.seed);
            this.yerDegistirmePanel.Controls.Add(this.label);
            this.yerDegistirmePanel.Location = new System.Drawing.Point(161, 129);
            this.yerDegistirmePanel.Name = "yerDegistirmePanel";
            this.yerDegistirmePanel.Size = new System.Drawing.Size(133, 51);
            this.yerDegistirmePanel.TabIndex = 14;
            this.yerDegistirmePanel.Visible = false;
            // 
            // seed
            // 
            this.seed.Location = new System.Drawing.Point(69, 17);
            this.seed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.seed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(53, 22);
            this.seed.TabIndex = 11;
            this.seed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.Location = new System.Drawing.Point(9, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 20);
            this.label.TabIndex = 10;
            this.label.Text = "Seed:";
            // 
            // sayiAnahtarliPanel
            // 
            this.sayiAnahtarliPanel.Controls.Add(this.sayiAnahtarlamaKey);
            this.sayiAnahtarliPanel.Controls.Add(this.label7);
            this.sayiAnahtarliPanel.Location = new System.Drawing.Point(167, 129);
            this.sayiAnahtarliPanel.Name = "sayiAnahtarliPanel";
            this.sayiAnahtarliPanel.Size = new System.Drawing.Size(133, 51);
            this.sayiAnahtarliPanel.TabIndex = 15;
            this.sayiAnahtarliPanel.Visible = false;
            // 
            // sayiAnahtarlamaKey
            // 
            this.sayiAnahtarlamaKey.Location = new System.Drawing.Point(43, 17);
            this.sayiAnahtarlamaKey.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.sayiAnahtarlamaKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sayiAnahtarlamaKey.Name = "sayiAnahtarlamaKey";
            this.sayiAnahtarlamaKey.Size = new System.Drawing.Size(53, 22);
            this.sayiAnahtarlamaKey.TabIndex = 11;
            this.sayiAnahtarlamaKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(14, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "K:";
            // 
            // permutasyonPanel
            // 
            this.permutasyonPanel.Controls.Add(this.permutasyonSeed);
            this.permutasyonPanel.Controls.Add(this.label9);
            this.permutasyonPanel.Controls.Add(this.permutasyonKey);
            this.permutasyonPanel.Controls.Add(this.label8);
            this.permutasyonPanel.Location = new System.Drawing.Point(107, 129);
            this.permutasyonPanel.Name = "permutasyonPanel";
            this.permutasyonPanel.Size = new System.Drawing.Size(252, 51);
            this.permutasyonPanel.TabIndex = 16;
            this.permutasyonPanel.Visible = false;
            // 
            // permutasyonSeed
            // 
            this.permutasyonSeed.Location = new System.Drawing.Point(167, 17);
            this.permutasyonSeed.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.permutasyonSeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.permutasyonSeed.Name = "permutasyonSeed";
            this.permutasyonSeed.Size = new System.Drawing.Size(53, 22);
            this.permutasyonSeed.TabIndex = 13;
            this.permutasyonSeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(110, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Seed:";
            // 
            // permutasyonKey
            // 
            this.permutasyonKey.Location = new System.Drawing.Point(43, 17);
            this.permutasyonKey.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.permutasyonKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.permutasyonKey.Name = "permutasyonKey";
            this.permutasyonKey.Size = new System.Drawing.Size(53, 22);
            this.permutasyonKey.TabIndex = 11;
            this.permutasyonKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "K:";
            // 
            // rotaPanel
            // 
            this.rotaPanel.Controls.Add(this.rotaKey);
            this.rotaPanel.Controls.Add(this.label11);
            this.rotaPanel.Location = new System.Drawing.Point(170, 129);
            this.rotaPanel.Name = "rotaPanel";
            this.rotaPanel.Size = new System.Drawing.Size(117, 51);
            this.rotaPanel.TabIndex = 17;
            this.rotaPanel.Visible = false;
            // 
            // rotaKey
            // 
            this.rotaKey.Location = new System.Drawing.Point(43, 17);
            this.rotaKey.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.rotaKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotaKey.Name = "rotaKey";
            this.rotaKey.Size = new System.Drawing.Size(53, 22);
            this.rotaKey.TabIndex = 11;
            this.rotaKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(14, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "K:";
            // 
            // zikzakPanel
            // 
            this.zikzakPanel.Controls.Add(this.zikzakKey);
            this.zikzakPanel.Controls.Add(this.label10);
            this.zikzakPanel.Location = new System.Drawing.Point(169, 129);
            this.zikzakPanel.Name = "zikzakPanel";
            this.zikzakPanel.Size = new System.Drawing.Size(117, 51);
            this.zikzakPanel.TabIndex = 18;
            this.zikzakPanel.Visible = false;
            // 
            // zikzakKey
            // 
            this.zikzakKey.Location = new System.Drawing.Point(43, 17);
            this.zikzakKey.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.zikzakKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zikzakKey.Name = "zikzakKey";
            this.zikzakKey.Size = new System.Drawing.Size(53, 22);
            this.zikzakKey.TabIndex = 11;
            this.zikzakKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(14, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "K:";
            // 
            // mail_yolla
            // 
            this.mail_yolla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mail_yolla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mail_yolla.Location = new System.Drawing.Point(318, 250);
            this.mail_yolla.Name = "mail_yolla";
            this.mail_yolla.Size = new System.Drawing.Size(99, 52);
            this.mail_yolla.TabIndex = 19;
            this.mail_yolla.Text = "Mail Yolla";
            this.mail_yolla.UseVisualStyleBackColor = false;
            this.mail_yolla.Click += new System.EventHandler(this.mail_yolla_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.BackColor = System.Drawing.Color.Yellow;
            this.temizleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.Location = new System.Drawing.Point(318, 195);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(99, 32);
            this.temizleButton.TabIndex = 20;
            this.temizleButton.Text = "Temizle";
            this.temizleButton.UseVisualStyleBackColor = false;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // vigenerePanel
            // 
            this.vigenerePanel.Controls.Add(this.vigenereKey);
            this.vigenerePanel.Controls.Add(this.label12);
            this.vigenerePanel.Location = new System.Drawing.Point(125, 129);
            this.vigenerePanel.Name = "vigenerePanel";
            this.vigenerePanel.Size = new System.Drawing.Size(221, 51);
            this.vigenerePanel.TabIndex = 19;
            this.vigenerePanel.Visible = false;
            // 
            // vigenereKey
            // 
            this.vigenereKey.Location = new System.Drawing.Point(44, 18);
            this.vigenereKey.Name = "vigenereKey";
            this.vigenereKey.Size = new System.Drawing.Size(165, 22);
            this.vigenereKey.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(14, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "K:";
            // 
            // DortKarePanel
            // 
            this.DortKarePanel.Controls.Add(this.dortKareSeed);
            this.DortKarePanel.Controls.Add(this.label14);
            this.DortKarePanel.Controls.Add(this.dortKareKey);
            this.DortKarePanel.Controls.Add(this.label13);
            this.DortKarePanel.Location = new System.Drawing.Point(78, 129);
            this.DortKarePanel.Name = "DortKarePanel";
            this.DortKarePanel.Size = new System.Drawing.Size(329, 51);
            this.DortKarePanel.TabIndex = 20;
            this.DortKarePanel.Visible = false;
            // 
            // dortKareSeed
            // 
            this.dortKareSeed.Location = new System.Drawing.Point(220, 15);
            this.dortKareSeed.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.dortKareSeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dortKareSeed.Name = "dortKareSeed";
            this.dortKareSeed.Size = new System.Drawing.Size(66, 22);
            this.dortKareSeed.TabIndex = 13;
            this.dortKareSeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(157, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Seed:";
            // 
            // dortKareKey
            // 
            this.dortKareKey.FormattingEnabled = true;
            this.dortKareKey.Items.AddRange(new object[] {
            "6x5",
            "5x6"});
            this.dortKareKey.Location = new System.Drawing.Point(42, 15);
            this.dortKareKey.Name = "dortKareKey";
            this.dortKareKey.Size = new System.Drawing.Size(62, 24);
            this.dortKareKey.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(11, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "K:";
            // 
            // hillPanel
            // 
            this.hillPanel.Controls.Add(this.hillSeed);
            this.hillPanel.Controls.Add(this.label15);
            this.hillPanel.Controls.Add(this.hillKey);
            this.hillPanel.Controls.Add(this.label16);
            this.hillPanel.Location = new System.Drawing.Point(78, 129);
            this.hillPanel.Name = "hillPanel";
            this.hillPanel.Size = new System.Drawing.Size(312, 51);
            this.hillPanel.TabIndex = 21;
            this.hillPanel.Visible = false;
            // 
            // hillSeed
            // 
            this.hillSeed.Location = new System.Drawing.Point(217, 14);
            this.hillSeed.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.hillSeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hillSeed.Name = "hillSeed";
            this.hillSeed.Size = new System.Drawing.Size(66, 22);
            this.hillSeed.TabIndex = 15;
            this.hillSeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(154, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Seed:";
            // 
            // hillKey
            // 
            this.hillKey.Location = new System.Drawing.Point(41, 16);
            this.hillKey.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.hillKey.Name = "hillKey";
            this.hillKey.Size = new System.Drawing.Size(57, 22);
            this.hillKey.TabIndex = 11;
            this.hillKey.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(11, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "K:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.hillPanel);
            this.Controls.Add(this.DortKarePanel);
            this.Controls.Add(this.vigenerePanel);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.mail_yolla);
            this.Controls.Add(this.zikzakPanel);
            this.Controls.Add(this.rotaPanel);
            this.Controls.Add(this.permutasyonPanel);
            this.Controls.Add(this.sayiAnahtarliPanel);
            this.Controls.Add(this.yerDegistirmePanel);
            this.Controls.Add(this.affinePanel);
            this.Controls.Add(this.sonucBox);
            this.Controls.Add(this.kaydirmaliSifrelemePanel);
            this.Controls.Add(this.cozButton);
            this.Controls.Add(this.sifreleButton);
            this.Controls.Add(this.sifreBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.kaydirmaliSifrelemePanel.ResumeLayout(false);
            this.kaydirmaliSifrelemePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaydirmaliKey)).EndInit();
            this.affinePanel.ResumeLayout(false);
            this.affinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.affineKeyB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affineKeyA)).EndInit();
            this.yerDegistirmePanel.ResumeLayout(false);
            this.yerDegistirmePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seed)).EndInit();
            this.sayiAnahtarliPanel.ResumeLayout(false);
            this.sayiAnahtarliPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sayiAnahtarlamaKey)).EndInit();
            this.permutasyonPanel.ResumeLayout(false);
            this.permutasyonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permutasyonSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permutasyonKey)).EndInit();
            this.rotaPanel.ResumeLayout(false);
            this.rotaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotaKey)).EndInit();
            this.zikzakPanel.ResumeLayout(false);
            this.zikzakPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zikzakKey)).EndInit();
            this.vigenerePanel.ResumeLayout(false);
            this.vigenerePanel.PerformLayout();
            this.DortKarePanel.ResumeLayout(false);
            this.DortKarePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dortKareSeed)).EndInit();
            this.hillPanel.ResumeLayout(false);
            this.hillPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hillSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hillKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sifreBox;
        private System.Windows.Forms.Button sifreleButton;
        private System.Windows.Forms.Button cozButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel kaydirmaliSifrelemePanel;
        private System.Windows.Forms.NumericUpDown kaydirmaliKey;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox sonucBox;
        private System.Windows.Forms.Panel affinePanel;
        private System.Windows.Forms.NumericUpDown affineKeyB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown affineKeyA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel yerDegistirmePanel;
        private System.Windows.Forms.NumericUpDown seed;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel sayiAnahtarliPanel;
        private System.Windows.Forms.NumericUpDown sayiAnahtarlamaKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel permutasyonPanel;
        private System.Windows.Forms.NumericUpDown permutasyonKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown permutasyonSeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel rotaPanel;
        private System.Windows.Forms.NumericUpDown rotaKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel zikzakPanel;
        private System.Windows.Forms.NumericUpDown zikzakKey;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button mail_yolla;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Panel vigenerePanel;
        private System.Windows.Forms.TextBox vigenereKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel DortKarePanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox dortKareKey;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown dortKareSeed;
        private System.Windows.Forms.Panel hillPanel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown hillKey;
        private System.Windows.Forms.NumericUpDown hillSeed;
        private System.Windows.Forms.Label label15;
    }
}

