namespace ChainOfResponsibility.Models
{
    public class CustomerViewModel
    {
        public int CustomerProcessId { get; set; }
        public string Name { get; set; }
        public string EmployeeName { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
