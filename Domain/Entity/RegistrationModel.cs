using System.ComponentModel.DataAnnotations;

namespace EnergoStatApi.Domain.Entity
{
    public class RegistrationModel
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string AccessToken { get; set; }
    }
}
