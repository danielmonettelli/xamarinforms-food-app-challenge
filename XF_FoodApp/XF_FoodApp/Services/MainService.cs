using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XF_FoodApp.Models;
using XF_FoodApp.Styles;

namespace XF_FoodApp.Services
{
    public class MainService
    {
        #region GET[Restaurant]
        public List<Restaurant> GetRestaurant()
        {
            var restaurant = new List<Restaurant>
            {
                    new Restaurant {
                    Image_Restaurant ="https://i.pinimg.com/originals/cb/4b/18/cb4b18ecbab4a65e8dc4abc937064fd9.jpg",
                    Title_Restaurant="Central",
                    Place_Restaurant="Calle Santa Isabel 376, Miraflores-Perú",
                    Rating1_Restaurant="5",
                    Rating2_Restaurant="(967 ratings)"
                },
                    new Restaurant {
                    Image_Restaurant ="https://i.pinimg.com/originals/e4/b5/98/e4b5985bc5241cb7772525d0d34ef403.jpg",
                    Title_Restaurant="Maido",
                    Place_Restaurant="Calle San Martin 399, Miraflores-Perú",
                    Rating1_Restaurant="4.9",
                    Rating2_Restaurant="(678 ratings)"
                },
                    new Restaurant {
                    Image_Restaurant ="https://i.pinimg.com/originals/bd/db/31/bddb31854dfab067ea455e055bd8ffbe.jpg",
                    Title_Restaurant="Osso",
                    Place_Restaurant="Calle Tahiti 175, La Molina-Perú",
                    Rating1_Restaurant="4.9",
                    Rating2_Restaurant="(645 ratings)"
                },
                    new Restaurant {
                    Image_Restaurant ="https://i.pinimg.com/originals/aa/0d/e3/aa0de3ddf253a194ed4caad5a262b760.jpg",
                    Title_Restaurant="Rahat Brasserie",
                    Place_Restaurant="540 Levent-Besiktas",
                    Rating1_Restaurant="3.9",
                    Rating2_Restaurant="(348 ratings)"
                },
                    new Restaurant {
                    Image_Restaurant ="https://i.pinimg.com/originals/75/27/73/752773561732a6945a9b2484eef2f87f.jpg",
                    Title_Restaurant="Garage Bar",
                    Place_Restaurant="124 Levent-Besiktas",
                    Rating1_Restaurant="4.1",
                    Rating2_Restaurant="(545 ratings)"
                },

            };

            return restaurant;
        }
        #endregion

        #region GET[Category]
        public List<Category> GetCategory()
        {
            var category = new List<Category>
            {

                new Category {
                  Image_Category=CustomIconFont.icon_pizza,
                  ImageColor_Category="#FE8C01",
                  Title_Category="Pizza",
                  Place_Category="2350 places"
                },
                new Category {
                  Image_Category=CustomIconFont.icon_hamburger,
                  ImageColor_Category="#5AC7FB",
                  Title_Category="Burgers",
                  Place_Category="350 places"
                },
                 new Category {
                  Image_Category=CustomIconFont.icon_meat,
                  ImageColor_Category="#FF2D55",
                  Title_Category="Steak",
                  Place_Category="834 places"
                },
                 new Category {
                  Image_Category=CustomIconFont.icon_spaguetti,
                  ImageColor_Category="#5754D6",
                  Title_Category="Pasta",
                  Place_Category="150 places"
                },

            };

            return category;
        }
        #endregion

        #region GET[Food]
        public List<Food> GetFood()
        {
            var food = new List<Food>
            {

                new Food {
                   Image_Food="https://i.pinimg.com/originals/ae/a2/71/aea271c5f75be7aea8ccfacc6f95b36e.jpg",
                   Title_Food="Lomo saltado",
                   Price_Food="S/ 69",
                },
                new Food {
                   Image_Food="https://i.pinimg.com/564x/46/b8/79/46b8793aac8e9162fad20cd34195dbbe.jpg",
                   Title_Food="Ceviche",
                   Price_Food="S/ 78",
                },
                new Food {
                   Image_Food="https://i.pinimg.com/564x/cc/64/5f/cc645f2c094f29588fd6466b602bf30c.jpg",
                   Title_Food="Arroz chaufa",
                   Price_Food="S/ 34",
                },
                new Food {
                   Image_Food="https://i.pinimg.com/564x/9b/aa/0f/9baa0f7df306d8035596f4f29e0730f6.jpg",
                   Title_Food="Torta tres leches",
                   Price_Food="S/ 45",
                },
                new Food {
                   Image_Food="https://i.pinimg.com/564x/8f/53/d3/8f53d3429ae7baa4bb69da6602d35b86.jpg",
                   Title_Food="Chancho al palo",
                   Price_Food="S/ 75",
                },
                new Food {
                   Image_Food="https://i.pinimg.com/564x/31/76/d0/3176d076d01b4eeb7f8bd2aaa5a13d37.jpg",
                   Title_Food="Pollo a la braza",
                   Price_Food="S/ 75",
                }
            };

            return food;
        }
        #endregion
    }
}