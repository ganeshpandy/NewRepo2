using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet
{
     class EmployeeStart
    {

    }


    class Employee
    {
        List<EmployeeRequest> employeesList = new List<EmployeeRequest>();
        public void LoadEmployee()
        {
            employeesList = new List<EmployeeRequest> { new EmployeeRequest() { Id="S1001",CompanyName="SIS",EmployeeEmail="Steve@sis.com",EmployeeName="Steve",EmployeeType="Permenant"} };
        }

        public void CreateEmployee(EmployeeRequest employeeRequest)
        {
            employeesList.Add(employeeRequest);
        }

        public List<EmployeeRequest> ReadEmployee()
        {
         //foreach loop and read it
            return employeesList;
        }

        public void UpdateEmployee(EmployeeRequest employeeRequest)
        {
            // for loop get the emp id
            // find the empid 
            // replace emp id

        }

        public void DeleteEmployee(EmployeeRequest employeeRequest)
        {
            // for loop get the emp id
            // find the empid 
            // Delete  emp id
        }

    }



    class EmployeeRequest
    {

        public string Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeEmail { get; set; }
        public string CompanyName { get; set; }
    }
}


//Notes:
//Create property Class
//Main Class - CompanyMain
//CRUD operation in Main Class
//Static Main - Object Creation , calling methods 

