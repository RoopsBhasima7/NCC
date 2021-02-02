namespace NCC.Models
{
    public class Employee
    {
        public int EmployeeId {get;set;}
        public string EmployeeName {get;set;}
        public float EmployeeSalary {get;set;}

        public Employee(int a,string b, float c){
            EmployeeId =a;
            EmployeeName =b;
            EmployeeSalary = c;
        }

    }
}