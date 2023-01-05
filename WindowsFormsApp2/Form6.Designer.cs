namespace WindowsFormsApp2
{
    partial class Form6
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(93, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 518);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "menü";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "satış";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.ödemeToolStripMenuItem,
            this.stokToolStripMenuItem,
            this.tedarikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "satış";
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(70, 27);
            this.ödemeToolStripMenuItem.Text = "ödeme";
            // 
            // stokToolStripMenuItem
            // 
            this.stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            this.stokToolStripMenuItem.Size = new System.Drawing.Size(50, 27);
            this.stokToolStripMenuItem.Text = "stok";
            // 
            // tedarikToolStripMenuItem
            // 
            this.tedarikToolStripMenuItem.Name = "tedarikToolStripMenuItem";
            this.tedarikToolStripMenuItem.Size = new System.Drawing.Size(69, 27);
            this.tedarikToolStripMenuItem.Text = "tedarik";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(619, 611);
            this.Controls.Add(this.panel1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikToolStripMenuItem;
    }
}