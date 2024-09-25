using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_L12_2.Model;

namespace Wpf_L12_2.ViewModel
{
    public class Library : INotifyPropertyChanged
    {
        public ObservableCollection<Book> books { get; set; }

        private Book _bookDescription { get; set; }
        public Book BookDescription
        {
            get
            {
                return _bookDescription;
            }
            set
            {
                _bookDescription = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public ICommand ShowBookCommand { get; set; }

        public Library() 
        {
            books = new ObservableCollection<Book>()
            {
                new Book {Title = "Book1", Author = "Author", Year = 1999, Genre = "Roman", Description = "Fairytale about litle bug" },
                new Book {Title = "Book2", Author = "Author", Year = 1998, Genre = "Roman", Description = "Fairytale about litle boy" },
                new Book {Title = "Book3", Author = "Author", Year = 1997, Genre = "Roman", Description = "Fairytale about litle cat" },
                new Book {Title = "Book4", Author = "Author", Year = 1996, Genre = "Roman", Description = "Fairytale about litle dog" }
            };

            BookDescription = books[0]; // new Book(); 
            ShowBookCommand = new DelegateCommand(ShowBook);
        }

        public void ShowBook(object obj)
        {
            if (obj is Book)
                BookDescription = obj as Book; 
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
