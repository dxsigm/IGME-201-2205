using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using LabelTextbox;

namespace LabelTextboxTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private LabelTextbox.ctlLabelTextbox myControl;
		private System.Windows.Forms.Button button1;
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
            myControl.PositionChanged += new EventHandler(this.myControl_PositionChanged);
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
			this.button1 = new System.Windows.Forms.Button();
			this.myControl = new LabelTextbox.ctlLabelTextbox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(104, 240);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// myControl
			// 
			this.myControl.LabelText = "MyLabel";
			this.myControl.Name = "myControl";
			this.myControl.Position = LabelTextbox.ctlLabelTextbox.PositionEnum.Right;
			this.myControl.Size = new System.Drawing.Size(150, 33);
			this.myControl.TabIndex = 0;
			this.myControl.TextboxMargin = 0;
			this.myControl.TextboxText = "MyText";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.myControl,
																	      this.button1});
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (myControl.Position == LabelTextbox.ctlLabelTextbox.PositionEnum.Below)
			{
               myControl.Position = LabelTextbox.ctlLabelTextbox.PositionEnum.Right;
		    } else {
               myControl.Position = LabelTextbox.ctlLabelTextbox.PositionEnum.Below;
			}
        }

        private void myControl_PositionChanged(object sender, EventArgs e)
        {
           MessageBox.Show("Changed");
        }
	}
}
