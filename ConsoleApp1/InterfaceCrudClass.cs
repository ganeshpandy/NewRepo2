using System;

namespace SISTrainingDotNet
{
    class InterfaceCrudClass
    {
        //object creation 

    }



    class ParentCompany : ICompany
    {
        public void CreateCompany()
        {
            throw new NotImplementedException();
        }

        public void DeleteCompany()
        {
            throw new NotImplementedException();
        }

        public void LoadCompany()
        {
            throw new NotImplementedException();
        }

        public void ReadCompany()
        {
            throw new NotImplementedException();
        }

        public void UpdateCompany()
        {
            throw new NotImplementedException();
        }
    }


    public class VendorCompany : ICompany
    {
        public void CreateCompany()
        {
            throw new NotImplementedException();
        }

        public void DeleteCompany()
        {
            throw new NotImplementedException();
        }

        public void LoadCompany()
        {
            throw new NotImplementedException();
        }

        public void ReadCompany()
        {
            throw new NotImplementedException();
        }

        public void UpdateCompany()
        {
            throw new NotImplementedException();
        }
    }


    public class SisterCompany : ICompany
    {
        public void CreateCompany()
        {
            throw new NotImplementedException();
        }

        public void DeleteCompany()
        {
            throw new NotImplementedException();
        }

        public void LoadCompany()
        {
            throw new NotImplementedException();
        }

        public void ReadCompany()
        {
            throw new NotImplementedException();
        }

        public void UpdateCompany()
        {
            throw new NotImplementedException();
        }
    }


    interface ICompany
    {
        void LoadCompany();
        void CreateCompany();
        void UpdateCompany();
        void ReadCompany();
        void DeleteCompany();
    }
}
