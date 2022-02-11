using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnisysRestApi.Models
{
    [Table("favorite")]
    public partial class Favorite
    {
        [Key]
        [Column("client_id")]
        public int ClientId { get; set; }
        [Key]
        [Column("movie_id")]
        public int MovieId { get; set; }

        [ForeignKey(nameof(ClientId))]
        [InverseProperty("Favorite")]
        public virtual Client Client { get; set; }
        [ForeignKey(nameof(MovieId))]
        [InverseProperty("Favorite")]
        public virtual Movie Movie { get; set; }
    }
}
