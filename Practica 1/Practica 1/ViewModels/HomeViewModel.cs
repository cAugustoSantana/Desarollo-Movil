using System;
using System.Collections.Generic;
using System.Text;
using Practica_1.Models;

namespace Practica_1.ViewModels
{
   public  class HomeViewModel
    {
        public MenuOption BarsAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDiningOption { get; set; } = new MenuOption();

        public MenuOption CafesOption { get; set; } = new MenuOption();

        public MenuOption NearbyOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsOption { get; set; } = new MenuOption();


        public MenuOption FeaturedFoodsOption { get; set; } = new MenuOption();





        public HomeViewModel()
        {
            BarsAndHotelsMenuOption.Title = "Bars and Hotels";
            FineDiningOption.Title = "Fine Dining";
            FastFoodsOption.Title = "Fast Foods";
            CafesOption.Title = "Cafes";
            FeaturedFoodsOption.Title = "Featured Foods";
            NearbyOption.Title = "Nearby";



        }
    }
}
