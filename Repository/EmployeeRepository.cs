using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using NCC.Models;
 
namespace NCC.Repository
{
    public class EmployeeRepository
    { 
        public List<Employee> GetAllEmployee(){
            return DataSource();
        }

        public Employee GetEmployeeById(int id){
            return DataSource().Where(x=>x.EmployeeId == id).FirstOrDefault();
        }

        public List<Employee> DataSource(){
            return new List<Employee>(){
                new Employee(1,"Sarila<3",10),
                new Employee(2,"Ngakhusi<3",55),
                new Employee(3,"Haha",3000)
            };
        }
    }
}