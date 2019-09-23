using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF_FoodApp.Models;
using XF_FoodApp.Services;

namespace XF_FoodApp.ViewModels
{
    public class MainViewModel : BindableObject
    {

        #region Properties
        private bool _isBusy = false;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }


        private List<Restaurant> _listRestaurant;

        public List<Restaurant> ListRestaurant
        {
            get { return _listRestaurant; }
            set
            {
                _listRestaurant = value;
                OnPropertyChanged();
            }
        }

        private List<Category> _listCategory;

        public List<Category> ListCategory
        {
            get { return _listCategory; }
            set
            {
                _listCategory = value;
                OnPropertyChanged();
            }
        }

        private List<Food> _listFood;

        public List<Food> ListFood
        {
            get { return _listFood; }
            set
            {
                _listFood = value;
                OnPropertyChanged();
            }
        }
        #endregion


        #region Constructors
        public MainViewModel()
        {
            GetService();
        }
        #endregion


        #region CRUD Services
        public void GetService()
        {
            var service = new MainService();
            ListRestaurant = service.GetRestaurant();
            ListCategory = service.GetCategory();
            ListFood = service.GetFood();
        }
        #endregion
    }
}
