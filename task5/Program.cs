using System;

class Student
{
    static int nextId = 1;

    public string Name;
    public int StudentId;
    public double GPA;
    public string Faculty;

    public Student(string name, double gpa, string faculty)
    {
        StudentId = nextId;
        Name = name;    
        Faculty = faculty;

        nextId++;

        if (gpa >= 0.0 && gpa <= 4.0)
        {
            GPA = gpa;
        }
        else
        {
            GPA = 0.0;
            Console.WriteLine("invalid gpa, defaulting to 0.0");
        }
    }

    public void Print()
    {
        Console.WriteLine($"id: {StudentId}, name: {Name}, gpa: {GPA}, faculty: {Faculty}");
    }
}

class Registry
{
    Student[] students = new Student[100];
    int count = 0;

    public void Add(Student student)
    {
        if (count < 100)
        {
            students[count] = student;
            count++;
            Console.WriteLine("student added");
        }
        else
        {
            Console.WriteLine("registry is full");
        }
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
            {
                return students[i];
            }
        }

        return null;
    }

    public void FindByName(string name)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (students[i].Name.ToLower() == name.ToLower())
            {
                students[i].Print();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"no students named {name} found");
        }
    }

    public void GetTopStudents(int n)
    {
        Student[] temp = new Student[count];

        for (int i = 0; i < count; i++)
        {
            temp[i] = students[i];
        }

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (temp[i].GPA < temp[j].GPA)
                {
                    Student swap = temp[i];
                    temp[i] = temp[j];
                    temp[j] = swap;
                }
            }
        }

        if (n > count)
        {
            Console.WriteLine($"{n} is too big, making top {count} instead");
            n = count;
        }

        for (int i = 0; i < n; i++)
        {
            temp[i].Print();
        }
    }

    public void PrintAll()
    {
        if (count == 0)
        {
            Console.WriteLine("registry is empty");
        }

        for (int i = 0; i < count; i++)
        {
            students[i].Print();
        }
    }
}

class Program
{
    static void Main()
    {
        Registry registry = new Registry();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. add a new student");
            Console.WriteLine("2. find a student by ID");
            Console.WriteLine("3. find students by name");
            Console.WriteLine("4. top n students");
            Console.WriteLine("5. print all students");
            Console.WriteLine("6. exit");
            Console.Write("choose: ");

            string choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                Console.Write("enter name: ");
                string name = Console.ReadLine();

                Console.Write("enter GPA: ");
                double gpa;
                bool validDouble = double.TryParse(Console.ReadLine(), out gpa);
                if (!validDouble)
                {
                    Console.WriteLine("invalid gpa, defaulting to 0.0");
                    gpa = 0.0;
                }

                Console.Write("enter faculty: ");
                string faculty = Console.ReadLine();

                Student student = new Student(name, gpa, faculty);

                registry.Add(student);
            }
            else if (choice == "2")
            {
                Console.Write("enter id: ");
                int id;
                bool validId = int.TryParse(Console.ReadLine(), out id);
                if (validId)
                {
                    Student student = registry.FindById(id);

                    if (student != null)
                    {
                        student.Print();
                    }
                    else
                    {
                        Console.WriteLine("student not found");
                    }
                }
                else
                {
                    Console.WriteLine("invalid id");
                }
            }
            else if (choice == "3")
            {
                Console.Write("enter name: ");
                string name = Console.ReadLine();

                registry.FindByName(name);
            }
            else if (choice == "4")
            {
                Console.Write("how many top students: ");
                int n;
                bool validN = int.TryParse(Console.ReadLine(), out n);

                if (validN)
                {
                    registry.GetTopStudents(n);
                }
                else
                {
                    Console.WriteLine("invalid number");
                }
            }
            else if (choice == "5")
            {
                registry.PrintAll();
            }
            else if (choice == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("invalid choice");
            }
        }
    }
}
