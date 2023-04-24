namespace ProjTurismoAPIEF.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Address Origin { get; set; }
        public Address Destination { get; set; }
        public Client Client { get; set; }
        public DateTime DtTicket { get; set; }
        public decimal Value { get; set; }
    }
}
