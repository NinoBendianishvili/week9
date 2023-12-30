namespace homework9;

public abstract class Student2
{
    public String name;

    protected Student2(string name)
    {
        this.name = name;
    }

    public abstract void study();
    public abstract void read();
    public abstract void write();
    public abstract void relax();
}