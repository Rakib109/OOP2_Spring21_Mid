using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Course
    {
        private string courseName;
        private string courseId;
        private int courseCredit;
        public String CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }
        public String CourseId
        {
            get
            {
                return courseId;
            }
            set
            {
                courseId = value;
            }
        }
        public int CourseCredit
        {
            get
            {
                return courseCredit;
            }
            set
            {
                courseCredit = value;
            }
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course Id: " + courseId);
            Console.WriteLine("Course Credit: " + courseCredit);
        }
    }
}
