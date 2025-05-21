using ProiectWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net;
using System.Threading;

namespace Proiect_WF
{
    public partial class Form1 : Form
    {
        List<Employee> EmployeeList = new List<Employee>();
        /// 
        ///
        /// 
        public Form1()
        {
            InitializeComponent();
        }
        ///
        //Buttons
        ///
        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (tbCnp.Text == "")
                errorProvider1.SetError(tbCnp, "Insert CNP!");
            else
            if (tbName.Text == "")
                errorProvider1.SetError(tbName, "Insert Sex");
            else
            if (tbSurname.Text == "")
                errorProvider1.SetError(tbSurname, "Insert Surname!");
            else
            if (tbEmail.Text == "")
                errorProvider1.SetError(tbEmail, "Insert Email");
            else
            if (tbPhone.Text == "")
                errorProvider1.SetError(tbPhone, "Insert Phone");
            else
            if (tbAddress.Text == "")
                errorProvider1.SetError(tbAddress, "Insert Address");
            else
            if (tbPosition.Text == "")
                errorProvider1.SetError(tbPosition, "Insert Position");
            else
            if (tbDepartment.Text == "")
                errorProvider1.SetError(tbDepartment, "Insert Department");
            else
            if (tbSalary.Text == "")
                errorProvider1.SetError(tbSalary, "Insert Salary");
            else
            {
                errorProvider1.Clear();
                try
                {
                    tbNetSalary.Clear();
                    string cnp = tbCnp.Text;
                    string name = tbName.Text;
                    string surname = tbSurname.Text;
                    string email = tbEmail.Text;
                    string phone = tbPhone.Text;
                    string address = tbAddress.Text;
                    string position = tbPosition.Text;
                    string Department = tbDepartment.Text;
                    float salary = float.Parse(tbSalary.Text);
                    Employee emp = new Employee(cnp, name, surname, email, phone, address, position, Department, salary);
                    MessageBox.Show("Angajat cu cnp-ul " + cnp + " introdus");
                    EmployeeList.Add(emp);
                    tbNetSalary.Text = emp.CalculateNetSalary();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbCnp.Clear();
                    tbName.Clear();
                    tbSurname.Clear();
                    tbEmail.Clear();
                    tbPhone.Clear();
                    tbAddress.Clear();
                    tbPosition.Clear();
                    tbDepartment.Clear();
                    tbSalary.Clear();
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            tbCnp.Clear();
            tbName.Clear();
            tbSurname.Clear();
            tbEmail.Clear();
            tbPhone.Clear();
            tbAddress.Clear();
            tbPosition.Clear();
            tbDepartment.Clear();
            tbSalary.Clear();
        }
        private void btnEmployeesall_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in EmployeeList)
            {
                MessageBox.Show(emp.ToString());
            }
        }

        ///
        //digit only
        ///
        private void tbCnp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // Allow digits and backspace to be entered
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // Allow digits and backspace to be entered
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false; // Allow digits and backspace to be entered
            }
            else
            {
                e.Handled = true;
            }
        }
        // letter only
        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = false; // doesnt allow digits to be entered
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = false; // doesnt allow digits to be entered
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tbPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = false; // doesnt  allow Digits to be entered
            }
            else
            {
                e.Handled = true;
            }
        }
        private void tbDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = false; // doesnt allow  digits to be entered
            }
            else
            {
                e.Handled = true;
            }
        }
        ///
        //XML 
        ///
        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            string filePath = "Employees.xml";
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Already exists");
            }
            else
            {
                XDocument xmlDoc = new XDocument(
                new XElement("Employees",
                        from Employee in EmployeeList
                        select new XElement("Employee",
                            new XElement("Cnp", Employee.Cnp),
                            new XElement("Name", Employee.Name),
                            new XElement("Surname", Employee.Surname),
                            new XElement("Email", Employee.Email),
                            new XElement("Phone", Employee.Phone),
                            new XElement("Address", Employee.Address),
                            new XElement("Position", Employee.Postion),
                            new XElement("Department", Employee.Department),
                            new XElement("Salary", Employee.Salary))));

                xmlDoc.Save(filePath);
                MessageBox.Show("XML File Created:\n" + filePath);
            }
        }         //Serialization

        private void departmentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void employeeSalaryGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Employee_temp = EmployeeList;
            Form4 form = new Form4(Employee_temp);
            form.ShowDialog();
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string [] files =e.Data.GetData(DataFormats.FileDrop) as string[];
            foreach (string s in files)
                MessageBox.Show(s);
        }
    }
}
