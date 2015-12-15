using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkzApp.Data;

namespace DrinkzApp.Dal
{
    public class Drink
    {
        public static void CreateNewDrink(Dto.Drink drink)
        {
            using (var db = new DrinkzAppBDDataContext())
            {
                var dbDrink = new Data.Drink() {
                
                    CREATION_DATE = drink.CREATION_DATE,
                    FK_CATEGORY = drink.FK_CATEGORY,
                    NAME = drink.NAME,
                    DESCRIPTION = drink.DESCRIPTION,
                    HOWTO = drink.HOWTO,
                    LIKES = drink.LIKES,
                    PK_PROFILE = drink.FK_PROFILE,
                    VIEWS = drink.VIEWS,
                    YOUTUBE_URL = drink.YOUTUBE_URL,

                };

                db.Drinks.InsertOnSubmit(dbDrink);

                db.SubmitChanges();
            }
        }
    }
}
