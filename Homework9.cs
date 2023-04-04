namespace Homework9;
using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222, "Bob");
        Student cathy = new Student(333, "Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string,double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(gradebook.ContainsKey("Tom")){Console.WriteLine("Tom is in the gradebook");} 
        else {gradebook.Add("Tom", 3.3);}

        double sumOfGPA = 0;
         foreach(var stu in gradebook){
            sumOfGPA += stu.Value;
 }

 double averageOfGPA = sumOfGPA/gradebook.Count;

 Console.WriteLine("The average GPA is: " + averageOfGPA);

 foreach(var stuObject in Student.studentList){
    if(gradebook[stuObject.studentName]>averageOfGPA){
        stuObject.PrintInfo();
    }
 }

 }

    }



 class Student
{
    public int studentid { get; set; }
    public string studentName { get; set; }
    public void PrintInfo(){
        Console.WriteLine($"The student ID is {studentid} and the student's name is {studentName}");
    }
    public static List<Student> studentList= new List<Student>();
    public Student(int userID, string userName){
        studentid = userID;
        studentName = userName;
        studentList.Add(this);
    }
}
