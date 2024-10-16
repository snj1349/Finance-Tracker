class Account
{
    private static double Balance=0;

    public Account(int x)
    {
        Balance += x;
    }

    public void debit(int Amount)
    {
        if(Amount> Balance)
        {
            Console.WriteLine("Invalid transaction");
            Console.WriteLine("low balance");
        }
        else
        {
            Balance -= Amount;
            ShowStatement(Amount, "Debit");
        }
    }
    public void credit(int Amount)
    {
        Balance += Amount;
        ShowStatement(Amount, "Credit");
    }
    public static void ShowStatement(int amount, string Transtype)
    {
        DateTime currentDateTime = DateTime.Now;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Transaction Details :- ");
        Console.WriteLine("Date & Time :- "+ currentDateTime);
        Console.WriteLine("Transaction type :- "+ Transtype);
        Console.WriteLine("Transcation Amount - "+ amount);
        Console.WriteLine("balance left - "+ Balance);
        Console.ResetColor();

    }
}
class Program
{
    public static void Main(string[] args)
    {
        //Account obj= new Account(1000);
        //obj.credit(1000);
        //obj.debit(375);
        Account Abhi= new Account(164);
        Abhi.credit(4896);
        Abhi.debit(2424);
        Abhi.debit(96);
    }
}