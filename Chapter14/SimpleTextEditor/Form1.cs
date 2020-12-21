using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MenuExample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
      private System.Windows.Forms.MainMenu MainMenuFiles;
      private System.Windows.Forms.ContextMenu ContextMenuFonts;
      private System.Windows.Forms.MenuItem miFiles;
      private System.Windows.Forms.MenuItem miNew;
      private System.Windows.Forms.MenuItem miOpen;
      private System.Windows.Forms.MenuItem miSave;
      private System.Windows.Forms.MenuItem menuItem4;
      private System.Windows.Forms.MenuItem miExit;
      private System.Windows.Forms.MenuItem miBold;
      private System.Windows.Forms.MenuItem miItalic;
      private System.Windows.Forms.MenuItem miUnderline;
      private System.Windows.Forms.RichTextBox rtfText;
      private System.Windows.Forms.ImageList ImageListToolbar;
      private System.Windows.Forms.ToolBar toolBarFonts;
      private System.Windows.Forms.ToolBarButton toolBarButton1;
      private System.Windows.Forms.ToolBarButton toolBarButton2;
      private System.Windows.Forms.ToolBarButton toolBarButton3;
      private System.Windows.Forms.ToolBarButton toolBarButton4;
      private System.Windows.Forms.ToolBarButton toolBarButton5;
      private System.Windows.Forms.ContextMenu contextMenu1;
      private System.Windows.Forms.MenuItem menuItem1;
      private System.Windows.Forms.MenuItem menuItem2;
      private System.ComponentModel.IContainer components;

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
         this.components = new System.ComponentModel.Container();
         System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
         this.MainMenuFiles = new System.Windows.Forms.MainMenu();
         this.ContextMenuFonts = new System.Windows.Forms.ContextMenu();
         this.miFiles = new System.Windows.Forms.MenuItem();
         this.miNew = new System.Windows.Forms.MenuItem();
         this.miOpen = new System.Windows.Forms.MenuItem();
         this.miSave = new System.Windows.Forms.MenuItem();
         this.menuItem4 = new System.Windows.Forms.MenuItem();
         this.miExit = new System.Windows.Forms.MenuItem();
         this.miBold = new System.Windows.Forms.MenuItem();
         this.miItalic = new System.Windows.Forms.MenuItem();
         this.miUnderline = new System.Windows.Forms.MenuItem();
         this.rtfText = new System.Windows.Forms.RichTextBox();
         this.ImageListToolbar = new System.Windows.Forms.ImageList(this.components);
         this.toolBarFonts = new System.Windows.Forms.ToolBar();
         this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
         this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
         this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
         this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
         this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
         this.contextMenu1 = new System.Windows.Forms.ContextMenu();
         this.menuItem1 = new System.Windows.Forms.MenuItem();
         this.menuItem2 = new System.Windows.Forms.MenuItem();
         this.SuspendLayout();
         // 
         // MainMenuFiles
         // 
         this.MainMenuFiles.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.miFiles});
         // 
         // ContextMenuFonts
         // 
         this.ContextMenuFonts.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                         this.miBold,
                                                                                         this.miItalic,
                                                                                         this.miUnderline});
         // 
         // miFiles
         // 
         this.miFiles.Index = 0;
         this.miFiles.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                this.miNew,
                                                                                this.miOpen,
                                                                                this.miSave,
                                                                                this.menuItem4,
                                                                                this.miExit});
         this.miFiles.Text = "&Files";
         this.miFiles.Popup += new System.EventHandler(this.miFiles_Popup);
         // 
         // miNew
         // 
         this.miNew.Index = 0;
         this.miNew.Text = "&New";
         this.miNew.Click += new System.EventHandler(this.miNew_Click);
         // 
         // miOpen
         // 
         this.miOpen.Index = 1;
         this.miOpen.Text = "&Open";
         this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
         // 
         // miSave
         // 
         this.miSave.Index = 2;
         this.miSave.Text = "&Save";
         this.miSave.Click += new System.EventHandler(this.miSave_Click);
         // 
         // menuItem4
         // 
         this.menuItem4.Index = 3;
         this.menuItem4.Text = "-";
         // 
         // miExit
         // 
         this.miExit.Index = 4;
         this.miExit.Text = "&Exit";
         this.miExit.Click += new System.EventHandler(this.miExit_Click);
         // 
         // miBold
         // 
         this.miBold.Index = 0;
         this.miBold.Text = "&Bold";
         this.miBold.Click += new System.EventHandler(this.miBold_Click);
         // 
         // miItalic
         // 
         this.miItalic.Index = 1;
         this.miItalic.Text = "&Italic";
         this.miItalic.Click += new System.EventHandler(this.miItalic_Click);
         // 
         // miUnderline
         // 
         this.miUnderline.Index = 2;
         this.miUnderline.Text = "&Underline";
         this.miUnderline.Click += new System.EventHandler(this.miUnderline_Click);
         // 
         // rtfText
         // 
         this.rtfText.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right);
         this.rtfText.ContextMenu = this.ContextMenuFonts;
         this.rtfText.Location = new System.Drawing.Point(8, 40);
         this.rtfText.Name = "rtfText";
         this.rtfText.Size = new System.Drawing.Size(488, 224);
         this.rtfText.TabIndex = 0;
         this.rtfText.Text = "";
         this.rtfText.SelectionChanged += new System.EventHandler(this.rtfText_SelectionChanged);
         // 
         // ImageListToolbar
         // 
         this.ImageListToolbar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
         this.ImageListToolbar.ImageSize = new System.Drawing.Size(16, 16);
         this.ImageListToolbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageListToolbar.ImageStream")));
         this.ImageListToolbar.TransparentColor = System.Drawing.Color.Transparent;
         // 
         // toolBarFonts
         // 
         this.toolBarFonts.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
                                                                                        this.toolBarButton1,
                                                                                        this.toolBarButton2,
                                                                                        this.toolBarButton3,
                                                                                        this.toolBarButton4,
                                                                                        this.toolBarButton5});
         this.toolBarFonts.DropDownArrows = true;
         this.toolBarFonts.ImageList = this.ImageListToolbar;
         this.toolBarFonts.Name = "toolBarFonts";
         this.toolBarFonts.ShowToolTips = true;
         this.toolBarFonts.Size = new System.Drawing.Size(504, 25);
         this.toolBarFonts.TabIndex = 1;
         this.toolBarFonts.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarFonts_ButtonClick);
         // 
         // toolBarButton1
         // 
         this.toolBarButton1.ImageIndex = 0;
         this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
         // 
         // toolBarButton2
         // 
         this.toolBarButton2.ImageIndex = 1;
         this.toolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
         // 
         // toolBarButton3
         // 
         this.toolBarButton3.ImageIndex = 2;
         this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
         // 
         // toolBarButton4
         // 
         this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
         // 
         // toolBarButton5
         // 
         this.toolBarButton5.DropDownMenu = this.contextMenu1;
         this.toolBarButton5.ImageIndex = 3;
         this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
         // 
         // contextMenu1
         // 
         this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                     this.menuItem1,
                                                                                     this.menuItem2});
         this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
         // 
         // menuItem1
         // 
         this.menuItem1.Index = 0;
         this.menuItem1.Text = "MS Sans Serif";
         this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
         // 
         // menuItem2
         // 
         this.menuItem2.Index = 1;
         this.menuItem2.Text = "Times New Roman";
         this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click_1);
         // 
         // Form1
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(504, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.toolBarFonts,
                                                                      this.rtfText});
         this.Menu = this.MainMenuFiles;
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

      private void miNew_Click(object sender, System.EventArgs e)
      {
         this.rtfText.Clear();
      }

      private void miOpen_Click(object sender, System.EventArgs e)
      {
         // Load the file
         try
         {
            this.rtfText.LoadFile("../../test.rtf");
         }
         catch (System.Exception err)
         {
            MessageBox.Show("Error while loading:\n" + err.Message);
         } 

      }

      private void miSave_Click(object sender, System.EventArgs e)
      {
         // Save the file
         try
         {
            this.rtfText.SaveFile("../../test.rtf");
         }
         catch (System.Exception err)
         {
            MessageBox.Show("Error while saving file:\n" + err.Message);
         }

      }

      private void miExit_Click(object sender, System.EventArgs e)
      {
         // Exit the application
         Application.Exit();

      }

      private void miFiles_Popup(object sender, System.EventArgs e)
      {
         // Check to see if the file exist by setting the Enabled property to the 
         // return value of the File.Exists method.
         this.miOpen.Enabled = System.IO.File.Exists("../../test.rtf");

      }

      private void miBold_Click(object sender, System.EventArgs e)
      {
         Font newFont = new Font(rtfText.SelectionFont, 
            (rtfText.SelectionFont.Bold ? 
            rtfText.SelectionFont.Style & ~FontStyle.Bold : 
            rtfText.SelectionFont.Style | FontStyle.Bold));
         rtfText.SelectionFont = newFont;

      }

      private void miItalic_Click(object sender, System.EventArgs e)
      {
         Font newFont = new Font(rtfText.SelectionFont, 
            (rtfText.SelectionFont.Italic ? 
            rtfText.SelectionFont.Style & ~FontStyle.Italic : 
            rtfText.SelectionFont.Style | FontStyle.Italic));
         rtfText.SelectionFont = newFont;


      }

      private void miUnderline_Click(object sender, System.EventArgs e)
      {
         Font newFont = new Font(rtfText.SelectionFont, 
            (rtfText.SelectionFont.Underline ? 
            rtfText.SelectionFont.Style & ~FontStyle.Underline :
            rtfText.SelectionFont.Style| FontStyle.Underline));
         rtfText.SelectionFont = newFont;

      }

      private void toolBarFonts_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
      {
         Font newFont;

         // Switch on the index of the button in the Buttons collection of the
         // ToolBar
         switch (toolBarFonts.Buttons.IndexOf(e.Button))
         {
            case 0: // Bold
               if (e.Button.Pushed)
                  // Create a new font with Bold face
                  newFont = new Font(rtfText.SelectionFont, 
                     rtfText.SelectionFont.Style | FontStyle.Bold);
               else
                  // Create a new font without bold face
                  newFont = new Font(rtfText.SelectionFont, 
                     rtfText.SelectionFont.Style & ~FontStyle.Bold);
               rtfText.SelectionFont = newFont;
               break;
            case 1: // Italic
               if (e.Button.Pushed)
                  // Create a new font with italic
                  newFont = new Font(rtfText.SelectionFont, 
                     rtfText.SelectionFont.Style | FontStyle.Italic);
               else
                  // Create a new font without italic
                  newFont = new Font(rtfText.SelectionFont, 
                     rtfText.SelectionFont.Style & ~FontStyle.Italic);
               rtfText.SelectionFont = newFont;
               break;
            case 2: // Underline
               if (e.Button.Pushed)
                  // Create a new font with underline
                  newFont = new Font(rtfText.SelectionFont, 
                     rtfText.SelectionFont.Style | FontStyle.Underline);
               else
                  // Create a new font without underline
                  newFont = new Font(rtfText.SelectionFont, 
                     rtfText.SelectionFont.Style & ~FontStyle.Underline);
               rtfText.SelectionFont = newFont;
               break;
         }


      }

      private void rtfText_SelectionChanged(object sender, System.EventArgs e)
      {
         // Set the toolbar buttons to the correct state of pushed or not
         this.toolBarButton1.Pushed = rtfText.SelectionFont.Bold;
         this.toolBarButton2.Pushed = rtfText.SelectionFont.Italic;
         this.toolBarButton3.Pushed = rtfText.SelectionFont.Underline;

      }

      private void menuItem2_Click(object sender, System.EventArgs e)
      {
         // Create a new font with the correct font family.
         Font newFont = new Font("MS Sans Serif", rtfText.SelectionFont.Size, 
            rtfText.SelectionFont.Style);
         rtfText.SelectionFont = newFont;

      }

      private void menuItem3_Click(object sender, System.EventArgs e)
      {
         // Create a new font with the correct font family.
         Font newFont = new Font("Times New Roman", rtfText.SelectionFont.Size, 
            rtfText.SelectionFont.Style);
         rtfText.SelectionFont = newFont;

      }

      private void contextMenu1_Popup(object sender, System.EventArgs e)
      {
      
      }

      private void menuItem1_Click(object sender, System.EventArgs e)
      {
         Font newFont = new Font("MS Sans Serif", rtfText.SelectionFont.Size, 
            rtfText.SelectionFont.Style);
         rtfText.SelectionFont = newFont;
      }

      private void menuItem2_Click_1(object sender, System.EventArgs e)
      {
         Font newFont = new Font("Times New Roman", rtfText.SelectionFont.Size, 
            rtfText.SelectionFont.Style);
         rtfText.SelectionFont = newFont;

      }
	}
}
