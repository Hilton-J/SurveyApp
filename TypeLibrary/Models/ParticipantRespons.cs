using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLibrary.Models
{
    public class ParticipantRespons
    {
        //public Guid ID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime? DOB { get; set; }
        public string ContactNumber { get; set; } = string.Empty;
        public string Food { get; set; } = string.Empty;
        public int? Movies { get; set; }
        public int? Radio { get; set; }
        public int? EatOut { get; set; }
        public int? WatchTV { get; set; }
    }
}
