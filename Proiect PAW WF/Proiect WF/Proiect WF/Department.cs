using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectWF
{

    internal class Department
    {
        private string DepartmentId;
        private string DepartmentName;
        private string DepartmentManager;
        private string DepartmentLocation;
        private List<Employee> Employees = new List<Employee>();

        public string DepartmentId1 { get => DepartmentId; set => DepartmentId = value; }
        public string DepartmentName1 { get => DepartmentName; set => DepartmentName = value; }
        public string DepartmentManager1 { get => DepartmentManager; set => DepartmentManager = value; }
        public string DepartmentLocation1 { get => DepartmentLocation; set => DepartmentLocation = value; }
        internal List<Employee> Employees1 { get => Employees; set => Employees = value; }

        public Department(string departmentId, string departmentName, string departmentManager, string departmentLocation)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            DepartmentManager = departmentManager;
            DepartmentLocation = departmentLocation;
            Employees = new List<Employee>();
        }
        public Department()
        {
            DepartmentId = "default";
            DepartmentName = "default";
            DepartmentManager = "default";
            DepartmentLocation = "default";
            Employees = new List<Employee>();
        }
        public override string ToString()
        {
            return
           "ID:" + DepartmentId + "\n" +
           "Name:" + DepartmentName + "\n" +
           "Manager:" + DepartmentManager + "\n" +
           "Location:" + DepartmentLocation;

        }
        public void Add(Employee e)
        {
            if (e.Department != DepartmentName)
            {
                MessageBox.Show("Employee is not from this department");
                return;
            }
            Employees.Add(e);
        }


    }
}

