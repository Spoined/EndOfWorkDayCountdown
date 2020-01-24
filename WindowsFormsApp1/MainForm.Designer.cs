namespace WindowsFormsApp1
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lblPercent = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.btnExit = new System.Windows.Forms.Button();
      this.lblRight = new System.Windows.Forms.Label();
      this.lblLeft = new System.Windows.Forms.Label();
      this.btnSetTime = new System.Windows.Forms.Button();
      this.moveLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblPercent
      // 
      this.lblPercent.Location = new System.Drawing.Point(12, 13);
      this.lblPercent.Name = "lblPercent";
      this.lblPercent.Size = new System.Drawing.Size(460, 21);
      this.lblPercent.TabIndex = 0;
      this.lblPercent.Text = "- %";
      this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // progressBar1
      // 
      this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.progressBar1.Location = new System.Drawing.Point(0, 0);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(488, 10);
      this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.progressBar1.TabIndex = 5;
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(500, 500);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(75, 23);
      this.btnExit.TabIndex = 0;
      this.btnExit.TabStop = false;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // lblRight
      // 
      this.lblRight.Location = new System.Drawing.Point(290, 13);
      this.lblRight.Name = "lblRight";
      this.lblRight.Size = new System.Drawing.Size(182, 21);
      this.lblRight.TabIndex = 3;
      this.lblRight.Text = "0:00";
      this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblLeft
      // 
      this.lblLeft.Location = new System.Drawing.Point(12, 13);
      this.lblLeft.Name = "lblLeft";
      this.lblLeft.Size = new System.Drawing.Size(155, 21);
      this.lblLeft.TabIndex = 4;
      this.lblLeft.Text = "0:00";
      this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnSetTime
      // 
      this.btnSetTime.Location = new System.Drawing.Point(500, 500);
      this.btnSetTime.Name = "btnSetTime";
      this.btnSetTime.Size = new System.Drawing.Size(75, 23);
      this.btnSetTime.TabIndex = 1;
      this.btnSetTime.Text = "settings";
      this.btnSetTime.UseVisualStyleBackColor = true;
      this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
      // 
      // button1
      // 
      this.moveLabel.BackColor = System.Drawing.SystemColors.ControlDark;
      this.moveLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
      this.moveLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.moveLabel.Location = new System.Drawing.Point(488, 0);
      this.moveLabel.Name = "button1";
      this.moveLabel.Size = new System.Drawing.Size(20, 40);
      this.moveLabel.TabIndex = 6;
      this.moveLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
      this.moveLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
      this.moveLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(505, 39);
      this.Controls.Add(this.moveLabel);
      this.Controls.Add(this.btnSetTime);
      this.Controls.Add(this.lblLeft);
      this.Controls.Add(this.lblRight);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.lblPercent);
      this.Name = "MainForm";
      this.Text = "Counter";
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblPercent;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.BindingSource bindingSource1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label lblRight;
    private System.Windows.Forms.Label lblLeft;
    private System.Windows.Forms.Button btnSetTime;
    private System.Windows.Forms.Label moveLabel;
  }
}

