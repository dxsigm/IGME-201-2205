/// <Author>Jacob Hammer Pedersen</Author>
/// <Copyright>Wrox Press Ltd</Copyright>
/// <WWW>http://www.wrox.com</WWW>

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestBoxTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label lblAge;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtOutput;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkProgrammer;
		private System.Windows.Forms.RadioButton rdoMale;
		private System.Windows.Forms.RadioButton rdoFemale;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.btnOK.Enabled = false;

			// Tag values for testing if the data is valid
			this.txtAddress.Tag = false;
			this.txtAge.Tag = false;
			this.txtName.Tag = false;

			// Subscriptions to events
			this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxEmpty_Validating);
			this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxEmpty_Validating);
			this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
			this.txtAge.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxEmpty_Validating);
			this.txtName.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			this.txtAddress.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
			this.txtAge.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdoMale = new System.Windows.Forms.RadioButton();
			this.rdoFemale = new System.Windows.Forms.RadioButton();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.lblAge = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.chkProgrammer = new System.Windows.Forms.CheckBox();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.lblOutput = new System.Windows.Forms.Label();
			this.btnHelp = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtName.Location = new System.Drawing.Point(112, 16);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(176, 20);
			this.txtName.TabIndex = 5;
			this.txtName.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																						this.rdoMale,
																																						this.rdoFemale});
			this.groupBox1.Location = new System.Drawing.Point(8, 136);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 40);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sex";
			// 
			// rdoMale
			// 
			this.rdoMale.Location = new System.Drawing.Point(152, 16);
			this.rdoMale.Name = "rdoMale";
			this.rdoMale.Size = new System.Drawing.Size(112, 16);
			this.rdoMale.TabIndex = 1;
			this.rdoMale.Text = "Male";
			// 
			// rdoFemale
			// 
			this.rdoFemale.Checked = true;
			this.rdoFemale.Location = new System.Drawing.Point(8, 16);
			this.rdoFemale.Name = "rdoFemale";
			this.rdoFemale.Size = new System.Drawing.Size(104, 16);
			this.rdoFemale.TabIndex = 0;
			this.rdoFemale.TabStop = true;
			this.rdoFemale.Text = "Female";
			// 
			// txtAddress
			// 
			this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtAddress.Location = new System.Drawing.Point(112, 40);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtAddress.Size = new System.Drawing.Size(176, 72);
			this.txtAddress.TabIndex = 6;
			this.txtAddress.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnOK.Location = new System.Drawing.Point(296, 16);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 10;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblAge
			// 
			this.lblAge.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.lblAge.Location = new System.Drawing.Point(8, 184);
			this.lblAge.Name = "lblAge";
			this.lblAge.Size = new System.Drawing.Size(92, 24);
			this.lblAge.TabIndex = 3;
			this.lblAge.Text = "Age";
			// 
			// txtAge
			// 
			this.txtAge.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtAge.Location = new System.Drawing.Point(112, 184);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(176, 20);
			this.txtAge.TabIndex = 8;
			this.txtAge.Text = "";
			// 
			// lblAddress
			// 
			this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.lblAddress.Location = new System.Drawing.Point(8, 40);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(92, 79);
			this.lblAddress.TabIndex = 1;
			this.lblAddress.Text = "Address";
			// 
			// chkProgrammer
			// 
			this.chkProgrammer.Location = new System.Drawing.Point(8, 112);
			this.chkProgrammer.Name = "chkProgrammer";
			this.chkProgrammer.Size = new System.Drawing.Size(280, 16);
			this.chkProgrammer.TabIndex = 12;
			this.chkProgrammer.Text = "Programmer";
			// 
			// txtOutput
			// 
			this.txtOutput.AcceptsReturn = true;
			this.txtOutput.AcceptsTab = true;
			this.txtOutput.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtOutput.Location = new System.Drawing.Point(0, 232);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOutput.Size = new System.Drawing.Size(376, 80);
			this.txtOutput.TabIndex = 9;
			this.txtOutput.Text = "";
			// 
			// lblOutput
			// 
			this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.lblOutput.Location = new System.Drawing.Point(8, 208);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(92, 24);
			this.lblOutput.TabIndex = 4;
			this.lblOutput.Text = "Output";
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.btnHelp.CausesValidation = false;
			this.btnHelp.Location = new System.Drawing.Point(296, 48);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.TabIndex = 11;
			this.btnHelp.Text = "Help";
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// lblName
			// 
			this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.lblName.Location = new System.Drawing.Point(8, 16);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(92, 79);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 309);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.groupBox1,
																																	this.chkProgrammer,
																																	this.btnHelp,
																																	this.btnOK,
																																	this.txtOutput,
																																	this.txtAge,
																																	this.txtAddress,
																																	this.txtName,
																																	this.lblOutput,
																																	this.lblAge,
																																	this.lblAddress,
																																	this.lblName});
			this.MinimumSize = new System.Drawing.Size(384, 280);
			this.Name = "Form1";
			this.Text = "Text Boxes, Check Boxes and Radio Buttons";
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

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			// No testing for invalid values are made, as that should
			// not be neccessary
 
			string output;

			// Concatenate the text values of the four TextBoxes
			output = "Name: " + this.txtName.Text + "\r\n";
			output += "Address: " + this.txtAddress.Text + "\r\n";
			output += "Occupation: " + (string)(this.chkProgrammer.Checked ? "Programmer" : "Not a programmer") + "\r\n";
			output += "Sex: " + (string)(this.rdoFemale.Checked ? "Female" : "Male") + "\r\n";
			output += "Age: " + this.txtAge.Text;

			// Insert the new text
			this.txtOutput.Text = output;
		}

		private void btnHelp_Click(object sender, System.EventArgs e)
		{
			// Write a short descrption of each TextBox in the Output TextBox
			string output;

			output = "Name = Your name\r\n";
			output += "Address = Your address\r\n";
			output += "Programmer = Check 'Programmer' if you are a programmer\r\n";
			output += "Sex = Choose your sex\r\n";
			output += "Age = Your age";

			// Insert the new text
			this.txtOutput.Text = output;
		}

		private void txtBoxEmpty_Validating(object sender, 
			System.ComponentModel.CancelEventArgs e)
		{
			TextBox tb;

			tb = (TextBox)sender;

			// If the text is empty we set the background color of the 
			// TextBox to red to indicate a problem. We use the tag value
			// of the control to indicate if the control contains valid
			// information.
			if (tb.Text.Length == 0)
			{
				tb.BackColor = Color.Red;
				tb.Tag = false;
			}
			else
			{
				tb.BackColor = System.Drawing.SystemColors.Window;
				tb.Tag = true;
			}

			// Finally we call ValidateAll which will set the value of
			// the OK button.
			ValidateAll();
		}

		private void ValidateAll()
		{
			// Set the OK button to enabled if all the Tags are true
			this.btnOK.Enabled = ((bool)(this.txtAddress.Tag) &&
				(bool)(this.txtAge.Tag) &&
				(bool)(this.txtName.Tag));
		}

		private void txtAge_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
				e.Handled = true; // Remove the character
		}

		private void txtBox_TextChanged(object sender, System.EventArgs e)
		{
			// Cast the sender object to a Textbox
			TextBox tb = (TextBox)sender;

			// Test if the data is valid and set the tag background
			// color accordingly.
			if (tb.Text.Length == 0)
			{
				tb.Tag = false;
				tb.BackColor = Color.Red;
			}
			else
			{
				tb.Tag = true;
				tb.BackColor = SystemColors.Window;
			}

			// Call ValidateAll to set the OK button
			ValidateAll();
		}
	}
}
