
namespace CodeLineReader
{
	partial class TextEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEdit));
			this.title = new System.Windows.Forms.Label();
			this.valueBox = new System.Windows.Forms.TextBox();
			this.ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.title.Location = new System.Drawing.Point(69, 9);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(63, 14);
			this.title.TabIndex = 0;
			this.title.Text = "请输入值";
			// 
			// valueBox
			// 
			this.valueBox.Location = new System.Drawing.Point(12, 33);
			this.valueBox.Name = "valueBox";
			this.valueBox.Size = new System.Drawing.Size(182, 21);
			this.valueBox.TabIndex = 1;
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(63, 63);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(75, 23);
			this.ok.TabIndex = 2;
			this.ok.Text = "确定";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// TextEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(206, 96);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.valueBox);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TextEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "编辑";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.TextBox valueBox;
		private System.Windows.Forms.Button ok;
	}
}