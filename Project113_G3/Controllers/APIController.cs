using Project113_G3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project113_G3.Controllers
{
    public class APIController : Controller
 {
 // GET: API
 public JsonResult OrderbyModel()
    {
        var orderModel = new OrderDetailsDataModel();
        var data = orderModel.GetOrderbyModel();
         return Json(data, JsonRequestBehavior.AllowGet);
     }
    }
}