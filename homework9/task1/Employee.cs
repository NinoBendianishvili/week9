namespace homework9;

public class Employee
{
    private string name;
    private string surname;
    private int age;
    private position position;
    private int[] workedhours;

    public Employee(string name, string surname, int age, position position, int[] workedhours)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.position = position;
        this.workedhours = workedhours;
    }

    public double salaryperweek()
    {
        int salary = (int)position;
        double sum = 0;
        int totalhours = 0;
        for (int i = 0; i < workedhours.Length; i++)
        {
            int perday = workedhours[i];
            totalhours += perday;
            if (i > 5)
            {
                if (perday > 8) sum = sum + 8 * salary + (perday - 8) * 5;
                else sum += perday * salary;
            }
            else sum += perday * 2 * salary;
        }

        if (totalhours > 50) sum += sum * 0.2;
        return sum;
    }
    
}
public enum position
{
    MANAGER=40, // 40
    DEVELOPER=30, // 30
    TESTER=20, // 20
    OTHER=10 // 10
}
