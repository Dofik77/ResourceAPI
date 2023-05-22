using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EnergoStatApi.Domain.Entity
{
    public class LoginModel
    {
        public string Name { get; set; }

        public string Password { get; set; }
    }
}
