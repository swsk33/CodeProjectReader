
namespace CodeLineReader
{
	partial class FileReader
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileReader));
			this.content = new System.Windows.Forms.TextBox();
			this.copyCode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// content
			// 
			this.content.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.content.Dock = System.Windows.Forms.DockStyle.Top;
			this.content.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.content.ForeColor = System.Drawing.Color.Lime;
			this.content.Location = new System.Drawing.Point(0, 0);
			this.content.Multiline = true;
			this.content.Name = "content";
			this.content.ReadOnly = true;
			this.content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.content.Size = new System.Drawing.Size(786, 456);
			this.content.TabIndex = 0;
			this.content.WordWrap = false;
			// 
			// copyCode
			// 
			this.copyCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.copyCode.Location = new System.Drawing.Point(352, 463);
			this.copyCode.Name = "copyCode";
			this.copyCode.Size = new System.Drawing.Size(83, 28);
			this.copyCode.TabIndex = 1;
			this.copyCode.Text = "复制代码";
			this.copyCode.UseVisualStyleBackColor = true;
			this.copyCode.Click += new System.EventHandler(this.copyCode_Click);
			// 
			// FileReader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 498);
			this.Controls.Add(this.copyCode);
			this.Controls.Add(this.content);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FileReader";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "代码文件查看器";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox content;
		private System.Windows.Forms.Button copyCode;
	}
}