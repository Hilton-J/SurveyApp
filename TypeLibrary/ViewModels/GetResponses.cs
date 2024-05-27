using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeLibrary.ViewModels
{
    public class GetResponses
    {
        //public Guid ID { get; set; }
        public int TotalSurvey { get; set; }
        public Decimal Average { get; set; }
        public int Oldest { get; set; }
        public int Youngest { get; set; }
        public Decimal Pizza {  get; set; }
        public Decimal PapWors { get; set; }
        public Decimal Pasta { get; set; }
        public Decimal EatOut { get; set;}
        public Decimal Movies { get; set; }
        public Decimal Radio { get; set; }
        public Decimal WatchTV { get; set; }
    }
}
