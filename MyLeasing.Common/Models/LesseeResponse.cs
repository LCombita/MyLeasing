namespace MyLeasing.Common.Models
    // selecciono los datso que quiero del arrendatario
{
    public class LesseeResponse
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Document { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
