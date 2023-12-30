namespace homework9;

public class Teacher
{
    private string name;
    private bool iscertified;

    public Teacher(string name, bool iscertified)
    {
        this.name = name;
        this.iscertified = iscertified;
    }

    public void response(Student stud)
    {
        String subject = stud.randomsubject();
        switch (subject)
        {
            case "chemistry": Console.WriteLine("H2O");
                break;
            case "english": Console.WriteLine("Lorem Ipsum");
                break;
            case "maths": Console.WriteLine("9 + 3 = 12");
                break;
            default: Console.WriteLine("not competent in this subject, sorry");
                break;
        }
    }
}