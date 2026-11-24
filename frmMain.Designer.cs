
namespace WF_Controls_ListboxEx
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lbItems = new System.Windows.Forms.ListBox();
			btAdd = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			tbItem = new System.Windows.Forms.TextBox();
			SuspendLayout();
			// 
			// lbItems
			// 
			lbItems.ItemHeight = 15;
			lbItems.Items.AddRange(new object[] { "first", "second", "third" });
			lbItems.Location = new System.Drawing.Point(9, 20);
			lbItems.Name = "lbItems";
			lbItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			lbItems.Size = new System.Drawing.Size(183, 139);
			lbItems.TabIndex = 0;
			lbItems.SelectedIndexChanged += lbItems_SelectedIndexChanged;
			// 
			// btAdd
			// 
			btAdd.Location = new System.Drawing.Point(201, 20);
			btAdd.Name = "btAdd";
			btAdd.Size = new System.Drawing.Size(90, 28);
			btAdd.TabIndex = 1;
			btAdd.Text = "Add new items";
			btAdd.Click += btAdd_Click;
			// 
			// label1
			// 
			label1.Location = new System.Drawing.Point(9, 217);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(154, 28);
			label1.TabIndex = 2;
			label1.Text = "Selected item";
			// 
			// tbItem
			// 
			tbItem.Location = new System.Drawing.Point(163, 217);
			tbItem.Name = "tbItem";
			tbItem.Size = new System.Drawing.Size(173, 23);
			tbItem.TabIndex = 3;
			// 
			// frmMain
			// 
			AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			ClientSize = new System.Drawing.Size(350, 255);
			Controls.Add(tbItem);
			Controls.Add(label1);
			Controls.Add(btAdd);
			Controls.Add(lbItems);
			Name = "frmMain";
			Text = "Using the ListBox component";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ListBox lbItems;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbItem;

	}
}

