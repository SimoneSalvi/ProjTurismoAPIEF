namespace ProjTurismoAPIEF.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Stret { get; set; } //Logradouro
        public string Neighborhood { get; set; } //Bairro
        public int Number { get; set; } //Numero
        public string ZipCode { get; set; } //CEP
        public string Complement { get; set; }
        public City City { get; set; }
        public DateTime DtCadastre { get; set; } //Data_Cadastro

    }
}
