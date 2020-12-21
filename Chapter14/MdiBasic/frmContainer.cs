using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MdiBasic
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmContainer : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmContainer()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
         MdiBasic.frmChild child = new MdiBasic.frmChild(this);

         // Show the form
         child.Show();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
         // 
         // frmContainer
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.IsMdiContainer = true;
         this.Name = "frmContainer";
         this.Text = "MDI Basic";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmContainer());
		}
	}
}
