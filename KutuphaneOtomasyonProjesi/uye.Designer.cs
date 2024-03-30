namespace KutuphaneOtomasyonProjesi
{
    partial class uye
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
            this.btnara = new System.Windows.Forms.Button();
            this.btnyenile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(113, 29);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(232, 37);
            this.btnara.TabIndex = 0;
            this.btnara.Text = "ARA";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnyenile
            // 
            this.btnyenile.Location = new System.Drawing.Point(735, 29);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(260, 44);
            this.btnyenile.TabIndex = 0;
            this.btnyenile.Text = "YENİLE";
            this.btnyenile.UseVisualStyleBackColor = true;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 26);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isim,
            this.yazar,
            this.dil,
            this.yayinevi,
            this.tur,
            this.adet,
            this.sayfasayi,
            this.basimyili});
            this.dataGridView1.Location = new System.Drawing.Point(103, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(911, 390);
            this.dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "KİTAP ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 75;
            // 
            // isim
            // 
            this.isim.HeaderText = "KİTAP İSİM";
            this.isim.MinimumWidth = 8;
            this.isim.Name = "isim";
            this.isim.Width = 150;
            // 
            // yazar
            // 
            this.yazar.HeaderText = "YAZAR";
            this.yazar.MinimumWidth = 8;
            this.yazar.Name = "yazar";
            this.yazar.Width = 150;
            // 
            // dil
            // 
            this.dil.HeaderText = "DİL";
            this.dil.MinimumWidth = 8;
            this.dil.Name = "dil";
            this.dil.Width = 75;
            // 
            // yayinevi
            // 
            this.yayinevi.HeaderText = "YAYIN EVİ";
            this.yayinevi.MinimumWidth = 8;
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Width = 150;
            // 
            // tur
            // 
            this.tur.HeaderText = "TÜR";
            this.tur.MinimumWidth = 8;
            this.tur.Name = "tur";
            this.tur.Width = 75;
            // 
            // adet
            // 
            this.adet.HeaderText = "ADET";
            this.adet.MinimumWidth = 8;
            this.adet.Name = "adet";
            this.adet.Width = 75;
            // 
            // sayfasayi
            // 
            this.sayfasayi.HeaderText = "SAYFA SAYISI";
            this.sayfasayi.MinimumWidth = 8;
            this.sayfasayi.Name = "sayfasayi";
            this.sayfasayi.Width = 75;
            // 
            // basimyili
            // 
            this.basimyili.HeaderText = "BASIM YILI";
            this.basimyili.MinimumWidth = 8;
            this.basimyili.Name = "basimyili";
            this.basimyili.Width = 75;
            // 
            // uye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnyenile);
            this.Controls.Add(this.btnara);
            this.Name = "uye";
            this.Text = "üye";
            this.Load += new System.EventHandler(this.uye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dil;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimyili;
    }
}