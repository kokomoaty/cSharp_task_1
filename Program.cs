using System;
    namespace Program;
    abstract class Person{
                public string Name;
                public int Age;
                public Person(string name,int age){
                    Name=name;
                    Age=age;
                }
                public abstract void Print();
            }
    class Student:Person{
        public int Year;
        public float GPA;
        public Student(string name,int age,int year,float gpa):base(name,age){
            Year=year;
            GPA=gpa;
        }
        public override void Print(){
            Console.WriteLine("My name is " + Name + ", my age is " + Age + " and my gpa is " + GPA);
        }
    }
    class Database{
        int currentIndex=0;
        Person[] People=new Person[50];
        public void addStudnet(Student student){
            People[currentIndex++]=student;
            student.Print();
        }
    }
    class MainClass{
        public static void Main(){
            Console.WriteLine("enter the studnet name: ");
            string name=Console.ReadLine();
            Console.WriteLine("enter the studnet age: ");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the studnet year: ");
            int year=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the studnet gpa: ");
            float gpa=float.Parse(Console.ReadLine());
            Database database=new Database();
            Student student=new Student(name,age,year,gpa);
            database.addStudnet(student);
        }
    }
