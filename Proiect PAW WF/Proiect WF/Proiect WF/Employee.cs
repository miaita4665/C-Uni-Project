using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectWF
{
     public class Employee
    {
       private string cnp;
       private string name;
       private string surname;
       private string email;
       private string phone;
       private string address;
       private string postion;
       private string department;
       private float salary = 0;


        public string Cnp { get => cnp; set => cnp = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Postion { get => postion; set => postion = value; }
		public string Department { get => department; set => department = value; }
		public float Salary { get => salary; set => salary = value; }

        public Employee(string cnp, string name, string surname, string email, string phone, string address, string postion, string department, float salary)
        {
            Cnp = cnp;
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            Address = address;
            Postion = postion;
            Department = department;
            Salary = salary;

        }

        public Employee()
        {
            this.cnp        = "default";
            this.name       = "default";
            this.surname    = "default";
            this.email      = "default";
            this.phone      = "default";
            this.address    = "default";
            this.postion    = "default";
            this.Department = "default";
            this.salary = 0;
        }
        public Employee(Employee e)
        {
            this.cnp = e.cnp;
            this.name = e.name;
            this.surname = e.surname;
            this.email = e.email;
            this.phone = e.phone;
            this.address = e.address;
            this.postion = e.postion;
            this.Department = e.Department;
        }
        public override string ToString() {
            return "Employee: " + "\n" +
            "CNP: " + cnp + " \n" +
            "Name: " + name + " \n" +
            "Surname: " + surname + " \n" +
            "Email: " + email + " \n" +
            "Phone: " + phone + " \n" +
            "Address: " + address + " \n" +
            "Position: " + postion + " \n" +
            "Department: " + Department + " \n" +
            "Salary: " + salary;
        }
        public string CalculateNetSalary()
        {
            float netSalary = this.Salary - (this.Salary * 0.16f);
            return netSalary.ToString();
        }

    }
}
