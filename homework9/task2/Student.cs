namespace homework9;

public class Student
{
    private string name;
    private int age;
    private int cohort;
    static private String[] subjects = { "chemistry", "maths", "english", "physics", "C# & .NET" };

    public Student(string name, int age, int cohort)
    {
        this.name = name;
        this.age = age;
        this.cohort = cohort;
    }

    public int yearsleft()
    {
        return cohort + 4 - DateTime.Now.Year;
    }

    public String randomsubject()
    {
        Random rand = new Random();
        int index = rand.Next();
        return subjects[index];
    }
    
}