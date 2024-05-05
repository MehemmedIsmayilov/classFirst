using System;

namespace ClassFirstWork
{
    class Program
    {
        static void Main(string[] args)
        {
///////////////////////////////////////////////////////////////////////////////////////////////////
            Animal animal = new Animal("Ayi", "BozAyi", "Boz", 5);

            animal.ViewData();
////////////////////////////////////////////////////////////////////////////////////////////////
            Building building = new Building("CodeTowers", 50, 20);

            Console.WriteLine(building.name+" "+building.height+" "+building.area+" "+building.Hecmi());
            ///////////////////////////////////////////////////////////////////////////////////////////////////



            Calculator calculator = new Calculator(25,5);
            calculator.Add();
            calculator.Substract();
            calculator.Multiply();
            calculator.Divide();
        }


    }

    public class Animal
    {
        public string name;
        public string breed;
        public string color;
        public int age;

        public Animal(string name,string breed, string color,int age)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.age = age;
        }
        public void ViewData()
        {
            Console.WriteLine(name+" "+breed+" "+color+" "+age);
        }
    }
    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string adress;


        public Building(string name,int height,int area)
        {
            this.name = name;
            this.height = height;
            this.area = area;          
        }
        public int Hecmi()
        {
            int hecm = height * area;

            return hecm;
        }
    }
    //public class Student
    //{
    //    public string name;
    //    public string surname;
    //    public byte age;
    //    public int[] homevorkGrades;
    //    public int[] projectGrades;
    //    public int[] guizGrades;
    //    public bool[] continuity;

    //    public Student(string name,string surname,byte age, int[] homevorkGrades,int[] projectGrades,int[] guizGrades,bool[] continuity )
    //    {
    //        this.name = name;
    //        this.surname = surname;
    //        this.age = age;
    //        this.homevorkGrades = homevorkGrades;
    //        this.projectGrades = projectGrades;
    //        this.guizGrades = guizGrades;
    //        this.continuity = continuity;
    //    }
    //    public int ContinuityPoint(int[] truePoint)
    //    {
    //        if (continuity==true)
    //        {
    //            int point = continuity.Length / 10 * 100;
                
    //        }

    //        return point;
    //    }
    //    public int FinalGrade()
    //    {
    //        int finalGrades=
            
    //    }
    //}
    public class Calculator
    {
        public int a;
        public int b;
        public Calculator(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Add()
        {
            Console.WriteLine(a + b);
            
           
        }
        public void Substract()
        {
            Console.WriteLine(a - b);
            
        }
        public void Multiply()
        {
            Console.WriteLine(a*b);
        }
        public void Divide()
        {
            Console.WriteLine(a/b);
        }
    }
}
