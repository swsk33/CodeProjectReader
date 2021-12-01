using System.Collections.Generic;
using System.Windows.Forms;

namespace CodeLineReader
{
	public partial class ExcludeDialog : Form
	{
		public ExcludeDialog()
		{
			InitializeComponent();
		}

		public void ShowExcludeDialog(List<string> excludeFileNames, List<string> excludeDirectoryNames)
		{
			excludeFileList.Items.Clear();
			excludeFileList.Items.AddRange(excludeFileNames.ToArray());
			excludeDirList.Items.Clear();
			excludeDirList.Items.AddRange(excludeDirectoryNames.ToArray());
			ShowDialog();
			excludeFileNames.Clear();
			foreach (string file in excludeFileList.Items)
			{
				excludeFileNames.Add(file);
			}
			excludeDirectoryNames.Clear();
			foreach (string file in excludeDirList.Items)
			{
				excludeDirectoryNames.Add(file);
			}
		}

		private void ok_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void addFile_Click(object sender, System.EventArgs e)
		{
			TextEdit dialog = new TextEdit();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				excludeFileList.Items.Add(dialog.Value);
			}
		}

		private void addDir_Click(object sender, System.EventArgs e)
		{
			TextEdit dialog = new TextEdit();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				excludeDirList.Items.Add(dialog.Value);
			}
		}

		private void removeFile_Click(object sender, System.EventArgs e)
		{
			if (excludeFileList.SelectedIndex < 0)
			{
				MessageBox.Show("请选中要从列表删除的文件名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			excludeFileList.Items.RemoveAt(excludeFileList.SelectedIndex);
		}

		private void removeDir_Click(object sender, System.EventArgs e)
		{
			if (excludeDirList.SelectedIndex < 0)
			{
				MessageBox.Show("请选中要从列表删除的文件夹名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			excludeDirList.Items.RemoveAt(excludeDirList.SelectedIndex);
		}
	}
}