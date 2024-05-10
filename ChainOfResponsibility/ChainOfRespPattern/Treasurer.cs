using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfRespPattern
{
    public class Treasurer : Employee
    {
        private readonly Context _context ;

        public Treasurer(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerViewModel customerViewModel)
        {
            if (customerViewModel.Amount <= 80000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Talha Yıldız";
                customerProcess.Description = "Talep edilen tutar veznedar tarafından ödendi";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null) 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Talha Yıldız";
                customerProcess.Description = "Talep edilen tutar veznedar tarafından ödenemedi, işlem şube müdür yardımcısına aktarıldı";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(customerViewModel);
            }
        }
    }
}
