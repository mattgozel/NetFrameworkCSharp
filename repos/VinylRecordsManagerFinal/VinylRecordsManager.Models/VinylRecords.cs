using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylRecordsManager.Models
{
    public class VinylRecords
    {
        public int Id { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public double Rating { get; set; }

        public override string ToString()
        {
            return String.Format($"\nId: {Id}\nArtist: {Artist}\nAlbum: {Album}\nRating: {Rating}\n");
        }
    }
}
