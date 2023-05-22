namespace EnergoStatApi.DataAccess.Entity
{
    /// <summary>
    /// Хранение данных об авторизации на одну сессию
    /// </summary>
    public class AuthenticationUser
    {
        public int Id { get; set; }
        
        public User AuthenticatedUser { get; set; }

        public DateTime DateTimeAuth { get; set; }
    }
}
