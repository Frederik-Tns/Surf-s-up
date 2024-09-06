using static System.Net.WebRequestMethods;

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
                Id = 0,
                Name = "The Minilog",
                Length = 6,
                Width = 21,
                Thickness = 2.75,
                Volume = 38.8,
                Type = "Shortboard",
                Price = 565,
                ImageURL = "https://dfsdr5wqg5xgr.cloudfront.net/catalog/product/cache/27526a56b2e11603fd131d06b424c878/t/a/tahe-surf_2021_dura-tec_6-7_hr_107123_kopi.jpg",
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Id = 1,
                Name = "The Wide Glider",
                Length = 7.1,
                Width = 21.75,
                Thickness = 2.75,
                Volume = 44.16,
                Type = "Funboard",
                Price = 685,
                ImageURL = "https://cdn.shopify.com/s/files/1/2146/1003/collections/funboard-feature-image-a-296x296.jpg?v=1569105463",
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Id = 2,
                Name = "The Golden Ratio",
                Length = 6.3,
                Width = 21.85,
                Thickness = 2.9,
                Volume = 43.22,
                Type = "Funboard",
                Price = 695,
                ImageURL = "https://cdn.shopify.com/s/files/1/2146/1003/collections/funboard-feature-image-a-296x296.jpg?v=1569105463",
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Id = 3,
                Name = "Mahi Mahi",
                Length = 5.4,
                Width = 20.75,
                Thickness = 2.3,
                Volume = 29.39,
                Type = "Fish",
                Price = 645,
                ImageURL = "https://lushpalm.com/wp-content/uploads/2020/04/fish-surfboard-olero.jpg",
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Id = 4,
                Name = "The Emerald Glider",
                Length = 9.2,
                Width = 22.8,
                Thickness = 2.8,
                Volume = 65.4,
                Type = "Longboard",
                Price = 895,
                ImageURL = "https://www.light-surfboards.com/uploads/5/7/3/0/57306051/1473860971.png",
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Id = 5,
                Name = "The Bomb",
                Length = 5.5,
                Width = 21,
                Thickness = 2.5,
                Volume = 33.7,
                Type = "Shortboard",
                Price = 645,
                ImageURL = "https://files.oaiusercontent.com/file-tY50B2gGDYwjAGQED3EGDJ32?se=2024-09-04T18%3A57%3A02Z&sp=r&sv=2024-08-04&sr=b&rscc=max-age%3D604800%2C%20immutable%2C%20private&rscd=attachment%3B%20filename%3D39c6ce07-d170-4c04-897d-931b3c8d347e.webp&sig=qX1gpoXZW7/kSCv7REDjX8ka9xh4J6NEFAd31UCpJlg%3D",
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Id = 6,
                Name = "Walden Magic",
                Length = 9.6,
                Width = 19.4,
                Thickness = 3,
                Volume = 80,
                Type = "Longboard",
                Price = 1025,
                ImageURL = "https://zeus-surf.com/cdn/shop/articles/choisir-planche-surf-longboard.jpg?v=1710775825&width=1500",
                Equipment = new List<Equipment>()
            });

            surfboards.Add(new Surfboard
            {
                Id = 7,
                Name = "Naish One",
                Length = 12.6,
                Width = 30,
                Thickness = 6,
                Volume = 301,
                Type = "SUP",
                Price = 854,
                ImageURL = "https://sup.star-board.com/wp-content/uploads/2023/07/2024-Pro-All-Round-Wave-hard-stand-up-paddle-board-Starboard-SUP-key-feature-main-top-550x309.jpg",
                Equipment = new List<Equipment>
                {
                    new Equipment { Name = "Paddle" }
                }
            });

            surfboards.Add(new Surfboard
            {
                Id = 8,
                Name = "Six Tourer",
                Length = 11.6,
                Width = 32,
                Thickness = 6,
                Volume = 270,
                Type = "SUP",
                Price = 611,
                ImageURL = "https://sup.star-board.com/wp-content/uploads/2023/07/2024-Pro-All-Round-Wave-hard-stand-up-paddle-board-Starboard-SUP-key-feature-main-top-550x309.jpg",
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
                Id = 9,
                Name = "Naish Maliko",
                Length = 14,
                Width = 25,
                Thickness = 6,
                Volume = 330,
                Type = "SUP",
                Price = 1304,
                ImageURL = "https://sup.star-board.com/wp-content/uploads/2023/07/2024-Pro-All-Round-Wave-hard-stand-up-paddle-board-Starboard-SUP-key-feature-main-top-550x309.jpg",
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
