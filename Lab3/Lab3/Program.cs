using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Rakib";
            s.Id = "19-39358-1";
            s.Department = "CSE";
            s.Cgpa = 3.12f;
            s.ShowInfo();
            Triangle t = new Triangle();
            t.X = 3;
            t.X = 4;
            t.Z = 7;
            t.ShowInfo();
            t.TestTriangle();
            Account a = new Account();
            a.AccName = "My Account";
            a.AcId = "10";
            a.Balance = 5000;
            a.Deposit(15);
            a.Withdraw(50);
            Course c = new Course();
            c.CourseName = "OOP2";
            c.CourseId = "3221";
            c.CourseCredit = 3;
            c.ShowCourseInfo();
        }
    }

}
