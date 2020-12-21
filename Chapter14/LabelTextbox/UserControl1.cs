using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace LabelTextbox
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
  public class ctlLabelTextbox : System.Windows.Forms.UserControl
  {
    public enum PositionEnum
    {
      Right,
      Below
    }

    private System.Windows.Forms.Label lblTextBox;
    private System.Windows.Forms.TextBox txtLabelText;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    // Member field that will hold the choices the user makes
    private PositionEnum mPosition = PositionEnum.Right;
    private int mTextboxMargin = 0;

//    public delegate void PositionChanged(object sender, EventArgs e);

    public event System.EventHandler PositionChanged;

    public ctlLabelTextbox()
    {
      // This call is required by the Windows.Forms Form Designer.
      InitializeComponent();

      // Handle the SizeChanged event
      this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
      
      // Handle the Load event
      this.Load += new EventHandler(this.OnLoad);

      // Textbox Keybord events
      this.txtLabelText.KeyDown += new KeyEventHandler(this.txtLabelText_KeyDown);
      this.txtLabelText.KeyUp += new KeyEventHandler(this.txtLabelText_KeyUp);
      this.txtLabelText.KeyPress += new KeyPressEventHandler(this.txtLabelText_KeyPress);
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if( components != null )
          components.Dispose();
      }
      base.Dispose( disposing );
    }

    public PositionEnum Position
    {
      get
      {
        return mPosition;
      }
      set
      {
        mPosition = value;
        MoveControls();
        if (PositionChanged != null) // Make sure there are any subscribers
        {
          // Get the list of methods to call
          System.Delegate[] subscribers = PositionChanged.GetInvocationList();

          // Loop through the methods
          foreach (System.EventHandler target in subscribers)
          {
            target(this, new EventArgs()); // Call the method
          }
        }
      }
    }

    public int TextboxMargin
    {
      get
      {
        return mTextboxMargin;
      }
      set
      {
        mTextboxMargin = value;
        MoveControls();
      }
    }

    public string LabelText
    {
      get
      {
        return lblTextBox.Text;
      }
      set
      {
        lblTextBox.Text = value;
        MoveControls(); // Call MoveControls to make the size the textbox if needed
      }
    }

    public string TextboxText
    {
      get
      {
        return txtLabelText.Text;
      }
      set
      {
        txtLabelText.Text = value;
      }
    }

    private void MoveControls()
    {
      switch (mPosition)
      {
        case PositionEnum.Below:
        {
          // Place the top of the Textbox just below the label
          this.txtLabelText.Top = this.lblTextBox.Bottom;
          this.txtLabelText.Left = this.lblTextBox.Left;

          // Change the width of the Textbox to equal the width of the control
          this.txtLabelText.Width = this.Width;
					this.Height = txtLabelText.Height + lblTextBox.Height;
          break;
        }
        case PositionEnum.Right:
        {
          // Set the top of the textbox to equal that of the label
          txtLabelText.Top = lblTextBox.Top;

          // If the margin is zero, we'll place the textbox next to the label
          if (mTextboxMargin == 0)
          {
            int width = this.Width-lblTextBox.Width-3;
            txtLabelText.Left = lblTextBox.Right + 3;
            txtLabelText.Width = width;
          }
          else
          {
            // If the margin isn't zero, we place the textbox where the user have specified
            txtLabelText.Left = mTextboxMargin;
            txtLabelText.Width = this.Right-mTextboxMargin;
          }
          break;
        }
      }
    }

    private void OnSizeChanged(object sender, System.EventArgs e)
    {
      MoveControls();
    }

    private void txtLabelText_KeyDown(object sender, KeyEventArgs e)
    {
      OnKeyDown(e);
    }

    private void txtLabelText_KeyUp(object sender, KeyEventArgs e)
    {
      OnKeyUp(e);
    }

    private void txtLabelText_KeyPress(object sender, KeyPressEventArgs e)
    {
      OnKeyPress(e);
    }

    private void OnControlAdded(object sender, ControlEventArgs e)
    {
      MoveControls();
    }

    private void OnLoad(object sender, EventArgs e)
    {
      lblTextBox.Text = this.Name;
      this.Height = txtLabelText.Height + lblTextBox.Height;
      MoveControls();
    }

		#region Component Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.lblTextBox = new System.Windows.Forms.Label();
			this.txtLabelText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTextBox
			// 
			this.lblTextBox.AutoSize = true;
			this.lblTextBox.Name = "lblTextBox";
			this.lblTextBox.Size = new System.Drawing.Size(32, 13);
			this.lblTextBox.TabIndex = 0;
			this.lblTextBox.Text = "Label";
			// 
			// txtLabelText
			// 
			this.txtLabelText.Location = new System.Drawing.Point(8, 40);
			this.txtLabelText.Name = "txtLabelText";
			this.txtLabelText.TabIndex = 1;
			this.txtLabelText.Text = "";
			// 
			// ctlLabelTextbox
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.txtLabelText,
																																	this.lblTextBox});
			this.Name = "ctlLabelTextbox";
			this.ResumeLayout(false);

		}
		#endregion
  }
}
