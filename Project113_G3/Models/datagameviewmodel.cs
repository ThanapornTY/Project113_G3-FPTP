using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project113_G3.Models
{
    public class datagameviewmodel
    {
        public string Model { get; set; }
        public int Amount { get; set; }
    }

    public class OrderDetailsDataModel
    {

    private DashboardEntities db = new DashboardEntities ();

     public List<datagameviewmodel> GetOrderbyModel()
    {
    var chartDataList = new List<datagameviewmodel>();

     var prod = db.Datagames.OrderBy(i => i.Id).ToList();
     foreach (var item in prod.GroupBy(i => i.NameGame))
     {
    var chartData = new datagameviewmodel();
     chartData.Model = item.FirstOrDefault().NameGame;
    chartData.Amount = item.Count();
     chartDataList.Add(chartData);
      }
     return chartDataList;
     }
 } 
}