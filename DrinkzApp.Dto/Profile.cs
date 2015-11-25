using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkzApp.Dto
{
    public class Profile
    {
        public int PK_PROFILE { get; set; }

        public string FACEBOOK_ID { get; set; }

        public string NAME { get; set; }

        public string URL_IMAGE { get; set; }

        public int FK_ADDRESS { get; set; }
    }
}
