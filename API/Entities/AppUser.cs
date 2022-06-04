namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } // Id or ID : primary key per default for entity framework
        public string UserName { get; set; } //UserName : less refactoring
    }
}