using Microsoft.AspNetCore.Mvc;
using System;

namespace ASPNETCore.Controllers
{
    public class MoviesController : Controller // Controller is a class
    {
        #region Return Type of Action
        //public IActionResult /*ContentResult*/ Index() // action => is a public non-static function in a controller
        //{
        //    //ContentResult result = new ContentResult();
        //    //result.Content = "Index";
        //    //result.ContentType = "object/pdf"; // controle returned content type form server
        //    //return result;

        //    return Content("Index", "object/pdf"); // helper method 
        //}

        ////public class ContentResult : ActionResult, IStatusCodeActionResult, IActionResult
        //public IActionResult /*RedirectResult*/ RedirectToIndex()
        //{
        //    //RedirectResult result = new RedirectResult(nameof(Index));

        //    //return result;

        //    //return RedirectToAction("Index");
        //    return RedirectToAction(nameof(Index));
        //}

        //public IActionResult RedirectToMyRoute()
        //{
        //    return RedirectToRoute("default"); // takes default value of route
        //    //return RedirectToRoute("default" , new {Controller = "Home", Action = "Index"}); // takes annonymous obj controller and action
        //} 
        #endregion

        #region Action Parameter binding (Model Binding)


        /// Action parameters take it's values form 
        /// 1.HTML form
        /// 2.Segment (Route Data) => https://localhost:44302/Movies/GetMovie/10
        /// 3.query string => https://localhost:44302/Movies/GetMovie?id=20
        ///         if you passed segmetn and query string => https://localhost:44302/Movies/GetMovie/100?id=20
        ///         it take segmetn 100
        /// 4.file
        /// 
        public IActionResult GetMovie(int id, string name, Employee emp)
        {
            return Content($"Movie with id = {id}, name = {name}");
        }
        #endregion
    }
}
