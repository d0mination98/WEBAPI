using System.Collections.Generic;
using System.Web.Http;
using SalesApi.Services;
using SalesApi.Models;

namespace SalesApi.Controllers
{
    [RoutePrefix("sales")]
    public class SalesOrderController : ApiController
    {
        private ISalesOrderService _service { get; set; }
       
        public SalesOrderController(ISalesOrderService service)
        {
            _service = service;
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
           var soHead = _service.GetSalesOrder(id);
            return Ok(soHead);
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var list = _service.GetSalesOrder();
            return Ok(list);
        }

        // POST api/<controller>
        [HttpPost]
        [Route("NewSale")]
        public IHttpActionResult CreateNewSale([FromBody]SoHead request)
        {
            var id = _service.CreateSale(request);
            return Ok(id);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}