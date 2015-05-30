using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProjectSimulator.Dao;
using ProjectSimulator.Models;
using ProjectSimulator.Utils;

namespace ProjectSimulator.Controllers
{
    [RoutePrefix("api/library/maps_state")]
    public class MapsStateController : ApiController
    {
        readonly MapDao _dao = new MapDao();

        [Route("")]
        [HttpGet]
        public IEnumerable<MapDto> GetMapsState()
        {
            return MapToMapDto.Convert(_dao.GetMaps().ToList());
        }
    }
}
