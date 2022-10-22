using TDD_Code;

namespace TDD_Test;

public class TestSalaryCalculator
{
    [Fact]
    public void TestSalaryCalculator_GetAnnualSalary()
    {
        SalaryCalculator salaryCalculator = new SalaryCalculator();

        decimal annualSalary = salaryCalculator.GetAnnualSalary(100);
        
        Assert.Equal(234000,annualSalary);
    }
    [Fact]
    public void TestSalaryCalculator_GetHourlyWage()
    {
        SalaryCalculator salaryCalculator = new SalaryCalculator();

        decimal hourlyWage = salaryCalculator.GetHourlyWage(234000);
        
        Assert.Equal(100,hourlyWage);
    }
}
