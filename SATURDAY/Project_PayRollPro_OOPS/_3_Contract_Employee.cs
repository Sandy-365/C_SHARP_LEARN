/*
In class ContractEmployee : EmployeeRecord, implement the below-given public property.
Datatype	Properties
double	HourlyRate
Override GetMonthlyPay() to return:
(Sum of all WeeklyHours × HourlyRate)
*/

class ContractEmployee : EmployeeRecord
{
    public double HourlyRate { get; set; }
    public override double GetMonthlyPay()
    {
        return (WeeklyHours.Sum() * HourlyRate);
    }
}