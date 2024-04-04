namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            int input;

            Console.WriteLine("Enter user information:");
            Console.Write("ID: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fullname: ");
            string FulName = Console.ReadLine();
            Console.Write("Point: ");
            int Point = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Show info: ");
                Console.WriteLine("2.Create new group: ");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Student student1 = new Student();
                        student1.StudentInfo();

                        break;
                    case 2:
                        Group group = Creategroup();

                        int input2;
                        do
                        {

                            Console.WriteLine("1. Show all students: ");
                            Console.WriteLine("2. Get student by id:");
                            Console.WriteLine("3. Add student: ");
                            Console.WriteLine("0. Quit:");
                            input2 = Convert.ToInt32(Console.ReadLine());

                            switch (input2)
                            {
                                case 1:
                                    group.GetAllStudents();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter student Id:");
                                    int id = Convert.ToInt32(Console.ReadLine());
                                    Student student = group.GetStudent(Id);
                                    student.StudentInfo();
                                    break;
                                case 3:

                                    Student Student2 = Createstudent();
                                    group.AddStudent(Student2);
                                    break;
                                case 0:
                                    exit = false;
                                    break;
                            }

                        } while (exit != false);

                        break;
                }
            } while (input != 0);
        }

        static Group Creategroup()
        {
            Group group1 = new Group();
            Console.WriteLine("Student GroupNo:");
            group1.GroupNo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Studentlimit:");
            group1.StudentLimit = Convert.ToInt32(Console.ReadLine());
            return group1;
        }

        static Student Createstudent()
        {
            Student student1 = new Student();
            Console.WriteLine("Student FullName:");
            student1.Fullname = Console.ReadLine();
            Console.WriteLine("Student Point:");
            student1.Point = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Id");
            student1.Id = Convert.ToInt32(Console.ReadLine());
            return student1;
        }
    }
    
}
