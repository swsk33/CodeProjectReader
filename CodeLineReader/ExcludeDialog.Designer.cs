
namespace CodeLineReader
{
	partial class ExcludeDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcludeDialog));
			this.excludeFileList = new System.Windows.Forms.ListBox();
			this.excludeFileLabel = new System.Windows.Forms.Label();
			this.excludeDirList = new System.Windows.Forms.ListBox();
			this.excludeDirLabel = new System.Windows.Forms.Label();
			this.ok = new System.Windows.Forms.Button();
			this.removeFile = new System.Windows.Forms.Button();
			this.addFile = new System.Windows.Forms.Button();
			this.removeDir = new System.Windows.Forms.Button();
			this.addDir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// excludeFileList
			// 
			this.excludeFileList.FormattingEnabled = true;
			this.excludeFileList.ItemHeight = 12;
			this.excludeFileList.Location = new System.Drawing.Point(12, 30);
			this.excludeFileList.Name = "excludeFileList";
			this.excludeFileList.Size = new System.Drawing.Size(379, 100);
			this.excludeFileList.TabIndex = 0;
			// 
			// excludeFileLabel
			// 
			this.excludeFileLabel.AutoSize = true;
			this.excludeFileLabel.Location = new System.Drawing.Point(13, 10);
			this.excludeFileLabel.Name = "excludeFileLabel";
			this.excludeFileLabel.Size = new System.Drawing.Size(89, 12);
			this.excludeFileLabel.TabIndex = 1;
			this.excludeFileLabel.Text = "排除文件列表：";
			// 
			// excludeDirList
			// 
			this.excludeDirList.FormattingEnabled = true;
			this.excludeDirList.ItemHeight = 12;
			this.excludeDirList.Location = new System.Drawing.Point(12, 159);
			this.excludeDirList.Name = "excludeDirList";
			this.excludeDirList.Size = new System.Drawing.Size(379, 100);
			this.excludeDirList.TabIndex = 0;
			// 
			// excludeDirLabel
			// 
			this.excludeDirLabel.AutoSize = true;
			this.excludeDirLabel.Location = new System.Drawing.Point(13, 139);
			this.excludeDirLabel.Name = "excludeDirLabel";
			this.excludeDirLabel.Size = new System.Drawing.Size(101, 12);
			this.excludeDirLabel.TabIndex = 1;
			this.excludeDirLabel.Text = "排除文件夹列表：";
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(165, 265);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(75, 23);
			this.ok.TabIndex = 2;
			this.ok.Text = "确定";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// removeFile
			// 
			this.removeFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.removeFile.Location = new System.Drawing.Point(369, 5);
			this.removeFile.Name = "removeFile";
			this.removeFile.Size = new System.Drawing.Size(21, 21);
			this.removeFile.TabIndex = 2;
			this.removeFile.Text = "-";
			this.removeFile.UseVisualStyleBackColor = true;
			this.removeFile.Click += new System.EventHandler(this.removeFile_Click);
			// 
			// addFile
			// 
			this.addFile.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.addFile.Location = new System.Drawing.Point(342, 5);
			this.addFile.Name = "addFile";
			this.addFile.Size = new System.Drawing.Size(21, 21);
			this.addFile.TabIndex = 2;
			this.addFile.Text = "+";
			this.addFile.UseVisualStyleBackColor = true;
			this.addFile.Click += new System.EventHandler(this.addFile_Click);
			// 
			// removeDir
			// 
			this.removeDir.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.removeDir.Location = new System.Drawing.Point(370, 134);
			this.removeDir.Name = "removeDir";
			this.removeDir.Size = new System.Drawing.Size(21, 21);
			this.removeDir.TabIndex = 2;
			this.removeDir.Text = "-";
			this.removeDir.UseVisualStyleBackColor = true;
			this.removeDir.Click += new System.EventHandler(this.removeDir_Click);
			// 
			// addDir
			// 
			this.addDir.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.addDir.Location = new System.Drawing.Point(343, 134);
			this.addDir.Name = "addDir";
			this.addDir.Size = new System.Drawing.Size(21, 21);
			this.addDir.TabIndex = 2;
			this.addDir.Text = "+";
			this.addDir.UseVisualStyleBackColor = true;
			this.addDir.Click += new System.EventHandler(this.addDir_Click);
			// 
			// ExcludeDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 294);
			this.Controls.Add(this.addDir);
			this.Controls.Add(this.addFile);
			this.Controls.Add(this.removeDir);
			this.Controls.Add(this.removeFile);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.excludeDirLabel);
			this.Controls.Add(this.excludeFileLabel);
			this.Controls.Add(this.excludeDirList);
			this.Controls.Add(this.excludeFileList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExcludeDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "设定排除列表";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox excludeFileList;
		private System.Windows.Forms.Label excludeFileLabel;
		private System.Windows.Forms.ListBox excludeDirList;
		private System.Windows.Forms.Label excludeDirLabel;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.Button removeFile;
		private System.Windows.Forms.Button addFile;
		private System.Windows.Forms.Button removeDir;
		private System.Windows.Forms.Button addDir;
	}
}