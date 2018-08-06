using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebApplication4.Models;

namespace WebApplication4
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<NewsItem> GetTopItems(int count)
        {
            var allItems = new List<NewsItem>();
            for (int i = 1; i <= 100; i++)
            {
                allItems.Add(new NewsItem()
                {
                    Id = i,
                    Title = $"NewsIten{i}"
                });
            }

            return allItems.Take(count).ToList();
        }
    }
}
