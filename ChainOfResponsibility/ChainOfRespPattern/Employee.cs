using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfRespPattern
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee employee)
        {
            this.NextApprover = employee;
        }
        public abstract void ProcessRequest(CustomerViewModel customerViewModel);
    }
}
