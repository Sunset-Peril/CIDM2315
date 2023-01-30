namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        //Question One
        Console.WriteLine("Please enter a letter grade: ");
        string letter = Console.ReadLine();
        if(letter=="A"){
            Console.WriteLine("GPA Points: 4");
        } else if(letter=="B"){
            Console.WriteLine("GPA Points: 3");
        } else if(letter=="C"){
            Console.WriteLine("GPA Points: 2");
        } else if(letter=="D"){
            Console.WriteLine("GPA Points: 1");
        } else if(letter=="F"){
            Console.WriteLine("GPA Points: 0");
        } else{
            Console.WriteLine("Wrong Letter Grade!");
        }

        //Question Two
         Console.WriteLine("Please enter the first number: ");
         string numOneString = Console.ReadLine();
         int numOne = Convert.ToInt16(numOneString);
         Console.WriteLine("Please enter the second number: ");
         string numTwoString = Console.ReadLine();
         int numTwo = Convert.ToInt16(numTwoString);
         Console.WriteLine("Please enter the third number: ");
         string numThrString = Console.ReadLine();
         int numThr = Convert.ToInt16(numThrString);
         if(numOne<numTwo){
            if(numOne<numThr){
                Console.WriteLine($"The smallest number is {numOne}");
            } else{
                Console.WriteLine($"The smallest number is {numThr}");
            }
         } else{
            if(numTwo<numThr){
                Console.WriteLine($"The smallest number is {numTwo}");
            } else{
                Console.WriteLine($"The smallest number is {numThr}");
            }
         }
    }
}
