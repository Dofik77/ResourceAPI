using System.ComponentModel.DataAnnotations;

namespace EnergoStatApi.Domain.Entity
{
    public class RegistationModel
    {
        [Key]
        public int Id { get; set; }

        public string User_name { get; set; }

        public string Password { get; set; }

        public ForeginKeyData ForeginKeyData { get; set; }
    }
}
