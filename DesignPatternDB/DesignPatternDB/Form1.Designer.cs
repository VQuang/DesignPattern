﻿namespace DesignPatternDB
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// danhMụcToolStripMenuItem
			// 
			this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.mặtHàngToolStripMenuItem});
			this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
			this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
			this.danhMụcToolStripMenuItem.Text = "Danh mục";
			// 
			// kháchHàngToolStripMenuItem
			// 
			this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
			this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
			this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
			// 
			// mặtHàngToolStripMenuItem
			// 
			this.mặtHàngToolStripMenuItem.Name = "mặtHàngToolStripMenuItem";
			this.mặtHàngToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.mặtHàngToolStripMenuItem.Text = "Mặt hàng";
			this.mặtHàngToolStripMenuItem.Click += new System.EventHandler(this.mặtHàngToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mặtHàngToolStripMenuItem;
	}
}

