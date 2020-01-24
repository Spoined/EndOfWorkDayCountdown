using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class SetTime : Form
  {
    WorkDuration workDuration = new WorkDuration();

    public SetTime()
    {
      InitializeComponent();
      tbFrom.Mask = "00:00 Uhr";
      tbTo.Mask = "00:00 Uhr";

      workDuration.workFromHour = -1;
      workDuration.workToHour = -1;

      this.AcceptButton = btnAccept;
      this.CancelButton = btnExit;
    }

    public WorkDuration ShowSetTime()
    {
      this.ShowDialog();
      int i = 0;
      if(workDuration.workFromHour == -1 || workDuration.workToHour == -1)
      {
        return null;
      } else
      {
        return workDuration;
      }
    }

    private void btnAccept_Click(object sender, EventArgs e)
    {
      if (tbFrom.Text == "  :   Uhr" || tbTo.Text == "  :   Uhr")
      {
        MessageBox.Show("Leider konnte die Eingabe nicht erkannt werden. Bitte geben Sie sowohl die Anfangs als auch die Endzeit an.", "Fehler bei der Eingabe");
      }
      else
      {
        workDuration.workFromHour = int.Parse(tbFrom.Text.Substring(0, 5).Split(':')[0]);
        workDuration.workFromMinute = int.Parse(tbFrom.Text.Substring(0, 5).Split(':')[1]);

        workDuration.workToHour = int.Parse(tbTo.Text.Substring(0, 5).Split(':')[0]);
        workDuration.workToMinute = int.Parse(tbTo.Text.Substring(0, 5).Split(':')[1]);
        Close();
      }
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void tbFrom_Leave(object sender, EventArgs e)
    {
      string time = tbFrom.Text.Substring(0, 5).Replace(' ', '0');
      tbFrom.Text = time + " Uhr";
    }

    private void tbTo_Leave(object sender, EventArgs e)
    {
      string time = tbTo.Text.Substring(0, 5).Replace(' ', '0');
      tbTo.Text = time + " Uhr";
    }
  }
}
