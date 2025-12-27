/*
In class FullTimeEmployee : EmployeeRecord, implement the below-given public properties.
Datatype	Properties
double	HourlyRate
double	MonthlyBonus
Override GetMonthlyPay() to return:
(Sum of all WeeklyHours × HourlyRate) + MonthlyBonus
*/

class FullTimeEmployee : EmployeeRecord
{
    public double HourlyRate;
    public double MonthlyBonus;

    public override double GetMonthlyPay()
    {
        return (WeeklyHours.Sum() * HourlyRate)+MonthlyBonus;
    }
}