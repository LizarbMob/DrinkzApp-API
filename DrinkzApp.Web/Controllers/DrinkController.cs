using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DrinkzApp.Web.Controllers
{
    /// <summary>
    /// Controller for everything related to Drinks
    /// </summary>
    public class DrinkController : ApiController
    {
        /// <summary>
        /// Create a new Drink
        /// </summary>
        /// <param name="Drink">A DTO of the Drink</param>
        /// <returns>Message if the drink was created or not</returns>
        [HttpPost]
        public HttpResponseMessage CreateNewDrink(ViewModel.CreateNewDrink Drink)
        {
            try
            {
                Bll.Create.CreateNewDrink(Drink);

                return Request.CreateResponse(HttpStatusCode.OK, "Drink created");
            }
            catch (Exception ex)
            {
                
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        /// <summary>
        /// Get a drink by a specific ID
        /// </summary>
        /// <param name="id">ID of the drink you want</param>
        /// <returns>The drink you wanted by the ID given</returns>
        [HttpGet]
        public ViewModel.GetDrinkById GetDrinkById(int id)
        {
            var Drink = Bll.Select.GetDrinkById(id);

            if (Drink.Drink == null)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, String.Format("Drink {0} not found.", id)));
            }

            return Drink;
        }

        /// <summary>
        /// Get all the drinks on the DataBase
        /// </summary>
        /// <returns>A list of Drinks</returns>
        [HttpGet]
        public ViewModel.GetAllDrinks GetAllDrinks()
        {
            ViewModel.GetAllDrinks Drinks = Bll.Select.GetAllDrinks();

            if (Drinks.Drinks.Count == 0)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Drinks Found"));
            }

            return Drinks;
        }
    }
}
