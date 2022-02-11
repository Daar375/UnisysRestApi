using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnisysRestApi.Models
{
    [Table("client")]
    public partial class Client
    {
        public Client()
        {
            Favorite = new HashSet<Favorite>();
        }

        [Key]
        [Column("id_card")]
        public int IdCard { get; set; }
        [Required]
        [Column("name")]
        [StringLength(15)]
        public string Name { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(15)]
        public string LastName { get; set; }

        [InverseProperty("Client")]
        public virtual ICollection<Favorite> Favorite { get; set; }
    }
}
