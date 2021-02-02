using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NCC.Models;
using Microsoft.AspNetCore.Mvc;
using NCC.Repository;

namespace NCC.Controllers
{
    public class EmployeeController
    {
        EmployeeRepository emp = new EmployeeRepository();
         public List<Employee> Index()
        { 
            return emp.GetAllEmployee();
        } 
        public Employee id(int id){
            return emp.GetEmployeeById(id);
        }



    }
}