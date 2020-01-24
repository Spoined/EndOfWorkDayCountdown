namespace WindowsFormsApp1
{
  partial class SetTime
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnAccept = new System.Windows.Forms.Button();
      this.tbFrom = new System.Windows.Forms.MaskedTextBox();
      this.tbTo = new System.Windows.Forms.MaskedTextBox();
      this.btnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(119, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(20, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "bis";
      // 
      // btnAccept
      // 
      this.btnAccept.Location = new System.Drawing.Point(13, 39);
      this.btnAccept.Name = "btnAccept";
      this.btnAccept.Size = new System.Drawing.Size(231, 23);
      this.btnAccept.TabIndex = 3;
      this.btnAccept.Text = "Übernehmen";
      this.btnAccept.UseVisualStyleBackColor = true;
      this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
      // 
      // tbFrom
      // 
      this.tbFrom.Location = new System.Drawing.Point(13, 13);
      this.tbFrom.Name = "tbFrom";
      this.tbFrom.Size = new System.Drawing.Size(100, 20);
      this.tbFrom.TabIndex = 1;
      this.tbFrom.Leave += new System.EventHandler(this.tbFrom_Leave);
      // 
      // tbTo
      // 
      this.tbTo.Location = new System.Drawing.Point(144, 13);
      this.tbTo.Name = "tbTo";
      this.tbTo.Size = new System.Drawing.Size(100, 20);
      this.tbTo.TabIndex = 2;
      this.tbTo.Leave += new System.EventHandler(this.tbTo_Leave);
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
      // SetTime
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(256, 68);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.tbTo);
      this.Controls.Add(this.tbFrom);
      this.Controls.Add(this.btnAccept);
      this.Controls.Add(this.label1);
      this.Name = "SetTime";
      this.Text = "SetTime";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.MaskedTextBox tbFrom;
        private System.Windows.Forms.MaskedTextBox tbTo;
        private System.Windows.Forms.Button btnExit;
    }
}