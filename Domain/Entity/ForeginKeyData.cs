using System;
using System.ComponentModel.DataAnnotations;

namespace EnergoStatApi.Domain.Entity
{
    public class ForeginKeyData : Key
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateConnect { get; set; }

        public string DissconetToken { get; set; }
    }

    public interface Key
    {
        public int Id { get; set; }
    }
}
