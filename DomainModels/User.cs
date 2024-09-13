namespace DomainModels
{
    public class User : BaseClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool ConfirmedEmail { get; set; } = false;
    }
}
