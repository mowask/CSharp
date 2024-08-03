using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_class
{

    class Magazine 
    {
        private string _name;
        private int _year;
        private string _description;
        private double _telephone;
        private string _email;

        public Magazine(string _name, int _year, string _description) {
            this._name = _name;
            this._year = _year;
            this._description = _description;
        }

        public double GetTelephone(double tel) 
        {
            return _telephone = tel;
        }
        public string GetEmail(string _email) 
        { 
            return this._email= _email;
        }
        public void changeTelephone(double newTel) 
        {
           _telephone = newTel ;
        }
        public void Print() 
        {
            Console.WriteLine($"Журнал {_name} публикует статьи на тему {_description} начиная с {_year} года" +
                $"\nконтактные данные: телефон: {_telephone}, email: {_email}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine1 = new Magazine("Vogue", 2000, "fashion");
            magazine1.Print();
            magazine1.GetTelephone(555170115);
            magazine1.GetEmail("vogue@gmail.com");
            magazine1.Print();
            magazine1.changeTelephone(880099777); 
            magazine1.Print();
            Console.ReadKey();
        }
    }
}
