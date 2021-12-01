
namespace CodeLineReader
{
	partial class MainGUI
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("工程目录", 0, 0);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
			this.openDirLabel = new System.Windows.Forms.Label();
			this.openDir = new System.Windows.Forms.Button();
			this.resultTreeView = new System.Windows.Forms.TreeView();
			this.treeViewIcons = new System.Windows.Forms.ImageList(this.components);
			this.codeFileListLabel = new System.Windows.Forms.Label();
			this.lineCountTitle = new System.Windows.Forms.Label();
			this.lineCountResult = new System.Windows.Forms.Label();
			this.copyLineCount = new System.Windows.Forms.Button();
			this.readingStatusLabel = new System.Windows.Forms.Label();
			this.dirPath = new System.Windows.Forms.TextBox();
			this.excludeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// openDirLabel
			// 
			this.openDirLabel.AutoSize = true;
			this.openDirLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.openDirLabel.Location = new System.Drawing.Point(12, 21);
			this.openDirLabel.Name = "openDirLabel";
			this.openDirLabel.Size = new System.Drawing.Size(77, 14);
			this.openDirLabel.TabIndex = 0;
			this.openDirLabel.Text = "项目目录：";
			// 
			// openDir
			// 
			this.openDir.Location = new System.Drawing.Point(280, 17);
			this.openDir.Name = "openDir";
			this.openDir.Size = new System.Drawing.Size(95, 23);
			this.openDir.TabIndex = 2;
			this.openDir.Text = "浏览";
			this.openDir.UseVisualStyleBackColor = true;
			this.openDir.Click += new System.EventHandler(this.openDir_Click);
			// 
			// resultTreeView
			// 
			this.resultTreeView.ImageIndex = 0;
			this.resultTreeView.ImageList = this.treeViewIcons;
			this.resultTreeView.Location = new System.Drawing.Point(14, 74);
			this.resultTreeView.Name = "resultTreeView";
			treeNode1.ImageIndex = 0;
			treeNode1.Name = "rootNode";
			treeNode1.SelectedImageIndex = 0;
			treeNode1.Text = "工程目录";
			this.resultTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.resultTreeView.SelectedImageIndex = 1;
			this.resultTreeView.Size = new System.Drawing.Size(361, 196);
			this.resultTreeView.TabIndex = 3;
			this.resultTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.resultTreeView_NodeMouseDoubleClick);
			// 
			// treeViewIcons
			// 
			this.treeViewIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewIcons.ImageStream")));
			this.treeViewIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.treeViewIcons.Images.SetKeyName(0, "root.png");
			this.treeViewIcons.Images.SetKeyName(1, "directory.png");
			this.treeViewIcons.Images.SetKeyName(2, "code.png");
			// 
			// codeFileListLabel
			// 
			this.codeFileListLabel.AutoSize = true;
			this.codeFileListLabel.Location = new System.Drawing.Point(12, 54);
			this.codeFileListLabel.Name = "codeFileListLabel";
			this.codeFileListLabel.Size = new System.Drawing.Size(89, 12);
			this.codeFileListLabel.TabIndex = 4;
			this.codeFileListLabel.Text = "代码文件列表：";
			// 
			// lineCountTitle
			// 
			this.lineCountTitle.AutoSize = true;
			this.lineCountTitle.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lineCountTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.lineCountTitle.Location = new System.Drawing.Point(12, 282);
			this.lineCountTitle.Name = "lineCountTitle";
			this.lineCountTitle.Size = new System.Drawing.Size(91, 14);
			this.lineCountTitle.TabIndex = 0;
			this.lineCountTitle.Text = "总代码行数：";
			// 
			// lineCountResult
			// 
			this.lineCountResult.AutoSize = true;
			this.lineCountResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lineCountResult.ForeColor = System.Drawing.Color.DarkViolet;
			this.lineCountResult.Location = new System.Drawing.Point(96, 282);
			this.lineCountResult.Name = "lineCountResult";
			this.lineCountResult.Size = new System.Drawing.Size(0, 14);
			this.lineCountResult.TabIndex = 0;
			// 
			// copyLineCount
			// 
			this.copyLineCount.Location = new System.Drawing.Point(300, 277);
			this.copyLineCount.Name = "copyLineCount";
			this.copyLineCount.Size = new System.Drawing.Size(75, 23);
			this.copyLineCount.TabIndex = 2;
			this.copyLineCount.Text = "复制行数";
			this.copyLineCount.UseVisualStyleBackColor = true;
			this.copyLineCount.Click += new System.EventHandler(this.copyLineCount_Click);
			// 
			// readingStatusLabel
			// 
			this.readingStatusLabel.AutoSize = true;
			this.readingStatusLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.readingStatusLabel.ForeColor = System.Drawing.Color.Red;
			this.readingStatusLabel.Location = new System.Drawing.Point(4, 308);
			this.readingStatusLabel.Name = "readingStatusLabel";
			this.readingStatusLabel.Size = new System.Drawing.Size(59, 12);
			this.readingStatusLabel.TabIndex = 0;
			this.readingStatusLabel.Text = "读取中...";
			this.readingStatusLabel.Visible = false;
			// 
			// dirPath
			// 
			this.dirPath.Location = new System.Drawing.Point(86, 18);
			this.dirPath.Name = "dirPath";
			this.dirPath.ReadOnly = true;
			this.dirPath.Size = new System.Drawing.Size(188, 21);
			this.dirPath.TabIndex = 1;
			// 
			// excludeButton
			// 
			this.excludeButton.Location = new System.Drawing.Point(279, 45);
			this.excludeButton.Name = "excludeButton";
			this.excludeButton.Size = new System.Drawing.Size(96, 23);
			this.excludeButton.TabIndex = 2;
			this.excludeButton.Text = "排除扫描列表";
			this.excludeButton.UseVisualStyleBackColor = true;
			this.excludeButton.Click += new System.EventHandler(this.excludeButton_Click);
			// 
			// MainGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 325);
			this.Controls.Add(this.codeFileListLabel);
			this.Controls.Add(this.dirPath);
			this.Controls.Add(this.excludeButton);
			this.Controls.Add(this.copyLineCount);
			this.Controls.Add(this.openDir);
			this.Controls.Add(this.lineCountResult);
			this.Controls.Add(this.readingStatusLabel);
			this.Controls.Add(this.lineCountTitle);
			this.Controls.Add(this.openDirLabel);
			this.Controls.Add(this.resultTreeView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainGUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "工程代码行数读取";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label openDirLabel;
		private System.Windows.Forms.Button openDir;
		private System.Windows.Forms.TreeView resultTreeView;
		private System.Windows.Forms.Label codeFileListLabel;
		private System.Windows.Forms.ImageList treeViewIcons;
		private System.Windows.Forms.Label lineCountTitle;
		private System.Windows.Forms.Label lineCountResult;
		private System.Windows.Forms.Button copyLineCount;
		private System.Windows.Forms.Label readingStatusLabel;
		private System.Windows.Forms.TextBox dirPath;
		private System.Windows.Forms.Button excludeButton;
	}
}

