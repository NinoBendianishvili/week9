namespace homework9;

public class Company
{
    private bool islocal;
    private static double totalmoney;

    public Company(bool islocal)
    {
        this.islocal = islocal;
    }

    public void taxcounter(Employee e)
    {
        if (this.islocal) totalmoney += e.salaryperweek() * 0.18;
        else totalmoney += e.salaryperweek() * 0.05;
    }

    public double totalmoneygetter()
    {
        return totalmoney;
    }
    
    
}