namespace Project.Models
{
    public class SurfboardRepo
    {
        private List<Surfboard> surfboards = new List<Surfboard>();

        public SurfboardRepo()
        {
            Add(); // Tilføjer alle hardcodede surfboards
        }


        public void Add()
        {

            surfboards.Add(new Surfboard
            {
                Name = "The Minilog",
                Length = 6,
                Width = 21,
                Thickness = 2.75,
                Volume = 38.8,
                Type = "Shortboard",
                Price = 565,
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Name = "The Wide Glider",
                Length = 7.1,
                Width = 21.75,
                Thickness = 2.75,
                Volume = 44.16,
                Type = "Funboard",
                Price = 685,
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Name = "The Golden Ratio",
                Length = 6.3,
                Width = 21.85,
                Thickness = 2.9,
                Volume = 43.22,
                Type = "Funboard",
                Price = 695,
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Name = "Mahi Mahi",
                Length = 5.4,
                Width = 20.75,
                Thickness = 2.3,
                Volume = 29.39,
                Type = "Fish",
                Price = 645,
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Name = "The Emerald Glider",
                Length = 9.2,
                Width = 22.8,
                Thickness = 2.8,
                Volume = 65.4,
                Type = "Longboard",
                Price = 895,
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Name = "The Bomb",
                Length = 5.5,
                Width = 21,
                Thickness = 2.5,
                Volume = 33.7,
                Type = "Shortboard",
                Price = 645,
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Name = "Walden Magic",
                Length = 9.6,
                Width = 19.4,
                Thickness = 3,
                Volume = 80,
                Type = "Longboard",
                Price = 1025,
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Name = "Naish One",
                Length = 12.6,
                Width = 30,
                Thickness = 6,
                Volume = 301,
                Type = "SUP",
                Price = 854,
                Equipment = new List<Equipment>
                {
                    new Equipment { Name = "Paddle" }
                }
            });

            surfboards.Add(new Surfboard
            {
                Name = "Six Tourer",
                Length = 11.6,
                Width = 32,
                Thickness = 6,
                Volume = 270,
                Type = "SUP",
                Price = 611,
                Equipment = new List<Equipment>
                {
                    new Equipment { Name = "Fin" },
                    new Equipment { Name = "Paddle" },
                    new Equipment { Name = "Pump" },
                    new Equipment { Name = "Leash" }
                }
            });

            surfboards.Add(new Surfboard
            {
                Name = "Naish Maliko",
                Length = 14,
                Width = 25,
                Thickness = 6,
                Volume = 330,
                Type = "SUP",
                Price = 1304,
                Equipment = new List<Equipment>
                {
                    new Equipment { Name = "Fin" },
                    new Equipment { Name = "Paddle" },
                    new Equipment { Name = "Pump" },
                    new Equipment { Name = "Leash" }
                }
            });
        }
        public List<Surfboard> GetSurfBoardsByType(string type)
        {
            List<Surfboard> filteredSurfboards = surfboards.FindAll(s => s.Type == type);
            return filteredSurfboards;
        }
    }

}
