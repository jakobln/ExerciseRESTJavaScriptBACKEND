using RESTMusicRecords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTMusicRecords.Managers
{
    public class RecordsManager
    {
        private static readonly List<Records> Data = new List<Records>
        {
            new Records {Title = "string1", Artist = "artist1", Duration = 12, PublicationYear = 1999},
            new Records {Title = "title2", Artist = "artist2", Duration = 22, PublicationYear = 1923}
        };

        public List<Records> GetAll(string substring)
        {
            return new List<Records>(Data);
        }


    }
}
