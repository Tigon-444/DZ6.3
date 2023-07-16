namespace DZ6._3
{
    internal class CatalogPlanet
    {
        private List<Planet> catalogPlanet = new List<Planet>();
        public int counter;
        public bool findPlanet;

        public CatalogPlanet()
        {
            catalogPlanet.Add(new Planet("Venera"));
            catalogPlanet.Add(new Planet("Earth"));
            catalogPlanet.Add(new Planet("Mars"));
        }


        public (int? numberFromSun, int? lengthEquator, string? error) GetPlanet(string name, Func <string, string> PlanetValidator)
        {
            var objectPlanet = catalogPlanet.Find(planet => planet.name == name);
            findPlanet = objectPlanet == null ? false : true;
            counter = counter < 3 ? counter++ : counter = 0;
            string validPl = PlanetValidator(name);
            if (findPlanet == true && validPl == null)
            {
                return (objectPlanet.numberFromSun, objectPlanet.lengthEquator, PlanetValidator(name));
            }
            return (null, null, PlanetValidator(name));
        }
    }
}
