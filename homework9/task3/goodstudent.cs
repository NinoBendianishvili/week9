namespace homework9;

public class goodstudent : Student2
{
    public goodstudent(string name) : base(name)
    {
    }

    public override void study()
    {
        Console.WriteLine("this student studies a lot");
    }

    public override void read()
    {
        Console.WriteLine("this reads studies a lot");
    }

    public override void write()
    {
        Console.WriteLine("this writes studies a lot");
    }

    public override void relax()
    {
        Console.WriteLine("this student does not relax a lot");
    }
}