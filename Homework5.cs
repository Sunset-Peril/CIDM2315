namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        //Question One
        Console.Write("Enter integer ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter integer ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine(Largestof(x,y));

        //Question Two
         Console.Write("Enter integer ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter integer ");
        int b = int.Parse(Console.ReadLine());

         Console.Write("Enter integer ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Enter integer ");
        int d = int.Parse(Console.ReadLine());

        int max1 = Largestof(a,b);

        int max2 = Largestof(c,d);

        int bigmax = Largestof(max1,max2);

        Console.WriteLine(bigmax);

        //Question Three
    createAccount();

    }
    

    //Method for Q1/Q2
    static int Largestof(int x, int y){
        return x>y ? x : y;
    }
    //Methods for Q3
    static bool Agecheck(int birthyear){
        if(2022 - birthyear >= 18){
            return true;
        } else {
            return false;
        }
    }

    static void createAccount(){
        Console.Write("Enter your birth year - ");
        int birthyear = int.Parse(Console.ReadLine());

        Console.Write("Enter your username ");
        string username = Console.ReadLine();

        Console.Write("Enter your password ");
        string password = Console.ReadLine();

        Console.Write("Repeat password ");
        string passwordpt2 = Console.ReadLine();

        bool isOldEnough = Agecheck(birthyear);

        if(isOldEnough == true){
            if(password == passwordpt2){
                Console.WriteLine("Account created successfully");
            } else{
                Console.WriteLine("Passwords do not match");
            }
        } else {
            Console.WriteLine("Could not create account");
        }
    }

}
    

