using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Lessee
    {
        public int Id { get; set; }

        //Esta relación me trae los datos de User, que a la vez hereda de EntityUser
        public User User { get; set; }

        public ICollection<Contract> Contracts { get; set; }


    }
}

