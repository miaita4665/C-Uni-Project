using ProiectWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proiect_WF
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnAddDep_Click(object sender, EventArgs e)
        {
            {
                if (tbID.Text == "")
                    errorProvider1.SetError(tbID, "Insert CNP!");
                else
                if(tbName.Text == "")
                    errorProvider1.SetError(tbName, "Insert Name");
                else
                if (tbManager.Text == "")
                    errorProvider1.SetError(tbManager, "Insert Manager");
                else
                if (tbLocation.Text == "")
                    errorProvider1.SetError(tbLocation, "Insert Location");
                else
                {
                    errorProvider1.Clear();
                    try
                    {
                        string id = tbID.Text;
                        string name = tbName.Text;
                        string manager = tbManager.Text;
                        string location = tbLocation.Text;
                        Department dep = new Department(id, name, manager, location);
                        MessageBox.Show(dep.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        tbID.Clear();
                        tbName.Clear();
                        tbManager.Clear();
                        tbLocation.Clear();
                    }
                }
            }
        }
    }
}
