using System;
//2.1
public class Customer
{
    public string Name { get; set; }
    public string Purchase { get; set; }
    public Gen Gender { get; set; }
    public enum Gen { Unknown, Male, Female }
    //2.2
    public Customer(string n, string p, Gen g)
    {
        Name = n;
        Purchase = p;
        Gender = g;
    }
    //2.3
    public void Thanks()
    {
        Console.WriteLine($"Thank you for purchasing our {Purchase}, {Name}.");
    }
    //2.4
    public void SendSaleNotice(DateTime d)
    {
        Console.WriteLine($"{Name}, we just wanted to let you know there is a sale coming up on {d.Date.ToString("d")}.");
    }
    public void SendSaleNotice(DateTime d, string p)
    {
        Console.WriteLine($"{Name}, we just wanted to let you know there is a sale coming up on {d.Date.ToString("d")} for {p}s.");
    }
    //2.9
    public virtual void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name}, {Purchase}, {Gender}");
    }
}
//2.5
sealed public class InactiveCustomer : Customer
{
    public int MonthsInactive { get; set; }
    //2.11
    public Rea Reason { get; set; }
    //2.10
    public enum Rea { Irate, Moved, Uninterested }
    //2.6
    public InactiveCustomer(string n, string p, Gen g, int m) : base(n, p, g)
    {
        MonthsInactive = m;
    }
    //2.7
    public void InactiveMessage()
    {
        Console.WriteLine($"Hey {Name}. You bought {Purchase} {MonthsInactive} months ago. Come back.");
    }
    public override void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name}, {Purchase}, {Gender}, {MonthsInactive}, {Reason}");
    }
}

//2.8 - Did this in C# interactive but here it is
var x = new Customer("Blake", "Guatemala. The country. Yes.", Customer.Gen.Male);
x.Thanks();
x.SendSaleNotice(DateTime.Today, "Puerto Rico");
x.PrintCustomerInfo();

var y = new InactiveCustomer("Blake", "Insanely illegal things", Customer.Gen.Male, 4);
y.InactiveMessage();
y.Reason = InactiveCustomer.Rea.Uninterested;
y.PrintCustomerInfo();
