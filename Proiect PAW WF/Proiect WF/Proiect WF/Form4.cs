using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectWF;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect_WF
{

    public partial class Form4 : Form
    {
        List<Employee> EmployeeList = new List<Employee>();
        public Form4(List<Employee> employees)
        {
            InitializeComponent();
            EmployeeList = employees;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            if (EmployeeList.Count > 0)
            {
                chart1.Titles.Clear();
                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }
                chart1.Titles.Add("Titlu");
                foreach (Employee emp in EmployeeList)
                {
                    chart1.Series["Salariu Brut"].Points.AddY(emp.Salary);
                    chart1.Series["Salariu Net"].Points.AddY(emp.Salary - emp.Salary / 10);
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
        }
    }
}
