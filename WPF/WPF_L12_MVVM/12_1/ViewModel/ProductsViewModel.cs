using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_L12.Model;


namespace Wpf_L12.ViewModel
{
    public class ProductsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Products> AvailbleProducts { get; set; }
        public ObservableCollection<Products> BasketProducts { get; set; }
        public ICommand AddToBasketCommand { get; set; }
        private decimal _total { get; set; }
            

        public decimal Total
        {
            get
            {
                return _total; 
            }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }             
        }


        public ProductsViewModel()
        {
            AvailbleProducts = new ObservableCollection<Products>
            {
                new Products { Name = "Milk", Price = 24.25m },
                new Products { Name = "Bread", Price = 20.25m },
                new Products { Name = "Chocolate", Price = 31.5m }
            };

            BasketProducts = new ObservableCollection<Products>();
            AddToBasketCommand = new DelegateCommand(AddToBasket);

        }

        public void AddToBasket(Object obj)
        {
            if (obj is Products)
            {
                BasketProducts.Add(obj as Products);
            }
            CalculateTotal();
        }
     
        public void CalculateTotal()
        {
            Total = 0;
            foreach (var item in BasketProducts)
            {
                Total += item.Price;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}



        

    

