using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkzApp.Bll
{
    public class Select
    {
        public static ViewModel.GetProfileById GetProfileById(int Id)
        {
            ViewModel.GetProfileById Profile = new ViewModel.GetProfileById();

            Profile.Profile = Dal.Profile.GetProfileById(Id);

            Profile.Address = Dal.Address.GetAddressById(Id);

            return Profile;
        }

        public static ViewModel.GetDrinkById GetDrinkById(int id)
        {
            ViewModel.GetDrinkById Drink = new ViewModel.GetDrinkById();

            Drink.Drink = Dal.Drink.GetDrinkById(id);

            return Drink;
        }

        public static ViewModel.GetAllDrinks GetAllDrinks()
        {
            ViewModel.GetAllDrinks Drinks = new ViewModel.GetAllDrinks();

            Drinks.Drinks = Dal.Drink.GetAllDrinks();

            return Drinks;
        }
    }
}
