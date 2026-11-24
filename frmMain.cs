using System.Windows.Forms;

namespace WF_Controls_ListboxEx
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		private void btAdd_Click(object sender, System.EventArgs e)
		{
			string[] names = { "Apple", "Pear", "Banana", "Orange" };
			lbItems.Items.AddRange(names);
		}

		private void lbItems_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			tbItem.Text = (string)lbItems.SelectedItem;
		}

	}
}
