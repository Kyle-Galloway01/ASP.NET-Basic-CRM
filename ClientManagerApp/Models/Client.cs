namespace ClientManagerApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } 
        public bool IsActive { get; set; }
        public string? Contact {  get; set; }

        public Client()
        {
            Name = "";
        }
    }
}
