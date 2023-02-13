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
        /*Used https://dotnettutorials.net/lesson/mirrored-right-angle-triangle-star-pattern-csharp/
         for assistance setting up the "right" triangle nested logic */

        Console.WriteLine("Row number: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Shape type: ");
        string shaping=Console.ReadLine();

        if(shaping=="left"){
        for(int a = 0; a<rows; a++){
    for(int b = 0; b<rows; b++)
    {
        if(a>=b)
            Console.Write('*');
    }
    Console.WriteLine("");
}

    } if (shaping=="right"){
        for (int a = 1; a <= rows; a++)
        {
            for (int b = rows - a; b >= 1; b--) 
            {
                Console.Write(" ");
            }
            for (int c = 1; c <= a; c++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }

    
    }

    //Method for Question One
    static int Largestof(int x, int y){
        return x>y ? x : y;
    }
    }

