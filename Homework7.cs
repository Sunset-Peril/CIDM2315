namespace Homework7;
class Program
{
public class HelloWorld
{
    public static void Main(string[] args)
    {
        CustAge alice = new CustAge(28,"Alice", 110);
        CustAge bob = new CustAge(30, "Bob", 111);
        //use bob as objCust input
        alice.PrintCustInfo(bob);
        bob.PrintCustInfo(alice);
        alice.CompareAge(bob);
    }
}  


class CustAge{
    public int cus_age {get;set;} = 0;
    public string cus_name  {get;set;}= string.Empty;
    public int cus_id {get;set;} = 0;
    public CustAge(int cus_age, string cus_name, int cus_id){
        this.cus_age = cus_age;
        this.cus_name = cus_name;
        this.cus_id = cus_id;
    }

 
 public void CompareAge(CustAge objCust){
        if(this.cus_age <= objCust.cus_age){
            Console.WriteLine($"{objCust.cus_name} is older");
        }else{
            Console.WriteLine($"{this.cus_name} is older");
        }
    }

     public void PrintCustInfo(CustAge objCust){
        Console.WriteLine($"Customer ID is: {cus_id}, Customer name is: {cus_name}, Customer age is: {cus_age}");
        this.cus_id =+ this.cus_id + 110;
        Console.WriteLine($"Customer ID is: {cus_id}, Customer name is: {cus_name}, Customer age is: {cus_age}");
    }
}
    }

