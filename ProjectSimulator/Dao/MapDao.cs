using System.Collections.Generic;
using ProjectSimulator.Models;

namespace ProjectSimulator.Dao
{
    class MapDao
    {
        readonly ApplicationDbContext _db = new ApplicationDbContext();

        public IEnumerable<Map> GetMaps()
        {
            return _db.Maps;
        }

        public void AddMap(Map map)
        {
            _db.Maps.Add(map);
            _db.SaveChanges();
        }

        public void ResetDatabase()
        {
            _db.Database.Initialize(true);
        }
    }
}
