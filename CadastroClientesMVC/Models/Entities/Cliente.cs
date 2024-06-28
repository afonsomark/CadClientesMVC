namespace CadastroClientesMVC.Models.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Document { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PhoneNumber { get; set; }
    }
}
