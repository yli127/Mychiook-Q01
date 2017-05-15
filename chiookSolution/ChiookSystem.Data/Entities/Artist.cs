﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace ChiookSystem.Data.Entities
{
    [Table("Artists")]
    public class Artist
    {
        [key]
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
    //Navigation properties for use by LINQ
    public virtual ICollection<Album> Albums { get; set; }
}
