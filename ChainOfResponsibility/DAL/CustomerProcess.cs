namespace ChainOfResponsibility.DAL
{
    public class CustomerProcess
    {
        public int CustomerProcessId { get; set; }
        public string Name { get; set; }
        public string EmployeeName { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
