using ChainOfResponsibility.DAL;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.ChainOfRespPattern
{
    public class AreaDirector :Employee
    {
        private readonly Context _context;

        public AreaDirector(Context context)
        {
            _context = context;
        }

        public override void ProcessRequest(CustomerViewModel customerViewModel)
        {
            if (customerViewModel.Amount <= 360000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Buse Nur Demirbaş";
                customerProcess.Description = "Talep edilen tutar bölge müdürü tarafından ödendi";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Name = customerViewModel.Name;
                customerProcess.Amount = customerViewModel.Amount;
                customerProcess.EmployeeName = "Buse Nur Demirbaş";
                customerProcess.Description = "Talep edilen tutar bölge müdürü tarafından ödenemedi, işlem gerçekleştirilemedi";
                _context.CustomerProcess.Add(customerProcess);
                _context.SaveChanges();
            }
        }
    }
}
