using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Owin.Testing;
using Newtonsoft.Json;
using NUnit.Framework;
using ProjectSimulator;
using ProjectSimulator.Models;

namespace ProjectSimulatorTests
{
    [TestFixture]
    public class GetStateFunctionalTest
    {
        private TestServer server;

        [TestFixtureSetUp]
        public void FixtureInit()
        {
            Database.SetInitializer(new TestApplicationDbInitializer());
            TestApplicationDbContext db = new TestApplicationDbContext();
            db.Database.Initialize(true);
            db.Maps.Add(TestDataProvider.Mountains());
            db.SaveChanges();
            server = TestServer.Create<Startup>();
        }

        [TestFixtureTearDown]
        public void FixtureDispose()
        {
            server.Dispose();
        }

        [Test]
        public void WebApiGetAllTest()
        {
            var response = server.HttpClient.GetAsync("api/library/maps_state").Result;

            var result = response.Content.ReadAsStringAsync().Result;
            var dtos = JsonConvert.DeserializeObject<List<MapDto>>(result);

            Assert.That(dtos.Count, Is.EqualTo(1));
            MapDto dto = dtos.First();
            Assert.That(dto.State, Is.EqualTo("good"));
            Assert.That(dto.Isbn, Is.EqualTo("978-83-88112-70-6"));
        }
    }
}
