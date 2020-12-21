using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing.Printing;


namespace SimpleEditor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class SimpleEditorForm : System.Windows.Forms.Form
	{
      private System.Windows.Forms.MainMenu mainMenu1;
      private System.Windows.Forms.MenuItem miFile;
      private System.Windows.Forms.MenuItem miFileNew;
      private System.Windows.Forms.MenuItem miFileOpen;
      private System.Windows.Forms.MenuItem miFileSave;
      private System.Windows.Forms.MenuItem miFileSaveAs;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
      private System.Windows.Forms.TextBox textBoxEdit;
      private System.Windows.Forms.OpenFileDialog dlgOpenFile;
      private System.Windows.Forms.SaveFileDialog dlgSaveFile;
      private System.Windows.Forms.MenuItem menuItem1;
      private System.Windows.Forms.MenuItem miFilePrint;
      private System.Windows.Forms.MenuItem miFilePrintPreview;
      private System.Windows.Forms.MenuItem miFilePageSetup;
      private System.Windows.Forms.MenuItem miFileExit;
      private System.Drawing.Printing.PrintDocument printDocument;
      private string fileName = "Untitled";

      private string[] lines;
      private System.Windows.Forms.PageSetupDialog dlgPageSetup;
      private System.Windows.Forms.PrintDialog dlgPrint;
      private System.Windows.Forms.PrintPreviewDialog dlgPrintPreview;
      private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
      private int linesPrinted;


		public SimpleEditorForm(string fileName)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
         if (fileName != null)
         {
            this.fileName = fileName;
            OpenFile();
         }

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
         System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SimpleEditorForm));
         this.textBoxEdit = new System.Windows.Forms.TextBox();
         this.mainMenu1 = new System.Windows.Forms.MainMenu();
         this.miFile = new System.Windows.Forms.MenuItem();
         this.miFileNew = new System.Windows.Forms.MenuItem();
         this.miFileOpen = new System.Windows.Forms.MenuItem();
         this.miFileSave = new System.Windows.Forms.MenuItem();
         this.miFileSaveAs = new System.Windows.Forms.MenuItem();
         this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
         this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
         this.menuItem1 = new System.Windows.Forms.MenuItem();
         this.miFilePrint = new System.Windows.Forms.MenuItem();
         this.miFilePrintPreview = new System.Windows.Forms.MenuItem();
         this.miFilePageSetup = new System.Windows.Forms.MenuItem();
         this.miFileExit = new System.Windows.Forms.MenuItem();
         this.printDocument = new System.Drawing.Printing.PrintDocument();
         this.dlgPageSetup = new System.Windows.Forms.PageSetupDialog();
         this.dlgPrint = new System.Windows.Forms.PrintDialog();
         this.dlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
         this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
         this.SuspendLayout();
         // 
         // textBoxEdit
         // 
         this.textBoxEdit.AcceptsReturn = true;
         this.textBoxEdit.AcceptsTab = true;
         this.textBoxEdit.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBoxEdit.Multiline = true;
         this.textBoxEdit.Name = "textBoxEdit";
         this.textBoxEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBoxEdit.Size = new System.Drawing.Size(568, 273);
         this.textBoxEdit.TabIndex = 0;
         this.textBoxEdit.Text = "";
         // 
         // mainMenu1
         // 
         this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                  this.miFile});
         // 
         // miFile
         // 
         this.miFile.Index = 0;
         this.miFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                               this.miFileNew,
                                                                               this.miFileOpen,
                                                                               this.miFileSave,
                                                                               this.miFileSaveAs,
                                                                               this.menuItem1,
                                                                               this.miFilePrint,
                                                                               this.miFilePrintPreview,
                                                                               this.miFilePageSetup,
                                                                               this.miFileExit});
         this.miFile.Text = "&File";
         // 
         // miFileNew
         // 
         this.miFileNew.Index = 0;
         this.miFileNew.Text = "&New";
         this.miFileNew.Click += new System.EventHandler(this.miFileNew_Click);
         // 
         // miFileOpen
         // 
         this.miFileOpen.Index = 1;
         this.miFileOpen.Text = "&Open...";
         this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
         // 
         // miFileSave
         // 
         this.miFileSave.Index = 2;
         this.miFileSave.Text = "&Save";
         this.miFileSave.Click += new System.EventHandler(this.miFileSave_Click);
         // 
         // miFileSaveAs
         // 
         this.miFileSaveAs.Index = 3;
         this.miFileSaveAs.Text = "Save &As...";
         this.miFileSaveAs.Click += new System.EventHandler(this.miFileSaveAs_Click);
         // 
         // dlgOpenFile
         // 
         this.dlgOpenFile.Filter = "Text Documents (*.txt)|*.txt|Wrox Documents (*.wroxtext)|*.wroxtext|All Files|*.*" +
            "";
         this.dlgOpenFile.FilterIndex = 2;
         // 
         // dlgSaveFile
         // 
         this.dlgSaveFile.FileName = "doc1";
         this.dlgSaveFile.Filter = "Text Document (*.txt)|*.txt|Wrox Documents (*.wroxtext)|*.wroxtext";
         this.dlgSaveFile.FilterIndex = 2;
         // 
         // menuItem1
         // 
         this.menuItem1.Index = 4;
         this.menuItem1.Text = "-";
         // 
         // miFilePrint
         // 
         this.miFilePrint.Index = 5;
         this.miFilePrint.Text = "&Print";
         this.miFilePrint.Click += new System.EventHandler(this.miFilePrint_Click);
         // 
         // miFilePrintPreview
         // 
         this.miFilePrintPreview.Index = 6;
         this.miFilePrintPreview.Text = "Print Pre&view";
         this.miFilePrintPreview.Click += new System.EventHandler(this.miFilePrintPreview_Click);
         // 
         // miFilePageSetup
         // 
         this.miFilePageSetup.Index = 7;
         this.miFilePageSetup.Text = "Page Set&up";
         this.miFilePageSetup.Click += new System.EventHandler(this.miFilePageSetup_Click);
         // 
         // miFileExit
         // 
         this.miFileExit.Index = 8;
         this.miFileExit.Text = "E&xit";
         // 
         // printDocument
         // 
         this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.OnBeginPrint);
         this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.OnPrintPage);
         // 
         // dlgPageSetup
         // 
         this.dlgPageSetup.Document = this.printDocument;
         // 
         // dlgPrint
         // 
         this.dlgPrint.Document = this.printDocument;
         // 
         // dlgPrintPreview
         // 
         this.dlgPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
         this.dlgPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
         this.dlgPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
         this.dlgPrintPreview.Document = this.printDocument;
         this.dlgPrintPreview.Enabled = true;
         this.dlgPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPrintPreview.Icon")));
         this.dlgPrintPreview.Location = new System.Drawing.Point(17, 54);
         this.dlgPrintPreview.MaximumSize = new System.Drawing.Size(0, 0);
         this.dlgPrintPreview.Name = "dlgPrintPreview";
         this.dlgPrintPreview.Opacity = 1;
         this.dlgPrintPreview.TransparencyKey = System.Drawing.Color.Empty;
         this.dlgPrintPreview.Visible = false;
         // 
         // printPreviewControl1
         // 
         this.printPreviewControl1.Document = this.printDocument;
         this.printPreviewControl1.Name = "printPreviewControl1";
         this.printPreviewControl1.Size = new System.Drawing.Size(512, 248);
         this.printPreviewControl1.TabIndex = 1;
         this.printPreviewControl1.Visible = false;
         this.printPreviewControl1.Zoom = 0.20359281437125748;
         // 
         // SimpleEditorForm
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(568, 273);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.printPreviewControl1,
                                                                      this.textBoxEdit});
         this.Menu = this.mainMenu1;
         this.Name = "SimpleEditorForm";
         this.Text = "Simple Editor";
         this.ResumeLayout(false);

      }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) 
		{
         string fileName = null;
         if (args.Length != 0)
            fileName = args[0];
         Application.Run(new SimpleEditorForm(fileName));

			
		}

      private void miFileNew_Click(object sender, System.EventArgs e)
      {
         fileName = "Untitled"; 
         textBoxEdit.Clear();
         SetFormTitle();

      }

      protected void OpenFile()
      {
         try
         {
            using (StreamReader reader = File.OpenText(fileName))
            {
               textBoxEdit.Clear();
               textBoxEdit.Text = reader.ReadToEnd();
        
            }
         }
         catch (IOException ex)
         {
            MessageBox.Show(ex.Message, "Simple Editor", 
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void miFileOpen_Click(object sender, System.EventArgs e)
      {
         if (dlgOpenFile.ShowDialog() == DialogResult.OK)
         {
            fileName = dlgOpenFile.FileName;
                     
            OpenFile();
            SetFormTitle();
         }

      }

      private void miFileSaveAs_Click(object sender, System.EventArgs e)
      {
         if (dlgSaveFile.ShowDialog() == DialogResult.OK)
         {
            fileName = dlgSaveFile.FileName;
                     
            SaveFile();
            SetFormTitle();
         }

      }

      protected void SaveFile()
      {
         try
         {
            Stream stream = File.OpenWrite(fileName);
            using (StreamWriter writer = new StreamWriter(stream))
            {
               writer.Write(textBoxEdit.Text);
            }
         }
         catch (IOException ex)
         {
            MessageBox.Show(ex.Message, "Simple Editor", 
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void miFileSave_Click(object sender, System.EventArgs e)
      {
         if (fileName == "Untitled")
         {
            miFileSaveAs_Click(sender, e);
         }
         else
         {
            SaveFile();
                    
         }

      }

      protected void SetFormTitle()
      {
         FileInfo fileinfo = new FileInfo (fileName);
         this.Text = fileinfo.Name + " - Simple Editor";
      }

      private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
      {
         int x = 20;
         int y = 20;
         
         while (linesPrinted < lines.Length)
         {
            e.Graphics.DrawString (lines[linesPrinted++], 
               new Font("Arial", 10), Brushes.Black, x, y);
            y += 15;
            if (y >= e.PageBounds.Height - 80)
            {
               e.HasMorePages = true;
               return;
            }
         }

         linesPrinted = 0;
         e.HasMorePages = false;


      }

      private void miFilePrint_Click(object sender, System.EventArgs e)
      {
         if (textBoxEdit.SelectedText != "")
         {
            dlgPrint.AllowSelection = true;
         }
         if (dlgPrint.ShowDialog() == DialogResult.OK)
         {
            printDocument.Print();
         }

      }

      private void OnBeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
      {
         char[] param = {'\n'};

         if (dlgPrint.PrinterSettings.PrintRange == PrintRange.Selection)
         {
            lines = textBoxEdit.SelectedText.Split(param);
         }
         else
         {
            lines = textBoxEdit.Text.Split(param);
         }

         int i = 0;
         char[] trimParam = {'\r'};
         foreach (string s in lines)
         {
            lines[i++] = s;
            //.TrimEnd(trimParam);
         }


      }

      private void miFilePageSetup_Click(object sender, System.EventArgs e)
      {
                  dlgPageSetup.ShowDialog();
      }

      private void miFilePrintPreview_Click(object sender, System.EventArgs e)
      {
                  dlgPrintPreview.ShowDialog();

      }


   }
}
