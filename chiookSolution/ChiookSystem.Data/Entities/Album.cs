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
        {
        [Table("Tracks")]
        public class Track
        { 
            [Key]
            public int TrackId { get; set; }
            public int Name { get; set; }
            public int ? AlbumId { get; set; }
            public int MediaTypeId { get; set; }
            public int?GenreId { get; set; }
            public int Composer{ get; set; }
            public int  Milliseconds{ get; set; }
            public int?Bytes { get; set; }
            public int UnitPrice{ get; set; }

            //Navation properties
            public virtual Album Album { get; set; }


    }
}
