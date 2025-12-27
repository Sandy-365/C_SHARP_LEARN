/*
1) Class Design (OOPS Requirement)
In class EmployeeRecord (Abstract Base Class), implement the below-given public properties. 
    Datatype	            Properties
    string	                EmployeeName
    double[]    	        WeeklyHours
Also, implement the below-given public abstract method:
    
    public abstract double GetMonthlyPay();
*/
abstract class EmployeeRecord
{
    public string EmployeeName { get; set; }
    public double[] WeeklyHours { get; set; }

    public abstract double GetMonthlyPay();
}


