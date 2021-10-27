using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTMusicRecords.Models
{
    public class Records
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }
    }
}
