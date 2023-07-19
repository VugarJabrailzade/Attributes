using System;


namespace TaskNew
{
    

    class Program
    {
        static void Main(string[] args)
        {

            int option;
            do
            {
                Console.WriteLine("1. Show Student:");
                Console.WriteLine("2. Add Student:");
                Console.WriteLine("3. Update Student:");
                Console.WriteLine("4. Remove Student:");
                Console.WriteLine("5. Find student by Name:");
                Console.WriteLine("0. Exit!");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("-------------------------");

                while(!int.TryParse(Console.ReadLine(), out option));

                switch (option)
                {
                    case 1: MenuService.MenuShowStudent();
                        break;
                    case 2: MenuService.MenuAddStudent();
                        break; 
                    case 3: MenuService.MenuUpdateStudent();
                        break; 
                    case 4: MenuService.MenuRemoveStudent();
                        break; 
                    case 5: MenuService.MenuFindStudentByName();
                        break; 
                    case 0:
                        break;
                    default:
                        break;
                }

            } while (option != 0);










        }
    }



}