namespace ProjTurismoAPIEF.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fone { get; set; }
        public Address Address { get; set; }
        public DateTime DtCadstre { get; set; }
    }
}
