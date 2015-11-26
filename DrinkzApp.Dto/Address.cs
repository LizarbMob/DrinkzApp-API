using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkzApp.Dto
{
    public class Address
    {
        public int PK_ADDRESS { get; set; }

        public string ZIP_CODE { get; set; }

        public string STREET { get; set; }

        public string STATE { get; set; }

        public int PK_PROFILE { get; set; }
    }
}
