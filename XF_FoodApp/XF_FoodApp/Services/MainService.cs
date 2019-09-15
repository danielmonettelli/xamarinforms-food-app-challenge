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
        public List<Restaurant> GetRestaurant()
        {
            var restaurant = new List<Restaurant>
            {

                new Restaurant {
                    Image_Restaurant ="https://i.pinimg.com/originals/aa/0d/e3/aa0de3ddf253a194ed4caad5a262b760.jpg",
                    Title_Restaurant="Rahat Brasserie",
                    Place_Restaurant="124 Levent-Besiktas",
                    Rating1_Restaurant="4.9",
                    Rating2_Restaurant="(120 ratings)"
                },
                new Restaurant {
                    Image_Restaurant ="https://i.pinimg.com/originals/75/27/73/752773561732a6945a9b2484eef2f87f.jpg",
                    Title_Restaurant="Garage Bar",
                    Place_Restaurant="124 Levent-Besiktas",
                    Rating1_Restaurant="4.9",
                    Rating2_Restaurant="(120 ratings)"
                }

                };

            return restaurant;
        }

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
                }

            };

            return category;
        }
    }
}