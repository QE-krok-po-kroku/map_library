using System.Web.Http;
using ProjectSimulator.Dao;
using ProjectSimulator.Models;

namespace ProjectSimulator.Controllers
{
    [RoutePrefix("api/library/mapscount")]
    public class MapsCountController : ApiController
    {
        readonly MapDao _dao = new MapDao();

        [Route("")]
        [HttpGet]
        public Count GetMapsCount()
        {
            //TODO: Sprint 3
            return new Count() {MapsCount = 0};
        }
    }
}
