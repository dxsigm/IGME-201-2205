using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestOpen
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.ListBox listBox1;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
         

         
         if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
         {
            foreach (string s in this.openFileDialog1.FileNames)
            {
               this.listBox1.Items.Add(s);
            }
         }

         this.textBox1.Text = this.openFileDialog1.FileName;


         
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
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.listBox1 = new System.Windows.Forms.ListBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
         this.SuspendLayout();
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.Multiselect = true;
         // 
         // listBox1
         // 
         this.listBox1.Location = new System.Drawing.Point(8, 32);
         this.listBox1.Name = "listBox1";
         this.listBox1.Size = new System.Drawing.Size(272, 121);
         this.listBox1.TabIndex = 0;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(16, 184);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(264, 20);
         this.textBox1.TabIndex = 1;
         this.textBox1.Text = "textBox1";
         // 
         // printPreviewDialog1
         // 
         this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
         this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
         this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
         this.printPreviewDialog1.Enabled = true;
         this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
         this.printPreviewDialog1.MaximumSize = new System.Drawing.Size(0, 0);
         this.printPreviewDialog1.Name = "printPreviewDialog1";
         this.printPreviewDialog1.Opacity = 1;
         this.printPreviewDialog1.TransparencyKey = System.Drawing.Color.Empty;
         this.printPreviewDialog1.Visible = false;
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.textBox1,
                                                                      this.listBox1});
         this.Name = "Form1";
         this.Text = "Form1";
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
	}
}
