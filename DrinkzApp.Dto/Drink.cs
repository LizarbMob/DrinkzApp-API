using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkzApp.Dto
{
    public class Drink
    {
        public int PK_DRINK { get; set; }

        public string NAME { get; set; }

        public string DESCRIPTION { get; set; }

        public string HOWTO { get; set; }

        public int LIKES { get; set; }

        public int FK_CATEGORY { get; set; }

        public int? VIEWS { get; set; }

        public DateTime CREATION_DATE { get; set; }

        public int FK_PROFILE { get; set; }

        public string YOUTUBE_URL { get; set; }
    }
}
