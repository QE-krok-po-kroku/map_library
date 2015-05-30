using System.Collections.Generic;
using ProjectSimulator.Models;

namespace ProjectSimulator.Utils
{
    public class MapToMapDto
    {
        public static IList<MapDto> Convert(IList<Map> maps)
        {
            IList<MapDto> result  = new List<MapDto>();
            foreach (var map in maps)
            {
                result.Add(new MapDto
                {
                    Isbn = map.Isbn,
                    State = map.State
                });
            }
            return result;
        }
    }
}
