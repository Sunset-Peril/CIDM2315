namespace Homework8;
class Program
{
    static void Main(string[] args)
    {
         // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }

    public static void ArraySum(int[] int_array){
        int sum = 0;
        foreach (var k in int_array){
            sum += k;
        }

        Console.WriteLine("The sum is " + sum);

    }

    public static void PrintAllOddNumber(int[ , ] array_2d){

            for (int row = 0; row < 3; row++) {
        for (int col = 0; col<=2; col++) {
        if(array_2d[row,col]%2!=0){
            Console.Write(array_2d[row, col]+" ");
        }
        }


       
    }}
    //Q2.2: given a 2d array, return the sum of all elements (2 points)
    
     public static int ElementSum(int[ , ] array_2d){
         int sum = 0;

        foreach (var val in array_2d){
            sum += val;
        }

        return sum;

    }


    // Q2.3: given a 2d array, double its element values and return it (2 points)
     static int[ , ] DoubleArray(int[ , ] array_2d){
         //put your answer below
    for(int i = 0 ; i < 3 ; i++)
{ 
    for(int j =  0; j<3; j++){
        array_2d[i, j] *= 2;}
} return array_2d;
}

       
    } 



