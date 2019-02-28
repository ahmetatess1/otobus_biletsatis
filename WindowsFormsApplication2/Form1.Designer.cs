namespace WindowsFormsApplication2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaptanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otobüsEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acentaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servisEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaptanListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otobüsListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seferListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acentaListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servisListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yolcuListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılanBiletListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.biletSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.biletİptalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabloKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.listeleToolStripMenuItem,
            this.işlemlerToolStripMenuItem1,
            this.tabloKapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaptanEkleToolStripMenuItem,
            this.otobüsEkleToolStripMenuItem,
            this.seferEkleToolStripMenuItem,
            this.kullanıcıEkleToolStripMenuItem,
            this.acentaEkleToolStripMenuItem,
            this.servisEkleToolStripMenuItem});
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // kaptanEkleToolStripMenuItem
            // 
            this.kaptanEkleToolStripMenuItem.Name = "kaptanEkleToolStripMenuItem";
            this.kaptanEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.kaptanEkleToolStripMenuItem.Text = "Kaptan Ekle";
            this.kaptanEkleToolStripMenuItem.Click += new System.EventHandler(this.kaptanEkleToolStripMenuItem_Click);
            // 
            // otobüsEkleToolStripMenuItem
            // 
            this.otobüsEkleToolStripMenuItem.Name = "otobüsEkleToolStripMenuItem";
            this.otobüsEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.otobüsEkleToolStripMenuItem.Text = "Otobüs Ekle";
            this.otobüsEkleToolStripMenuItem.Click += new System.EventHandler(this.otobüsEkleToolStripMenuItem_Click);
            // 
            // seferEkleToolStripMenuItem
            // 
            this.seferEkleToolStripMenuItem.Name = "seferEkleToolStripMenuItem";
            this.seferEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.seferEkleToolStripMenuItem.Text = "Sefer Ekle";
            this.seferEkleToolStripMenuItem.Click += new System.EventHandler(this.seferEkleToolStripMenuItem_Click);
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // acentaEkleToolStripMenuItem
            // 
            this.acentaEkleToolStripMenuItem.Name = "acentaEkleToolStripMenuItem";
            this.acentaEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.acentaEkleToolStripMenuItem.Text = "Acenta Ekle";
            this.acentaEkleToolStripMenuItem.Click += new System.EventHandler(this.acentaEkleToolStripMenuItem_Click);
            // 
            // servisEkleToolStripMenuItem
            // 
            this.servisEkleToolStripMenuItem.Name = "servisEkleToolStripMenuItem";
            this.servisEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.servisEkleToolStripMenuItem.Text = "Servis Ekle";
            this.servisEkleToolStripMenuItem.Click += new System.EventHandler(this.servisEkleToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaptanListeleToolStripMenuItem,
            this.otobüsListeleToolStripMenuItem,
            this.seferListeleToolStripMenuItem,
            this.kullanıcıListeleToolStripMenuItem,
            this.acentaListeleToolStripMenuItem,
            this.servisListeleToolStripMenuItem,
            this.yolcuListeleToolStripMenuItem,
            this.satılanBiletListeleToolStripMenuItem});
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.listeleToolStripMenuItem.Text = "Listele";
            // 
            // kaptanListeleToolStripMenuItem
            // 
            this.kaptanListeleToolStripMenuItem.Name = "kaptanListeleToolStripMenuItem";
            this.kaptanListeleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.kaptanListeleToolStripMenuItem.Text = "Kaptan Listele";
            this.kaptanListeleToolStripMenuItem.Click += new System.EventHandler(this.kaptanListeleToolStripMenuItem_Click);
            // 
            // otobüsListeleToolStripMenuItem
            // 
            this.otobüsListeleToolStripMenuItem.Name = "otobüsListeleToolStripMenuItem";
            this.otobüsListeleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.otobüsListeleToolStripMenuItem.Text = "Otobüs Listele";
            this.otobüsListeleToolStripMenuItem.Click += new System.EventHandler(this.otobüsListeleToolStripMenuItem_Click);
            // 
            // seferListeleToolStripMenuItem
            // 
            this.seferListeleToolStripMenuItem.Name = "seferListeleToolStripMenuItem";
            this.seferListeleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.seferListeleToolStripMenuItem.Text = "Sefer Listele";
            this.seferListeleToolStripMenuItem.Click += new System.EventHandler(this.seferListeleToolStripMenuItem_Click);
            // 
            // kullanıcıListeleToolStripMenuItem
            // 
            this.kullanıcıListeleToolStripMenuItem.Name = "kullanıcıListeleToolStripMenuItem";
            this.kullanıcıListeleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.kullanıcıListeleToolStripMenuItem.Text = "Kullanıcı Listele";
            this.kullanıcıListeleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıListeleToolStripMenuItem_Click);
            // 
            // acentaListeleToolStripMenuItem
            // 
            this.acentaListeleToolStripMenuItem.Name = "acentaListeleToolStripMenuItem";
            this.acentaListeleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.acentaListeleToolStripMenuItem.Text = "Acenta Listele";
            this.acentaListeleToolStripMenuItem.Click += new System.EventHandler(this.acentaListeleToolStripMenuItem_Click);
            // 
            // servisListeleToolStripMenuItem
            // 
            this.servisListeleToolStripMenuItem.Name = "servisListeleToolStripMenuItem";
            this.servisListeleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.servisListeleToolStripMenuItem.Text = "Servis Listele";
            this.servisListeleToolStripMenuItem.Click += new System.EventHandler(this.servisListeleToolStripMenuItem_Click);
            // 
            // yolcuListeleToolStripMenuItem
            // 
            this.yolcuListeleToolStripMenuItem.Name = "yolcuListeleToolStripMenuItem";
            this.yolcuListeleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.yolcuListeleToolStripMenuItem.Text = "Yolcu Listele";
            this.yolcuListeleToolStripMenuItem.Click += new System.EventHandler(this.yolcuListeleToolStripMenuItem_Click);
            // 
            // satılanBiletListeleToolStripMenuItem
            // 
            this.satılanBiletListeleToolStripMenuItem.Name = "satılanBiletListeleToolStripMenuItem";
            this.satılanBiletListeleToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.satılanBiletListeleToolStripMenuItem.Text = "Satılan Bilet Listele";
            this.satılanBiletListeleToolStripMenuItem.Click += new System.EventHandler(this.satılanBiletListeleToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem1
            // 
            this.işlemlerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletSatışToolStripMenuItem,
            this.toolStripSeparator1,
            this.biletİptalToolStripMenuItem});
            this.işlemlerToolStripMenuItem1.Name = "işlemlerToolStripMenuItem1";
            this.işlemlerToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem1.Text = "İşlemler";
            // 
            // biletSatışToolStripMenuItem
            // 
            this.biletSatışToolStripMenuItem.Name = "biletSatışToolStripMenuItem";
            this.biletSatışToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.biletSatışToolStripMenuItem.Text = "Bilet Satış";
            this.biletSatışToolStripMenuItem.Click += new System.EventHandler(this.biletSatışToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // biletİptalToolStripMenuItem
            // 
            this.biletİptalToolStripMenuItem.Name = "biletİptalToolStripMenuItem";
            this.biletİptalToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.biletİptalToolStripMenuItem.Text = "Bilet İptal";
            this.biletİptalToolStripMenuItem.Click += new System.EventHandler(this.biletİptalToolStripMenuItem_Click);
            // 
            // tabloKapatToolStripMenuItem
            // 
            this.tabloKapatToolStripMenuItem.Name = "tabloKapatToolStripMenuItem";
            this.tabloKapatToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.tabloKapatToolStripMenuItem.Text = "Tablo Kapat";
            this.tabloKapatToolStripMenuItem.Click += new System.EventHandler(this.tabloKapatToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(4, 580);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 0);
            this.dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.araToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.CheckOnClick = true;
            this.düzenleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem});
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.düzenleToolStripMenuItem_CheckedChanged);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.araToolStripMenuItem.Text = "Ara";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(862, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Kapat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "adını giriniz:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aramak istediğiniz kişinin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaptanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otobüsEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acentaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servisEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem biletİptalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabloKapatToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaptanListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otobüsListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seferListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acentaListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servisListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yolcuListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılanBiletListeleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

