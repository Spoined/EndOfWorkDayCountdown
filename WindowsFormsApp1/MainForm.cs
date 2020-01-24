using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class MainForm : Form
  {

    bool draggable;
    int mouseX;
    int mouseY;

    Point tempLoc;
    Font tempFont;
    int tempWidth, tempHeight;
    bool messageshown = false;

    public bool customTime = false;

    int countdown;

    DateTime anfangsZeit = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
    DateTime endZeit = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 0, 0);

    public MainForm()
    {
      InitializeComponent();
      this.DoubleBuffered = true;
      timer1.Enabled = true;
      timer1.Interval = 1000;
      timer1_Tick(this, EventArgs.Empty);
      timer1.Start();

      this.TopMost = true;
      this.FormBorderStyle = FormBorderStyle.None;
      
      this.CancelButton = btnExit;
      this.AcceptButton = btnSetTime;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if(countdown == 0)
      {
        RemoveMessage();
        countdown = -1;
      } else if(countdown > 0)
      {
        countdown--;
      }

      DateTime jetzt = DateTime.Now;

      if(!messageshown)
      {
        if(!customTime)
          if (jetzt.DayOfWeek == DayOfWeek.Friday)
            endZeit = new DateTime(jetzt.Year, jetzt.Month, jetzt.Day, 15, 0, 0);

        double percentage = ((jetzt - anfangsZeit).TotalMilliseconds / (endZeit - anfangsZeit).TotalMilliseconds) * 100;

        lblPercent.Text = jetzt.ToString("HH:mm:ss") + " (" + Math.Round(percentage, 2) + " %)";
        lblLeft.Text = anfangsZeit.ToString("HH:mm");
        lblRight.Text = endZeit.ToString("HH:mm");

        progressBar1.Value = Math.Min(100, (int)Math.Round(percentage, 0));

        if (percentage >= 100)
        {
          ShowMessage("FEIERABEND");
          if (jetzt.DayOfWeek == DayOfWeek.Friday)
            ShowMessage("WOCHENENDE");
        }
      }
    }

    #region private methods
    private void ShowMessage(string text)
    {
      messageshown = true;
      tempFont = lblPercent.Font;
      tempLoc = lblPercent.Location;
      tempWidth = lblPercent.Width;
      tempHeight = lblPercent.Height;

      progressBar1.Visible = false;
      lblPercent.Location = new Point(0, 0);
      lblPercent.Width = this.Width;
      lblPercent.Height = this.Height;
      lblPercent.Text = text;
      lblPercent.Font = new Font(lblPercent.Font.FontFamily, 25F, new FontStyle());
      lblPercent.ForeColor = Color.White;
      lblLeft.Visible = false;
      lblRight.Visible = false;
      this.BackColor = Color.DarkGreen;
    }

    private void ShowMessage(string text, int showSeconds)
    {
      countdown = showSeconds;
      messageshown = true;
      tempFont = lblPercent.Font;
      tempLoc = lblPercent.Location;
      tempWidth = lblPercent.Width;
      tempHeight = lblPercent.Height;

      progressBar1.Visible = false;
      lblPercent.Location = new Point(0, 0);
      lblPercent.Width = this.Width;
      lblPercent.Height = this.Height;
      lblPercent.Text = text;
      lblPercent.Font = new Font(lblPercent.Font.FontFamily, 25F, new FontStyle());
      lblPercent.ForeColor = Color.White;
      lblLeft.Visible = false;
      lblRight.Visible = false;
      this.BackColor = Color.DarkGreen;
    }

    private void RemoveMessage()
    {
      if(messageshown)
      {
        messageshown = false;
        lblPercent.Font = tempFont;
        lblPercent.Location = tempLoc;
        lblPercent.Width = tempWidth;
        lblPercent.Height = tempHeight;
        lblLeft.Visible = true;
        lblRight.Visible = true;

        progressBar1.Visible = true;
        lblPercent.ForeColor = Color.Black;
        this.BackColor = Color.White;
      }
    }
    #endregion

    #region Drag Window Events

    private void button1_MouseDown(object sender, MouseEventArgs e)
    {
      draggable = true;
      mouseX = Cursor.Position.X - this.Left;
      mouseY = Cursor.Position.Y - this.Top;
    }

    private void button1_MouseMove(object sender, MouseEventArgs e)
    {
      if (draggable)
      {
        this.Left = Cursor.Position.X - mouseX;
        this.Top = Cursor.Position.Y - mouseY;
      }
    }

    private void button1_MouseUp(object sender, MouseEventArgs e)
    {
      draggable = false;
    }
    #endregion

    private void btnSetTime_Click(object sender, EventArgs e)
    {
      SetTime setTime = new SetTime();
      WorkDuration workDur = setTime.ShowSetTime();
      if(workDur != null)
      {
        anfangsZeit = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, workDur.workFromHour, workDur.workFromMinute, 0);
        endZeit = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, workDur.workToHour, workDur.workFromMinute, 0);
        customTime = true;
      }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
