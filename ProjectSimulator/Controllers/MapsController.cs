using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using ProjectSimulator.Models;
using ProjectSimulator.Dao;

namespace ProjectSimulator.Controllers
{
    [RoutePrefix("api/library/maps")]
    public class MapsController : ApiController
    {
        readonly MapDao _dao = new MapDao();

        [Route("")]
        [HttpGet]
        public IEnumerable<Map> GetMaps()
        {
            //TODO: Sprint 2
            return new List<Map>();
        }

//TODO: Sprint 1
//        [Route("")]
//        [HttpPost]
//        public HttpResponseMessage Post([FromBody] /* type variable */)
//        {
//            return Request.CreateResponse(HttpStatusCode.Created, new Count() { MapsCount = 0});
//        }
    }
}
