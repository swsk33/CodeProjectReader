using System.Windows.Forms;

namespace CodeLineReader
{
	public partial class TextEdit : Form
	{

		private string value;

		/// <summary>
		/// 在窗口输入的值
		/// </summary>
		public string Value { get => value; set => this.value = value; }

		public TextEdit()
		{
			InitializeComponent();
		}

		public void ShowTextDialog()
		{
			ShowDialog();
		}

		private void ok_Click(object sender, System.EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Value = valueBox.Text;
			Close();
		}
	}
}