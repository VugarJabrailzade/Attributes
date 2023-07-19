using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNew
{
    public class Student
    {

        private static int counter = 0;
        

        public string Name { get; set; }
        public string Surname { get; set; }
        public double Grade { get; set; }
        public int Id { get; set; }

       

        public Student(string name, string surname, double grade) 
        {
            Name = name;
            Surname = surname;
            Grade = grade;
            Id = counter;
            counter++;
        }
    }
}
