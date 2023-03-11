using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthNamesGUI
{
    enum Month
    {
        Janurary = 1,
        Feburary,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = txtMonth.Text;
            int monthNum = Convert.ToInt32(input);
            Month month = (Month)monthNum;
            txtOutput.Text = month.ToString();
        }

      
    }
}
