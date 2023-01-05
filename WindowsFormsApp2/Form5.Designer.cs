namespace WindowsFormsApp2
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fvgbhnjmkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veresiyeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peşinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bnmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bnmöToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bnmöToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(95, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 476);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fvgbhnjmkToolStripMenuItem,
            this.bnmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fvgbhnjmkToolStripMenuItem
            // 
            this.fvgbhnjmkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veresiyeToolStripMenuItem,
            this.peşinToolStripMenuItem});
            this.fvgbhnjmkToolStripMenuItem.Name = "fvgbhnjmkToolStripMenuItem";
            this.fvgbhnjmkToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.fvgbhnjmkToolStripMenuItem.Text = "menü";
            // 
            // veresiyeToolStripMenuItem
            // 
            this.veresiyeToolStripMenuItem.Name = "veresiyeToolStripMenuItem";
            this.veresiyeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.veresiyeToolStripMenuItem.Text = "veresiye";
            // 
            // peşinToolStripMenuItem
            // 
            this.peşinToolStripMenuItem.Name = "peşinToolStripMenuItem";
            this.peşinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.peşinToolStripMenuItem.Text = "peşin";
            // 
            // bnmToolStripMenuItem
            // 
            this.bnmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnmöToolStripMenuItem,
            this.bnmöToolStripMenuItem1});
            this.bnmToolStripMenuItem.Name = "bnmToolStripMenuItem";
            this.bnmToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.bnmToolStripMenuItem.Text = "bnm";
            // 
            // bnmöToolStripMenuItem
            // 
            this.bnmöToolStripMenuItem.Name = "bnmöToolStripMenuItem";
            this.bnmöToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bnmöToolStripMenuItem.Text = "bnmö";
            // 
            // bnmöToolStripMenuItem1
            // 
            this.bnmöToolStripMenuItem1.Name = "bnmöToolStripMenuItem1";
            this.bnmöToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.bnmöToolStripMenuItem1.Text = "bnmö";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(665, 607);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fvgbhnjmkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veresiyeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peşinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bnmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bnmöToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bnmöToolStripMenuItem1;
    }
}