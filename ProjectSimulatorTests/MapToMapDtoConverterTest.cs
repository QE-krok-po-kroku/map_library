using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ProjectSimulator.Models;
using ProjectSimulator.Utils;

namespace ProjectSimulatorTests
{
    [TestFixture]
    public class MapToMapDtoConverterTest
    {
        [Test]
        public void ShouldReturnEmptyListWhenEmptyListPassed()
        {
            IList<Map> maps = new List<Map>();

            IList<MapDto> dtos = MapToMapDto.Convert(maps);

            Assert.That(dtos, Is.Empty);
        }

        [Test]
        public void ShouldConvertMapIntoMapDto()
        {
            IList<Map> maps = new List<Map>();
            maps.Add(TestDataProvider.Mountains());

            IList<MapDto> dtos = MapToMapDto.Convert(maps);

            Assert.That(dtos.Count, Is.EqualTo(1));
            MapDto dto = dtos.First();
            Assert.That(dto.Isbn, Is.EqualTo("978-83-88112-70-6"));
            Assert.That(dto.State, Is.EqualTo("good"));
        }
    }
}
