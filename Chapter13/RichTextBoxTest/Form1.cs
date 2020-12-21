/// <Author>Jacob Hammer Pedersen</Author>
/// <Copyright>Wrox Press Ltd</Copyright>
/// <WWW>http://www.wrox.com</WWW>

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RichTextBoxTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnBold;
		private System.Windows.Forms.Button btnItalic;
		private System.Windows.Forms.Button btnUnderline;
		private System.Windows.Forms.Button btnCenter;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.RichTextBox rtfText;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components;

		public Form1()
		{
			InitializeComponent();

			// Event Subscription
			this.txtSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
			this.txtSize.Validating += new System.ComponentModel.CancelEventHandler(this.txtSize_Validating);
			this.rtfText.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtfText_LinkedClick);
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
			this.rtfText = new System.Windows.Forms.RichTextBox();
			this.lblSize = new System.Windows.Forms.Label();
			this.txtSize = new System.Windows.Forms.TextBox();
			this.btnCenter = new System.Windows.Forms.Button();
			this.btnItalic = new System.Windows.Forms.Button();
			this.btnBold = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUnderline = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtfText
			// 
			this.rtfText.Location = new System.Drawing.Point(0, 64);
			this.rtfText.Name = "rtfText";
			this.rtfText.Size = new System.Drawing.Size(480, 168);
			this.rtfText.TabIndex = 8;
			this.rtfText.Text = "";
			// 
			// lblSize
			// 
			this.lblSize.Location = new System.Drawing.Point(196, 40);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(40, 16);
			this.lblSize.TabIndex = 6;
			this.lblSize.Text = "Size";
			// 
			// txtSize
			// 
			this.txtSize.Location = new System.Drawing.Point(244, 40);
			this.txtSize.Name = "txtSize";
			this.txtSize.Size = new System.Drawing.Size(40, 20);
			this.txtSize.TabIndex = 7;
			this.txtSize.Text = "8";
			// 
			// btnCenter
			// 
			this.btnCenter.Location = new System.Drawing.Point(335, 8);
			this.btnCenter.Name = "btnCenter";
			this.btnCenter.TabIndex = 3;
			this.btnCenter.Text = "Center";
			this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
			// 
			// btnItalic
			// 
			this.btnItalic.Location = new System.Drawing.Point(159, 8);
			this.btnItalic.Name = "btnItalic";
			this.btnItalic.TabIndex = 1;
			this.btnItalic.Text = "Italic";
			this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
			// 
			// btnBold
			// 
			this.btnBold.Location = new System.Drawing.Point(71, 8);
			this.btnBold.Name = "btnBold";
			this.btnBold.TabIndex = 0;
			this.btnBold.Text = "Bold";
			this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(251, 240);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUnderline
			// 
			this.btnUnderline.Location = new System.Drawing.Point(247, 8);
			this.btnUnderline.Name = "btnUnderline";
			this.btnUnderline.TabIndex = 2;
			this.btnUnderline.Text = "Underline";
			this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(155, 240);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.TabIndex = 4;
			this.btnLoad.Text = "Load";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.rtfText,
																																	this.txtSize,
																																	this.lblSize,
																																	this.btnSave,
																																	this.btnLoad,
																																	this.btnCenter,
																																	this.btnUnderline,
																																	this.btnItalic,
																																	this.btnBold});
			this.Name = "Form1";
			this.Text = "RichTextBox Test";
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

		private void btnBold_Click(object sender, System.EventArgs e)
		{
			Font oldFont;
			Font newFont;
				
			// Get the font that is being used in the selected text
			oldFont = this.rtfText.SelectionFont;

			// If the font is using bold style at the moment, we should remove it
			if (oldFont.Bold)
				newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
			else
				newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);

			// Insert the new font
			this.rtfText.SelectionFont = newFont;
			this.rtfText.Focus();
		}

		private void btnItalic_Click(object sender, System.EventArgs e)
		{
			Font oldFont;
			Font newFont;
				
				
			// Get the font that is being used in the selected text
			oldFont = this.rtfText.SelectionFont;

			// If the font is using bold style at the moment, we should remove it
			if (this.rtfText.SelectionFont.Italic)
				newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
			else
				newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

			// Insert the new font
			this.rtfText.SelectionFont = newFont;
			this.rtfText.Focus();
		}

		private void btnUnderline_Click(object sender, System.EventArgs e)
		{
			Font oldFont;
			Font newFont;
				
			// Get the font that is being used in the selected text
			oldFont = this.rtfText.SelectionFont;
			
			// If the font is using bold style at the moment, we should remove it
			if (this.rtfText.SelectionFont.Underline)
				newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
			else
				newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

			// Insert the new font
			this.rtfText.SelectionFont = newFont;
			this.rtfText.Focus();
		}

		private void btnCenter_Click(object sender, System.EventArgs e)
		{
			if (this.rtfText.SelectionAlignment == HorizontalAlignment.Center)
				this.rtfText.SelectionAlignment = HorizontalAlignment.Left;
			else
				this.rtfText.SelectionAlignment = HorizontalAlignment.Center;
			this.rtfText.Focus();
		}

		private void txtSize_KeyPress(object sender, 
			System.Windows.Forms.KeyPressEventArgs e)
		{
			// Remove all characters that are not numbers, backspace and enter
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
			{
				e.Handled = true;
			}
			else if (e.KeyChar == 13)
			{
				// Apply size if the user hits enter
				TextBox txt = (TextBox)sender;

				if (txt.Text.Length > 0)
					ApplyTextSize(txt.Text);
				e.Handled = true;
				this.rtfText.Focus();
			}
		}

		private void txtSize_Validating(object sender,
			System.ComponentModel.CancelEventArgs e)
		{
			TextBox txt = (TextBox)sender;

			ApplyTextSize(txt.Text);
			this.rtfText.Focus();
		}

		private void ApplyTextSize(string textSize)
		{
			float newSize = Convert.ToSingle(textSize);
			FontFamily currentFontFamily;
			Font newFont;

			currentFontFamily = this.rtfText.SelectionFont.FontFamily;
			newFont = new Font(currentFontFamily, newSize);
			this.rtfText.SelectionFont = newFont;
		}

		private void rtfText_LinkedClick(object sender, System.Windows.Forms.LinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(e.LinkText);
		}

		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			try
			{
				rtfText.LoadFile(@"../../Test.rtf");
			}
			catch (System.IO.FileNotFoundException)
			{
				MessageBox.Show("No file to load yet");
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				rtfText.SaveFile(@"../../Test.rtf");
			}
			catch (System.Exception err)
			{
				MessageBox.Show(err.Message);
			}
		}
	}
}
