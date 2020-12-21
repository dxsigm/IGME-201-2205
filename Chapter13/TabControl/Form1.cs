using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TabControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.Button btnShowMessage;
      private System.Windows.Forms.TextBox txtMessage;
      private System.Windows.Forms.ComboBox comboBox1;
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
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.btnShowMessage = new System.Windows.Forms.Button();
         this.txtMessage = new System.Windows.Forms.TextBox();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         this.SuspendLayout();
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                                  this.tabPage1,
                                                                                  this.tabPage2});
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(280, 216);
         this.tabControl1.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                               this.comboBox1,
                                                                               this.btnShowMessage});
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Size = new System.Drawing.Size(272, 190);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Tab One";
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                               this.txtMessage});
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Size = new System.Drawing.Size(272, 190);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Tab Two";
         // 
         // btnShowMessage
         // 
         this.btnShowMessage.Location = new System.Drawing.Point(76, 84);
         this.btnShowMessage.Name = "btnShowMessage";
         this.btnShowMessage.Size = new System.Drawing.Size(120, 23);
         this.btnShowMessage.TabIndex = 1;
         this.btnShowMessage.Text = "Show Message";
         // 
         // txtMessage
         // 
         this.txtMessage.Location = new System.Drawing.Point(56, 56);
         this.txtMessage.Name = "txtMessage";
         this.txtMessage.TabIndex = 0;
         this.txtMessage.Text = "";
         // 
         // comboBox1
         // 
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(121, 21);
         this.comboBox1.TabIndex = 2;
         this.comboBox1.Text = "comboBox1";
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.tabControl1});
         this.Name = "Form1";
         this.Text = "Form1";
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage2.ResumeLayout(false);
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
