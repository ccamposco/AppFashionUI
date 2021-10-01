using AppFashionUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppFashionUI.ViewModels
{
    public class PopularFashionViewModel
    {
        public ObservableCollection<PopularFashion> popularfashion { get; set; }
        public ObservableCollection<Recommended> recommended { get; set; }

        public PopularFashionViewModel()
        {
            popularfashion = new ObservableCollection<PopularFashion>
            {
                new PopularFashion
                {
                    Name = "Casual T-shirt",
                    Price = "$150.00",
                    Image = "Model1.png"
                }
            };

            recommended = new ObservableCollection<Recommended>
            {
                new Recommended
                {
                    Name = "Casual Dress",
                    Description = "Modern Style",
                    Picture = "Model3.png"
                }

            };
        }
    }
}
