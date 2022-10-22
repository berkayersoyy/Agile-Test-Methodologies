namespace TDD_Code;

public class SalaryCalculator
{
    const int hoursInYear = 2340;
    
    public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * hoursInYear;
    public decimal GetHourlyWage(decimal annualSalary) => annualSalary/hoursInYear;
}

