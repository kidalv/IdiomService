using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdiomsService.Security
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public List<string> Languages { get; set; }
    }
}
