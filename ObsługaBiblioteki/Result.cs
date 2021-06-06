using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_EngineModels
{
    class Result
    {
        public object volumeInfo { get; set; }
        public string Title { get; set; }
       // public Authors[] { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
    }
}
