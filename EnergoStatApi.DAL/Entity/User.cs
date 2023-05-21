namespace EnergoStatApi.DataAccess.Entity
{
    public class User
    {
        public long Id { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string AccessToken { get; set; }
    }
}
