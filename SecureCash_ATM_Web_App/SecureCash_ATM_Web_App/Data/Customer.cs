namespace SecureCash_ATM_Web_App.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string  CardNum { get; set; }
        public int Pin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
    }
}
