namespace DZ6._3
{
    internal class Planet
    {
        public string name { get; }
        public int numberFromSun { get; }
        public int lengthEquator { get; }

        public Planet(string planet)
        {
            name = planet;

            switch (planet)
            {
                case "Venera":
                    numberFromSun = 2;
                    lengthEquator = 38025;
                    break;
                case "Earth":
                    numberFromSun = 3;
                    lengthEquator = 40075;
                    break;
                case "Mars":
                    numberFromSun = 4;
                    lengthEquator = 21343;
                    break;
            }
        }
    }
}
