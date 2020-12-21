/// <Author>Jacob Hammer Pedersen</Author>
/// <Copyright>Wrox Press Ltd</Copyright>
/// <WWW>http://www.wrox.com</WWW>

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace ListView
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		// Member field to hold previous folders
		private System.Collections.Specialized.StringCollection folderCol;		
		
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.RadioButton rdoLarge;
		private System.Windows.Forms.RadioButton rdoSmall;
		private System.Windows.Forms.RadioButton rdoList;
		private System.Windows.Forms.RadioButton rdoDetails;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ImageList ilLarge;
		private System.Windows.Forms.ImageList ilSmall;
		private System.Windows.Forms.ListView lwFilesAndFolders;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.StatusBar sbInfo;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Init ListView and folder collection
			folderCol = new System.Collections.Specialized.StringCollection();
			CreateHeadersAndFillListView();
			PaintListView(@"C:\");
			folderCol.Add(@"C:\");

			this.lwFilesAndFolders.ItemActivate += new System.EventHandler(this.lwFilesAndFolders_ItemActivate);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.rdoDetails = new System.Windows.Forms.RadioButton();
			this.sbInfo = new System.Windows.Forms.StatusBar();
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
			this.rdoList = new System.Windows.Forms.RadioButton();
			this.rdoLarge = new System.Windows.Forms.RadioButton();
			this.btnBack = new System.Windows.Forms.Button();
			this.ilLarge = new System.Windows.Forms.ImageList(this.components);
			this.rdoSmall = new System.Windows.Forms.RadioButton();
			this.ilSmall = new System.Windows.Forms.ImageList(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lwFilesAndFolders = new System.Windows.Forms.ListView();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rdoDetails
			// 
			this.rdoDetails.Location = new System.Drawing.Point(8, 96);
			this.rdoDetails.Name = "rdoDetails";
			this.rdoDetails.Size = new System.Drawing.Size(104, 16);
			this.rdoDetails.TabIndex = 3;
			this.rdoDetails.Text = "Details";
			this.rdoDetails.CheckedChanged += new System.EventHandler(this.rdoDetails_CheckedChanged);
			// 
			// sbInfo
			// 
			this.sbInfo.Location = new System.Drawing.Point(0, 277);
			this.sbInfo.Name = "sbInfo";
			this.sbInfo.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
																																							this.statusBarPanel1,
																																							this.statusBarPanel2});
			this.sbInfo.ShowPanels = true;
			this.sbInfo.Size = new System.Drawing.Size(552, 16);
			this.sbInfo.TabIndex = 3;
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.statusBarPanel1.Width = 526;
			// 
			// statusBarPanel2
			// 
			this.statusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.statusBarPanel2.MinWidth = 0;
			this.statusBarPanel2.Width = 10;
			// 
			// rdoList
			// 
			this.rdoList.Checked = true;
			this.rdoList.Location = new System.Drawing.Point(8, 72);
			this.rdoList.Name = "rdoList";
			this.rdoList.Size = new System.Drawing.Size(104, 16);
			this.rdoList.TabIndex = 2;
			this.rdoList.TabStop = true;
			this.rdoList.Text = "List";
			this.rdoList.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
			// 
			// rdoLarge
			// 
			this.rdoLarge.Location = new System.Drawing.Point(8, 24);
			this.rdoLarge.Name = "rdoLarge";
			this.rdoLarge.Size = new System.Drawing.Size(96, 16);
			this.rdoLarge.TabIndex = 0;
			this.rdoLarge.Text = "LargeIcon";
			this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoLarge_CheckedChanged);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(240, 240);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 1;
			this.btnBack.Text = "Back";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// ilLarge
			// 
			this.ilLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ilLarge.ImageSize = new System.Drawing.Size(32, 32);
			this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
			this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// rdoSmall
			// 
			this.rdoSmall.Location = new System.Drawing.Point(8, 48);
			this.rdoSmall.Name = "rdoSmall";
			this.rdoSmall.Size = new System.Drawing.Size(104, 16);
			this.rdoSmall.TabIndex = 1;
			this.rdoSmall.Text = "SmallIcon";
			this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
			// 
			// ilSmall
			// 
			this.ilSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ilSmall.ImageSize = new System.Drawing.Size(16, 16);
			this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
			this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.rdoDetails,
																																						this.rdoList,
																																						this.rdoSmall,
																																						this.rdoLarge});
			this.groupBox1.Location = new System.Drawing.Point(424, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(120, 128);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "View mode";
			// 
			// lwFilesAndFolders
			// 
			this.lwFilesAndFolders.LargeImageList = this.ilLarge;
			this.lwFilesAndFolders.Location = new System.Drawing.Point(16, 8);
			this.lwFilesAndFolders.MultiSelect = false;
			this.lwFilesAndFolders.Name = "lwFilesAndFolders";
			this.lwFilesAndFolders.Size = new System.Drawing.Size(400, 216);
			this.lwFilesAndFolders.SmallImageList = this.ilSmall;
			this.lwFilesAndFolders.TabIndex = 0;
			this.lwFilesAndFolders.View = System.Windows.Forms.View.List;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 293);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.sbInfo,
																																	this.groupBox1,
																																	this.btnBack,
																																	this.lwFilesAndFolders});
			this.Name = "Form1";
			this.Text = "StatusBar";
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void CreateHeadersAndFillListView()
		{
			ColumnHeader colHead;

			// First header
			colHead = new ColumnHeader();
			colHead.Text = "Filename";
			this.lwFilesAndFolders.Columns.Add(colHead); // Insert the header

			// Second header
			colHead = new ColumnHeader();
			colHead.Text = "Size";
			this.lwFilesAndFolders.Columns.Add(colHead); // Insert the header

			// Third header
			colHead = new ColumnHeader();
			colHead.Text = "Last accessed";
			this.lwFilesAndFolders.Columns.Add(colHead); // Insert the header
		}

		private void PaintListView(string root)
		{
			try
			{
				// Two local variables that is used to create the items to insert
				ListViewItem lvi;
				ListViewItem.ListViewSubItem lvsi;

				// If there's no root folder, we can't insert anything
				if (root.CompareTo("") == 0)
					return;

				this.sbInfo.Panels[0].Text = root;

				// Get information about the root folder.
				System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(root);
			
				// Retrieve the files and folders from the root folder.
				DirectoryInfo[] dirs = dir.GetDirectories(); // Folders
				FileInfo[] files = dir.GetFiles(); // Files

				// Clear the ListView. Note that we call the Clear method on the Items collection
				// rather than on the ListView itself. The Clear method of the ListView remove
				// everything, including column headers, and we only want to remove the items from
				// the view.
				this.lwFilesAndFolders.Items.Clear();

				// Lock the ListView for updates
				this.lwFilesAndFolders.BeginUpdate();

				// Loop throug all folders in the root folder and insert them
				foreach (System.IO.DirectoryInfo di in dirs)
				{
					// Create the main ListViewItem
					lvi = new ListViewItem();
					lvi.Text = di.Name; // Folder name
					lvi.ImageIndex = 0; // The folder icon has index 0
					lvi.Tag = di.FullName; // Set the tag to the qualified path of the folder

					// Create the two ListViewSubItems.
					lvsi = new ListViewItem.ListViewSubItem();
					lvsi.Text = ""; // Size - a folder has no size and so this column is empty
					lvi.SubItems.Add(lvsi); // Add the sub item to the ListViewItem

					lvsi = new ListViewItem.ListViewSubItem();
					lvsi.Text = di.LastAccessTime.ToString(); // Last accessed column
					lvi.SubItems.Add(lvsi); // Add the sub item to the ListViewItem

					// Add the ListViewItem to the Items collection of the ListView
					this.lwFilesAndFolders.Items.Add(lvi);
				}

				// Loop through all the files in the root folder
				foreach (System.IO.FileInfo fi in files)
				{
					// Create the main ListViewItem
					lvi = new ListViewItem();
					lvi.Text = fi.Name; // Filename
					lvi.ImageIndex = 1; // The icon we use to represent a folder has index 1
					lvi.Tag = fi.FullName; // Set the tag to the qualified path of the file

					// Create the two sub items
					lvsi = new ListViewItem.ListViewSubItem();
					lvsi.Text = fi.Length.ToString(); // Length of the file
					lvi.SubItems.Add(lvsi); // Add to the SubItems collection

					lvsi = new ListViewItem.ListViewSubItem();
					lvsi.Text = fi.LastAccessTime.ToString(); // Last Accessed Column
					lvi.SubItems.Add(lvsi); // Add to the SubItems collection

					// Add the item to the Items collection of the ListView
					this.lwFilesAndFolders.Items.Add(lvi);
				}

				// Unlock the ListView. The items that have been inserted will now be displayed
				this.lwFilesAndFolders.EndUpdate();
			}
			catch (System.Exception err)
			{
				MessageBox.Show("Error: " + err.Message);
			}
		}

		private void lwFilesAndFolders_ItemActivate(object sender, System.EventArgs e)
		{
			// Cast the sender to a ListView and get the tag of the first selected item.
			System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
			string filename = lw.SelectedItems[0].Tag.ToString();

			if (lw.SelectedItems[0].ImageIndex != 0)
			{
				try
				{
					// Attempt to run the file
					System.Diagnostics.Process.Start(filename);
				}
				catch
				{
					// If the attempt fails we simply exit the method
					return;
				}
			}
			else
			{
				// Insert the items
				PaintListView(filename);
				folderCol.Add(filename);
			}
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			if (folderCol.Count > 1) 
			{
				PaintListView(folderCol[folderCol.Count-2].ToString());
				folderCol.RemoveAt(folderCol.Count-1);
			}
			else
			{
				PaintListView(folderCol[0].ToString());
			}
		}

		private void rdoLarge_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton rdb = (RadioButton)sender;
			if (rdb.Checked)
			{
				this.lwFilesAndFolders.View = View.LargeIcon;
				this.sbInfo.Panels[1].Text = "Large Icon";
			}
		}

		private void rdoList_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton rdb = (RadioButton)sender;
			if (rdb.Checked)
			{
				this.lwFilesAndFolders.View = View.List;
				this.sbInfo.Panels[1].Text = "List";
			}
		}

		private void rdoSmall_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton rdb = (RadioButton)sender;
			if (rdb.Checked)
			{
				this.lwFilesAndFolders.View = View.SmallIcon;
				this.sbInfo.Panels[1].Text = "Small Icon";
			}
		}

		private void rdoDetails_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton rdb = (RadioButton)sender;
			if (rdb.Checked)
			{
				this.lwFilesAndFolders.View = View.Details;
				this.sbInfo.Panels[1].Text = "Details";
			}
		}
	}
}
