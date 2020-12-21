/// <Author>Jacob Hammer Pedersen</Author>
/// <Copyright>Wrox Press Ltd</Copyright>
/// <WWW>http://www.wrox.com</WWW>

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ButtonTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnEnglish;
		private System.Windows.Forms.Button btnDanish;
		private System.Windows.Forms.Button btnOK;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.btnOK = new System.Windows.Forms.Button();
			this.btnEnglish = new System.Windows.Forms.Button();
			this.btnDanish = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(56, 48);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(88, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnEnglish
			// 
			this.btnEnglish.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnEnglish.Image")));
			this.btnEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEnglish.Location = new System.Drawing.Point(8, 8);
			this.btnEnglish.Name = "btnEnglish";
			this.btnEnglish.Size = new System.Drawing.Size(88, 23);
			this.btnEnglish.TabIndex = 0;
			this.btnEnglish.Text = "English";
			this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
			// 
			// btnDanish
			// 
			this.btnDanish.Image = ((System.Drawing.Bitmap)(resources.GetObject("btnDanish.Image")));
			this.btnDanish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDanish.Location = new System.Drawing.Point(104, 8);
			this.btnDanish.Name = "btnDanish";
			this.btnDanish.Size = new System.Drawing.Size(88, 23);
			this.btnDanish.TabIndex = 1;
			this.btnDanish.Text = "Danish";
			this.btnDanish.Click += new System.EventHandler(this.btnDanish_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(200, 85);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {this.btnOK,
																																	this.btnDanish,
																																	this.btnEnglish});
			this.Name = "Form1";
			this.Text = "Do you speak English?";
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

		private void btnEnglish_Click(object sender, System.EventArgs e)
		{
			this.Text = "Do you speak English?";
		}

		private void btnDanish_Click(object sender, System.EventArgs e)
		{
			this.Text = "Taler du dansk?";
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
