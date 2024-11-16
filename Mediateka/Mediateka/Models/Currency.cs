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
        public DateTime date { get; set; }
        public string _base { get; set; }
        public Dictionary<string,double> rates { get; set; }  
    
        

    }
}

