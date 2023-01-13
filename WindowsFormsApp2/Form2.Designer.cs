namespace WindowsFormsApp2
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ödemeEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veresiyeSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peşinSatışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBorçDurumRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.karZararDurumRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokBilgiGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 47);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.ödemeEkranıToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.stokToolStripMenuItem,
            this.borçToolStripMenuItem,
            this.müşteriEklemeToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Heavy", 20F);
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(125, 43);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // ödemeEkranıToolStripMenuItem
            // 
            this.ödemeEkranıToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.ödemeEkranıToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F);
            this.ödemeEkranıToolStripMenuItem.Name = "ödemeEkranıToolStripMenuItem";
            this.ödemeEkranıToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.ödemeEkranıToolStripMenuItem.Text = "Ödeme ekranı";
            this.ödemeEkranıToolStripMenuItem.Click += new System.EventHandler(this.ödemeEkranıToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veresiyeSatışToolStripMenuItem,
            this.peşinSatışToolStripMenuItem});
            this.satışToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F);
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.satışToolStripMenuItem.Text = "Satış";
            // 
            // veresiyeSatışToolStripMenuItem
            // 
            this.veresiyeSatışToolStripMenuItem.Name = "veresiyeSatışToolStripMenuItem";
            this.veresiyeSatışToolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.veresiyeSatışToolStripMenuItem.Text = "Veresiye Satış";
            this.veresiyeSatışToolStripMenuItem.Click += new System.EventHandler(this.veresiyeSatışToolStripMenuItem_Click);
            // 
            // peşinSatışToolStripMenuItem
            // 
            this.peşinSatışToolStripMenuItem.Name = "peşinSatışToolStripMenuItem";
            this.peşinSatışToolStripMenuItem.Size = new System.Drawing.Size(271, 36);
            this.peşinSatışToolStripMenuItem.Text = "Peşin Satış";
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriBorçDurumRaporuToolStripMenuItem,
            this.karZararDurumRaporlarıToolStripMenuItem});
            this.raporToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F);
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // müşteriBorçDurumRaporuToolStripMenuItem
            // 
            this.müşteriBorçDurumRaporuToolStripMenuItem.Name = "müşteriBorçDurumRaporuToolStripMenuItem";
            this.müşteriBorçDurumRaporuToolStripMenuItem.Size = new System.Drawing.Size(419, 36);
            this.müşteriBorçDurumRaporuToolStripMenuItem.Text = "müşteri borç durum raporu";
            // 
            // karZararDurumRaporlarıToolStripMenuItem
            // 
            this.karZararDurumRaporlarıToolStripMenuItem.Name = "karZararDurumRaporlarıToolStripMenuItem";
            this.karZararDurumRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(419, 36);
            this.karZararDurumRaporlarıToolStripMenuItem.Text = "kar zarar durum raporları";
            // 
            // stokToolStripMenuItem
            // 
            this.stokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEklemeToolStripMenuItem,
            this.stokBilgiGörüntülemeToolStripMenuItem});
            this.stokToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F);
            this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            this.stokToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.stokToolStripMenuItem.Text = "Stok";
            // 
            // ürünEklemeToolStripMenuItem
            // 
            this.ürünEklemeToolStripMenuItem.Name = "ürünEklemeToolStripMenuItem";
            this.ürünEklemeToolStripMenuItem.Size = new System.Drawing.Size(368, 36);
            this.ürünEklemeToolStripMenuItem.Text = "Ürün Ekleme";
            this.ürünEklemeToolStripMenuItem.Click += new System.EventHandler(this.ürünEklemeToolStripMenuItem_Click);
            // 
            // stokBilgiGörüntülemeToolStripMenuItem
            // 
            this.stokBilgiGörüntülemeToolStripMenuItem.Name = "stokBilgiGörüntülemeToolStripMenuItem";
            this.stokBilgiGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(368, 36);
            this.stokBilgiGörüntülemeToolStripMenuItem.Text = "Stok bilgi görüntüleme";
            this.stokBilgiGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.stokBilgiGörüntülemeToolStripMenuItem_Click);
            // 
            // borçToolStripMenuItem
            // 
            this.borçToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F);
            this.borçToolStripMenuItem.Name = "borçToolStripMenuItem";
            this.borçToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.borçToolStripMenuItem.Text = "Borç ";
            // 
            // müşteriEklemeToolStripMenuItem
            // 
            this.müşteriEklemeToolStripMenuItem.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.müşteriEklemeToolStripMenuItem.Name = "müşteriEklemeToolStripMenuItem";
            this.müşteriEklemeToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.müşteriEklemeToolStripMenuItem.Text = "Müşteri ekleme";
            this.müşteriEklemeToolStripMenuItem.Click += new System.EventHandler(this.müşteriEklemeToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(888, 530);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ödemeEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veresiyeSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peşinSatışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBorçDurumRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem karZararDurumRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokBilgiGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEklemeToolStripMenuItem;
    }
}