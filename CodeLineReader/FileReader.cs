using System;
using System.IO;
using System.Windows.Forms;

namespace CodeLineReader
{
	public partial class FileReader : Form
	{
		public FileReader(string filePath)
		{
			InitializeComponent();
			content.Text = File.ReadAllText(filePath);
			content.Select(0, 0);
		}

		private void copyCode_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(content.Text);
			MessageBox.Show("复制完成！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}