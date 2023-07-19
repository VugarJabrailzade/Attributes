using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskNew
{
   public class Service
    {
        private List<Student> students;

        public Service()
        {
            students = new();
        }
        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(string name,string surname,double grade)
        {
           
            if (grade < 0) throw new Exception("Grade can not be less than 0!");
            if (name == null) throw new Exception("Invalid! Please add correctly!");
            if (surname == null) throw new Exception("Invalid! Please add correctly!");
            var student = new Student(name, surname, grade);
            students.Add(student);

        }
        public void UpdateStudent(string name,string surname,double grade)
        {
            
            if (grade < 0) throw new Exception("Grade can not be less than 0!");
            if (name == null) throw new Exception("Invalid! Please add correctly!");
            if (surname == null) throw new Exception("Invalid! Please add correctly!");
            
            var updstudent = new Student(name, surname, grade);
            students.Add(updstudent);
            

        }


        public void RemoveStudent(int id)
        {
            
            var existingStudent = students.FirstOrDefault(x => x.Id == id);

            if (id < 0) throw new Exception("ID can not be less than 0!");
            if (existingStudent == null) throw new Exception("Not found!");

            students = students.Where(x => x.Id != id).ToList();
        }

        public void FindStudent(string name, int iD)
        {
            var existingStudentName = students.FirstOrDefault(x => x.Name == name && x.Id == iD);
            
            if (existingStudentName == null) throw new Exception("Not found!");

            students = students.Where(x => x.Name != name).ToList();
           

        }
        public Student FindStudentId(int id)
        {
            foreach (var student in students)
            {
                if (student.Id == id) return student;
            }
            return default(Student);
        }

    } 
}
