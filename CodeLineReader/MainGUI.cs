using Swsk33.ReadAndWriteSharp.FileUtil;
using Swsk33.ReadAndWriteSharp.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CodeLineReader
{
	public partial class MainGUI : Form
	{
		public MainGUI()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 判断TreeView中某个节点下是否包含某节点，若包含则返回该节点，否则返回null
		/// </summary>
		/// <param name="node">节点</param>
		/// <param name="text">判断节点文字</param>
		/// <returns>若包含则返回该节点，否则返回null</returns>
		private TreeNode isTreeNodeContains(TreeNode node, string text)
		{
			foreach (TreeNode subNode in node.Nodes)
			{
				if (subNode.Text.Equals(text))
				{
					return subNode;
				}
			}
			return null;
		}

		private void openDir_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "请选择你的代码工程目录";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				int totalLines = 0;
				readingStatusLabel.Visible = true;
				Application.DoEvents();
				string filePath = dialog.SelectedPath;
				dirPath.Text = filePath;
				// 开始执行读取操作
				List<string> files = new List<string>();
				string[] getFiles = DirectoryUtils.GetAllFilesInDirectory(filePath);
				// 执行遍历并加入到treeview
				TreeNode rootNode = resultTreeView.Nodes[0];
				rootNode.Nodes.Clear();
				foreach (string file in getFiles)
				{
					// 判断是否是二进制文件
					if (!BinaryUtils.IsBinaryFile(file))
					{
						// 先读取文本行数
						totalLines = totalLines + TextFileReader.GetFileLine(file);
						string relativePath = file.Replace(filePath + "\\", "");
						string[] filePathPatterns = relativePath.Split('\\');
						// 当前节点，从treeView根节点开始
						TreeNode currentNode = rootNode;
						// 解析路径加入到目录树
						foreach (string pattern in filePathPatterns)
						{
							// 如果当前路径在指定树状结构已存在则索引上去，否则加入
							TreeNode subNode = isTreeNodeContains(currentNode, pattern);
							if (subNode == null)
							{
								subNode = new TreeNode();
								subNode.Text = pattern;
								if (Array.IndexOf(filePathPatterns, pattern) == filePathPatterns.Length - 1)
								{
									subNode.ImageIndex = 2;
									subNode.SelectedImageIndex = 2;
								}
								currentNode.Nodes.Add(subNode);
							}
							currentNode = subNode;
						}
					}
				}
				readingStatusLabel.Visible = false;
				lineCountResult.Text = totalLines.ToString();
				rootNode.Expand();
				Application.DoEvents();
			}
		}

		private void copyLineCount_Click(object sender, System.EventArgs e)
		{
			if (StringUtils.IsEmpty(lineCountResult.Text))
			{
				MessageBox.Show("请先浏览一个文件夹！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Clipboard.SetText(lineCountResult.Text);
			MessageBox.Show("复制完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void resultTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Node.Nodes.Count == 0)
			{
				string filePath = dirPath.Text + "\\" + e.Node.FullPath.Replace(resultTreeView.Nodes[0].Text, "");
				new FileReader(filePath).Show();
			}
		}
	}
}