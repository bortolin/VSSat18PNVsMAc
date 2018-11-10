using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using System.Data.SqlClient;

namespace VsMacDemo01.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            // For testing purpose
            //return new string[] { "Product1", "Product2" };

            //Access to database SQL Server (Dapper container on Mac)
            using (var cnn = new SqlConnection("Persist Security Info=False;User ID=sa;Password=ASDzxc123;Initial Catalog=TestDb;Server=127.0.0.1")) {

                var result = cnn.Query<string>("SELECT ProductName FROM Products");

                return result;
            }
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Product1";
        }

       
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

      
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
