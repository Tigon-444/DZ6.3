namespace DZ6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var catalog = new CatalogPlanet();

            Func<string, string> PlanetValidator = planet =>
            {
                if (catalog.counter == 3)
                {
                    return "Вы спрашиваете слишком часто";
                }
                else if (catalog.findPlanet == false)
                {
                    return "Планета не найдена";
                }
                return null;
            };

            Func<string, string> ClosedPlanet = planet =>
            {
                if (catalog.counter == 3)
                {
                    return "Вы спрашиваете слишком часто";
                }
                else if (planet == "Limonia")
                {
                    return "Это запретная планета";
                }
                return null;
            };

            //var a = new CatalogPlanet();
            WritePlanet(catalog.GetPlanet("Earth", PlanetValidator), "Earth");
            WritePlanet(catalog.GetPlanet("Limonia", PlanetValidator), "Limonia");
            WritePlanet(catalog.GetPlanet("Mars", PlanetValidator), "Mars");
            Console.WriteLine();
            WritePlanet(catalog.GetPlanet("Earth", ClosedPlanet), "Earth");
            WritePlanet(catalog.GetPlanet("Limonia", ClosedPlanet), "Limonia");
            WritePlanet(catalog.GetPlanet("Mars", ClosedPlanet), "Mars");

        }

        static void WritePlanet((int?, int?, string?) info, string name)
        {
            if (info.Item3 == null)
            {
                Console.WriteLine("Планета " + name);
                Console.WriteLine("Номер от Солнца " + info.Item1);
                Console.WriteLine("Длинна экватора " + info.Item2);
            }
            else
            {
                Console.WriteLine(info.Item3);
            }
            Console.WriteLine();
            
        }
    }
}