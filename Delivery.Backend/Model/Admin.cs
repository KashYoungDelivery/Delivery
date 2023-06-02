namespace Delivery.Backend.Model
{

    public class Admin
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Client Client_Id { get; set; }
        public Product Product_Id { get; set; }
        public string? Password { get; set; }

    }
}
