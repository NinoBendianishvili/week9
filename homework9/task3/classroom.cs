namespace homework9;

public class classroom
{
    private List<Student2> students;

    public classroom(List<Student2> students)
    {
        this.students = students;
    }

    public void activities()
    {
        for (int i = 0; i < students.Count; i++)
        {
            students[i].study();
            students[i].read();
            students[i].write();
            students[i].relax();
        }
    }
}