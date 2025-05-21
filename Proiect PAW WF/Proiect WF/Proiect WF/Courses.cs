using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectWF
{
    class Courses
    {
        private int CourseID;
        private string CourseName;
        private string StartDate;
        private string EndDate;
        private string Trainer;
        private List<Employee> Participants = new List<Employee>();

        public int CourseID1 { get => CourseID; set => CourseID = value; }
        public string CourseName1 { get => CourseName; set => CourseName = value; }
      
        public string StartDate1 { get => StartDate; set => StartDate = value; }
        public string EndDate1 { get => EndDate; set => EndDate = value; }
        public string Trainer1 { get => Trainer; set => Trainer = value; }
        internal List<Employee> Participants1 { get => Participants; set => Participants = value; }
        public Courses()
        {
            CourseID = 0;
            CourseName = "default";
            StartDate = "default";
            EndDate = "default";
            Trainer = "default";
            Participants = new List<Employee>();
        }
        public Courses(int courseID, string courseName, string startDate, string endDate, string trainer, List<Employee> participants)
        {
            CourseID = courseID;
            CourseName = courseName;
            StartDate = startDate;
            EndDate = endDate;
            Trainer = trainer;
            Participants = participants;
        }
        public override string ToString()
        {
            return "Course id:" + CourseID + "\n" +
                "Course name:" + CourseName + "\n+"+"" +
                "Start date:" + StartDate + " \n" +
               " End date:" + EndDate + "\n"+
                "Trainer:" + Trainer;
        }
        Courses(Employee e)
        {
            if (!Participants.Contains(e))
            {
                MessageBox.Show("Participant added");
                Participants.Add(e);
            }
            else
            {
                MessageBox.Show("Participant already exists");
            }
        }
    }
        
}
