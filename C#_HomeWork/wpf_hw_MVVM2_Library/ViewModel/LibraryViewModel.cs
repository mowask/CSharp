using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;
using wpf_hw_MVVM2_Library.Model;

namespace wpf_hw_MVVM2_Library.ViewModel
{
    public class LibraryViewModel : INotifyPropertyChanged
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

            public LibraryViewModel()
            {

            //books = new ObservableCollection<Book>()
            //{
            //    new Book {Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1937, Genre = "Fantasy",
            //        Description = "The Hobbit is set in Middle-earth and follows home-loving Bilbo Baggins, " +
            //        "the hobbit of the title, who joins the wizard Gandalf and the thirteen dwarves of Thorin's Company, " +
            //        "on a quest to reclaim the dwarves' home and treasure from the dragon Smaug." },
            //    new Book {Title = "Lord of the Flies", Author = "William Golding", Year = 1954, Genre = "Novel",
            //        Description = "The novel tells the story of a group of British schoolchildren who find themselves on a desert island after a plane crash." +
            //        " At first, the children try to establish order and organize a fair life on the island, but over time, disagreements and real," +
            //        " adult conflicts arise among them." },
            //    new Book {Title = "Romeo and Juliet", Author = "William Shakespeare", Year = 1561, Genre = "Tragedy",
            //        Description = "The book about a deep love that flares up between two young people from feuding families – the Montagues and the Capulets." },
            //    new Book {Title = "Faust", Author = "Goethe", Year = 1876, Genre = "Drama",
            //        Description = "This book tells the story of the life and fall of a man who makes a deal with a demon. " +
            //        "But will the evil spirit Mephistopheles succeed in dragging the disillusioned soul underground, " +
            //        "or will her inner light prove stronger?" }
            //};

            //SaveBooksToFile();

            books = LoadBooksFromFile() ?? new ObservableCollection<Book>(); 

                 BookDescription = null;
                 ShowBookCommand = new DelegateCommand(ShowBook);
            
            }

            public void ShowBook(object obj)
            {
                if (obj is Book)
                    BookDescription = obj as Book;
            }

            private ObservableCollection<Book> LoadBooksFromFile()
            {
            try
            {
                if (File.Exists("books.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Book>));
                    using (StreamReader reader = new StreamReader("books.xml"))
                    {
                        ObservableCollection<Book> booksList = (ObservableCollection<Book>)serializer.Deserialize(reader);
                        return new ObservableCollection<Book>(booksList);
                    }
                }
            }
            catch (Exception ex)
            {               
                Console.WriteLine("Ошибка при загрузке данных: " + ex.Message);
            }

                return null;
            }

            //public void AddNewBook(Book book)
            //{
            //    books.Add(book);
            //    SaveBooksToFile();
            //}

            private void SaveBooksToFile()
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
                    using (StreamWriter writer = new StreamWriter("books.xml"))
                    {
                        serializer.Serialize(writer, new List<Book>(books));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show ("Ошибка при сохранении данных: " + ex.Message);
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



