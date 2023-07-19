using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace TaskNew
{
    
    public  class MenuService
    {
        private static Service studentService = new Service();

        public static void MenuShowStudent()
        {
            var student = studentService.GetStudents();

            if (student.Count == 0)
            {
                Console.WriteLine("No student's yet.");
                return;
            }

            foreach (var item in student)
            {
                Console.WriteLine($"Id: {item.Id} | Name: {item.Name} | Surname: {item.Surname} | Grade: {item.Grade}");
            }

        }

        public static void MenuAddStudent()
        {
            try
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter grade:");
                double grade = double.Parse(Console.ReadLine());

                studentService.AddStudent(name, surname, grade);

                Console.WriteLine("Added student successfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }
        }

        public static void MenuUpdateStudent()
        {

            try
            {
                

                Console.WriteLine("For updating student please enter ID:");
                int id =int.Parse(Console.ReadLine());

                var updstudent =  studentService.FindStudentId(id);
                

                Console.WriteLine("Enter new name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter new surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter new grade:");
                double grade = double.Parse(Console.ReadLine());


                updstudent.Name = name;
                updstudent.Surname = surname;
                updstudent.Grade = grade;

                Console.WriteLine("Update student successfuly!");


            }
            catch (Exception ex)
            {

                throw new Exception("Be sure about writing ID!");
            }

        }

        public static void MenuRemoveStudent()
        {
            try
            {
                Console.WriteLine("Enter student's ID:");
                int id = int.Parse(Console.ReadLine());

                studentService.RemoveStudent(id);

                Console.WriteLine("Deleted student successfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }

        }

        public static void MenuFindStudentByName()
        {
            try
            {
                Console.WriteLine("Enter searching student's Name:");
                string name =(Console.ReadLine());
                var search = studentService.GetStudents();
                var matchingName = search.Where(x => x.Name.Equals(name));

                if(search.Count() == 0)
                {
                    Console.WriteLine("No students found!");
                }
                else
                {
                    Console.WriteLine(value: $"Found: {search.Count()} students with the name {name}");
                }
                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Oops, error. {ex.Message}");
            }





        }







    }














}

