using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfRespPattern
{
    public class Manager : Employee
    {
        private readonly Context _context;

        public Manager(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerViewModel customerViewModel)
        {
            if (customerViewModel.Amount <= 250000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Metehan Sözen";
                customerProcess.Description = "Talep edilen tutar şube müdürü tarafından ödendi";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Metehan Sözen";
                customerProcess.Description = "Talep edilen tutar şube müdürü tarafından ödenemedi, işlem bölge müdürüne aktarıldı";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(customerViewModel);
            }
        }
    }
}
