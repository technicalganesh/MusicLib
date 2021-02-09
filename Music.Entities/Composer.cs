using System.Collections.Generic;
using Music.Standards;
namespace Music.Entities {
    public class Composer : EntityBase {
        public string Country { get; set; }
        public virtual HashSet<Album> Albums { get;set;}
    }
}