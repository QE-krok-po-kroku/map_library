using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectSimulator.Models;

namespace ProjectSimulatorTests
{
    public class TestDataProvider
    {
        public static Map Mountains(string state = "good")
        {
            return new Map
            {
                Isbn = "978-83-88112-70-6",
                Terrain = "Gorce i Pieniny",
                Type = "Turystyczna",
                Scale = 50000,
                State = state
            };
        }
    }
}
