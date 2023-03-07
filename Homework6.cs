namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        Console.WriteLine($"Professor {p1.profName} teaches {p1.classTeach}, and her salary is: {p1.GetSalary()}" );

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000); 
        Console.WriteLine($"Professor {p2.profName} teaches {p2.classTeach}, and his salary is: {p2.GetSalary()}" );

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        Console.WriteLine($"{s1.studentName} is enrolled in {s1.classEnroll}, and her grade is: {s1.GetGrade()}" );

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80); 
        Console.WriteLine($"{s2.studentName} is enrolled in {s2.classEnroll}, and his grade is: {s2.GetGrade()}" );

        double money1 = p1.GetSalary();
        double money2 = p2.GetSalary();

        double difference = money1 - money2;

        double g1 = s1.GetGrade();
        double g2 = s2.GetGrade();

        double total = g1 + g2;

        Console.WriteLine($"The salary difference between{p1.profName} and {p2.profName} is {difference} ");
        Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is {total}");
    }
}

class Professor { 
    public string profName;
    public string classTeach;
    double salary;

     public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
    }

}

class Student {
    public string studentName;
    public string classEnroll;
    private double studentGrade= 0;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }

}
