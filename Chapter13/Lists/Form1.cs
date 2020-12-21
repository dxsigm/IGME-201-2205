/// <Author>Jacob Hammer Pedersen</Author>
/// <Copyright>Wrox Press Ltd</Copyright>
/// <WWW>http://www.wrox.com</WWW>

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace My_Lists
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.CheckedListBox chkListPossibleValues;
		private System.Windows.Forms.ListBox lstSelected;
		private System.Windows.Forms.Button btnMove;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components=null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Fill the checked list box
		
			this.chkListPossibleValues.Items.Add("Ten");
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
         this.lstSelected = new System.Windows.Forms.ListBox();
         this.btnMove = new System.Windows.Forms.Button();
         this.chkListPossibleValues = new System.Windows.Forms.CheckedListBox();
         this.SuspendLayout();
         // 
         // lstSelected
         // 
         this.lstSelected.Location = new System.Drawing.Point(232, 8);
         this.lstSelected.Name = "lstSelected";
         this.lstSelected.Size = new System.Drawing.Size(136, 186);
         this.lstSelected.TabIndex = 1;
         // 
         // btnMove
         // 
         this.btnMove.Location = new System.Drawing.Point(152, 80);
         this.btnMove.Name = "btnMove";
         this.btnMove.TabIndex = 3;
         this.btnMove.Text = "Move";
         this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
         // 
         // chkListPossibleValues
         // 
         this.chkListPossibleValues.CheckOnClick = true;
         this.chkListPossibleValues.Items.AddRange(new object[] {
                                                                   "One",
                                                                   "Two",
                                                                   "Three",
                                                                   "Four",
                                                                   "Five",
                                                                   "Six",
                                                                   "Seven",
                                                                   "Eight",
                                                                   "Nine"});
         this.chkListPossibleValues.Location = new System.Drawing.Point(8, 8);
         this.chkListPossibleValues.Name = "chkListPossibleValues";
         this.chkListPossibleValues.Size = new System.Drawing.Size(136, 184);
         this.chkListPossibleValues.TabIndex = 0;
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(376, 205);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.btnMove,
                                                                      this.lstSelected,
                                                                      this.chkListPossibleValues});
         this.Name = "Form1";
         this.Text = "List Boxes";
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

		private void btnMove_Click(object sender, System.EventArgs e)
		{
			// Check if there are any checked items in the checked list box
			if (this.chkListPossibleValues.CheckedItems.Count > 0)
			{
				// Clear the list box we'll move the selections to
				this.lstSelected.Items.Clear();

				// Loop through the CheckedItems collection of the checked list box
				// and add the items in the Selected list box
				foreach (string item in this.chkListPossibleValues.CheckedItems)
				{
					this.lstSelected.Items.Add(item.ToString());
				}

				// Clear all the checks in the checked list box
				for (int i = 0; i < this.chkListPossibleValues.Items.Count; i++)
					this.chkListPossibleValues.SetItemChecked(i, false);
			}
		}
	}
}
