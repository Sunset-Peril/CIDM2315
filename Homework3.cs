namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        //Question 2 must be commented out for Question 3 to work, and vise versa.

        //Question 1
        Console.WriteLine("Input an integer");
        string input = Console.ReadLine();
        int num = Convert.ToInt16(input);

        if (num < 2)
        {
            Console.WriteLine("N is not prime");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if(isPrime){
            Console.WriteLine("N is prime");
        } else {
            Console.WriteLine("N is not prime");
        }
        //Question 2
        for(int row = 0; row<5; row++){
    for(int col = 0; col<5; col++)
    {
        Console.Write('#');
    }
    Console.WriteLine(""); 

    //Question 3
      for(int row = 0; row<5; row++){
    for(int col = 0; col<5; col++)
    {
        if(row>=col)
            Console.Write('*');
    }
    Console.WriteLine("");
}

    }
}
}


