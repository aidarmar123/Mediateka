using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mediateka.Models
{
    public class Currency
    {
        
        public DateTime time_last_update_utc { get; set; }
        public string base_code { get; set; }
        public Rate conversion_rates { get; set; }
        public Dictionary<string,double> rates { get; set; }
        public class Rate
        {

            public double EUR { get; set; }

            public double RUB { get; set; }    
            public double USD { get; set; }
           
        }


    }
}

