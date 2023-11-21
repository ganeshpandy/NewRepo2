using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTrainingDotNet
{
     class GenericListFirst
    {
        //static void Main(string[] args)
        //{
        //    Company company = new Company();
        //    List<CompanyInput> objList = company.LoadCompany();
        //    company.DisplayCompany(objList);

        //}
    }



    public class Company
    {
        public List<CompanyInput> LoadCompany()
        {
            List<CompanyInput> list = new List<CompanyInput>()
            {
                new CompanyInput() {Id="S1001",Name="SIS-India",Address="SIS-India", Description="SIS-India is Service Company"},
                new CompanyInput() {Id="S1002",Name="SIS-US",Address="SIS-US", Description="SIS-US is Service Company"},
                new CompanyInput() {Id="S1003",Name="SIS-Polland",Address="SIS-Polland", Description="SIS-Polland is Product Company"}
            };

            return list;
        }


        public void DisplayCompany(List<CompanyInput> companyInputs)
        {
           if(companyInputs != null && companyInputs.Count > 0)
            {
                foreach (var companyReq in companyInputs)
                {
                    Console.WriteLine("Emp Id :" + companyReq.Id);
                    Console.WriteLine("Emp Name :" + companyReq.Name);
                    Console.WriteLine("Emp Description :" + companyReq.Description);
                    Console.WriteLine("Emp Address :" + companyReq.Address);
                }
            }
            
            
        }
    }


    public class CompanyInput
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Address { get; set; }

    }

}
