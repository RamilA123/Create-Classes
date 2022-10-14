using System;

namespace Create_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1 - Practice - Array

            //int[] arr1 = { 1, 2, 34, 5, 6, 7, 5 };
            ////int[] arr3 = new int[] { 1, 2, 3, 4, 5, 6, 7 };


            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] nums = new int[5];
            //nums[0] = 2;
            //nums[1] = 3;
            //nums[2] = 17;  
            //Array.Resize(ref nums, 20);
            //nums[8] = 11;

            //int[] arr1 = { 1, 2, 34, 5, 6, 7, 5 };

            //Array.Reverse(arr1);
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(arr1);
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //int[,] arr2 = { { 1, 2, 3 }, { 4, 6, 7 } };
            //Console.WriteLine(arr2.Rank);

            //int a = 5;
            //var t = a.ToString();
            //t += 100;
            //Console.WriteLine(a.GetType());
            //Console.WriteLine(t.GetType());
            //Console.WriteLine(t)
            #endregion

            #region Task1 - Practice - Object
            //string stuName1 = "Qoshqar";
            //string stuSurname1 = "Narimanli";
            //int stuAge1 = 29;
            //bool isMarried1 = true;

            //string stuName2 = "Mehemmed";
            //string stuSurname2 = "Mehtiyev";
            //int stuAge2 = 15;
            //bool isMarried2 = false;

            //string stuName3 = "Resul";
            //string stuSurname3 = "Hasanov";
            //int stuAge3 = 15;
            //bool isMarried3 = false;

            //string stuName4 = "Vuqar";
            //string stuSurname4 = "Rustamov";
            //int stuAge4 = 38;
            //bool isMarried4 = true;

            //string stuName5 = "Cavid";
            //string stuSurname5 = "Aliyev";
            //int stuAge5 =25;
            //bool isMarried5 = false;

            //string married = isMarried3 ? "Evlidir" : "Subaydir";
            //Console.WriteLine($"{stuName3} {stuSurname3} {stuAge3}");
            //Console.WriteLine($"{stuName5} {stuSurname5} {stuAge5}");


            //var stu1 = new
            //{
            //    name = "Qoshqar",
            //    surname = "Narimanli",
            //    age = 29,
            //    isMarried = true
            //};

            //var stu2 = new
            //{
            //    name = "Mehemmed",
            //    surname = "Mehtiyev",
            //    age = 15,
            //    isMarried = false
            //};

            //var stu3 = new
            //{
            //    name = "Resul",
            //    surname = "Hasanov",
            //    age = 15,
            //    isMarried = false
            //};

            //var stu4 = new
            //{
            //    name = "Cavid",
            //    surname = "Aliyev",
            //    age = 25,
            //    isMarried = false
            //};

            //Console.WriteLine(stu4.name + " " + stu4.surname + " " + stu4.age);
            //Console.WriteLine($"{stu4.name} {stu4.surname} {stu4.age}");

            //object[] students = { stu1.name, stu2.name, stu3.name, stu4.name };

            //foreach (var item in students)
            //{
            //    Console.WriteLine((item));
            //}
            #endregion

            #region Task2,3,4 - Create Classes
            // Account class ---------- 

            //Account user1 = new Account();
            //Console.WriteLine(user1.Login("cavid123", "Cavid1993"));

            // Factorial class---------

            //Factorial factor1 = new Factorial();
            //Console.WriteLine(factor1.CalculateTheFactorial(12));

            // Calculator class---------

            //Console.Write("Enter a first number: ");
            //float num1 = float.Parse(Console.ReadLine());

            //Console.Write("Enter an operator: ");
            //char ope = char.Parse(Console.ReadLine());

            //Console.Write("Enter a second number: ");
            //float num2 = float.Parse(Console.ReadLine());

            //Calculator cal1 = new Calculator();
            //cal1.Calculation(num1, ope, num2);
            #endregion


            //Car car1 = new Car()
            //{
            //    name = "BMW",
            //    color = "Red",
            //    price = 15000.5,
            //};


            //Car car2 = new Car();
            //car2.name = "Toyota";
            //car2.color = "Black";
            //car2.price = 30000.2;
            //Console.WriteLine(car1.name + " " + car1.color);
            //Console.WriteLine(car2.name + " " + car2.color);

            //Employee emp1 = new Employee();
            //Console.WriteLine(emp1.name + " " + emp1.surname);
            //Console.WriteLine(emp1.GetFullData());

            //Animal animal1 = new Animal("Dog");
            //Console.WriteLine(animal1.name);

            //Employee emp1 = new Employee(false);
            //Console.WriteLine(emp1.GetFullData());
        }
    }
    #region Task1 - Practice - Class, Constructor
    //class Employee
    //{
    //    public string name;
    //    public string surname;
    //    public int age;
    //    public string address;
    //    public bool isMarried;

    //    public Employee(string empName, string empSurname, int empAge)
    //    {
    //        name = empName;
    //        surname = empSurname;
    //        age = empAge;
    //        Console.WriteLine(empName + " " + empSurname);
    //    }


    //    public Employee(int number)
    //    {
    //        Console.WriteLine(number);
    //    }

    //    public Employee():this(33)
    //    {
    //        Console.WriteLine("Hello p414");
    //    }

    //    public Employee(string empAddress):this()
    //    {
    //        address = empAddress;
    //        Console.WriteLine(address);
    //    }

    //    public Employee(bool married):this("ehmedli")
    //    {
    //        isMarried = married;
    //        Console.WriteLine(isMarried);
    //    }

    //public string GetFullName()
    //{
    //    return name + " " + surname;
    //}

    //public string GetFullData()
    //{
    //    return $"{GetFullName()} {age}";
    //}
    //}

    //class car
    //{
    //    public string name;
    //    public string color;
    //    public double price;
    //}

    //class Animal
    //{
    //    public string name;

    //    public Animal(string dogName)
    //    {
    //        name = dogName;
    //    }
    //}
    #endregion
}





