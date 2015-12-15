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

        public static Dto.Drink GetDrinkById(int id)
        {
            using (var db = new DrinkzAppBDDataContext())
            {
                return db.Drinks.Where(c => c.PK_DRINK == id).Select(c => new Dto.Drink {
                
                    CREATION_DATE = c.CREATION_DATE,
                    FK_CATEGORY = c.FK_CATEGORY,
                    NAME = c.NAME,
                    DESCRIPTION = c.DESCRIPTION,
                    FK_PROFILE = c.PK_PROFILE,
                    HOWTO = c.HOWTO,
                    LIKES = c.LIKES,
                    PK_DRINK = c.PK_DRINK,
                    VIEWS = c.VIEWS,
                    YOUTUBE_URL = c.YOUTUBE_URL

                }).FirstOrDefault();
            }
        }

        public static List<Dto.Drink> GetAllDrinks()
        {
            using (var db = new DrinkzAppBDDataContext())
            {
                return db.Drinks.Select(c=> new Dto.Drink {

                CREATION_DATE = c.CREATION_DATE,
                DESCRIPTION = c.DESCRIPTION,
                FK_CATEGORY = c.FK_CATEGORY,
                NAME = c.NAME,
                FK_PROFILE = c.PK_PROFILE,
                HOWTO = c.HOWTO,
                LIKES = c.LIKES,
                PK_DRINK = c.PK_DRINK,
                VIEWS = c.VIEWS,
                YOUTUBE_URL = c.YOUTUBE_URL
                
                }).ToList();
            }
        }
    }
}
