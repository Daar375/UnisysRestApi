using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnisysRestApi.Models
{
    [Table("movie")]
    public partial class Movie
    {
        public Movie()
        {
            Favorite = new HashSet<Favorite>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("Movie")]
        public virtual ICollection<Favorite> Favorite { get; set; }
    }
}
