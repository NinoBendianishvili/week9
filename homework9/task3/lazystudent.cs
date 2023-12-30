namespace homework9;

public class lazystudent : Student2
{
    public lazystudent(string name) : base(name)
    {
    }

    public override void study()
    {
        Console.WriteLine("this student does not study much");
    }

    public override void read()
    {
        Console.WriteLine("this student does not read much");
    }

    public override void write()
    {
        Console.WriteLine("this student does not write much");
    }

    public override void relax()
    {
        Console.WriteLine("this student relaxes a lot");
    }
}