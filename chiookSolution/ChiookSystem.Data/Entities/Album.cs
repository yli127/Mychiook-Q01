using System;
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
    [Table("Albums")]
    public class Album
    {
        [key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        public string ReleaseLabel { get; set; }

        //Navigation properties
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual Artist Artist { get; set; }
       
       


    }
}
