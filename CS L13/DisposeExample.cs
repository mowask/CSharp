using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L13
{
    internal class DisposeExample : IDisposable
    {
        //  используется для того, чтобы выяснить, вызывается ли метод Dispose()
        private bool isDisposed = false;

        private void Cleaning (bool disposing)
        {
            //  убедиться что ресурсы еще не освобождены (очищать только оидн раз)
            if (disposing) return;

            Console.WriteLine("Освобождение неуправляемых ресурсов");

            //  если true то освобождаются все управляемые ресурсы
            if (disposing) Console.WriteLine("Освобождение управляемых ресурсов");

            isDisposed = true;
        }

        public void Dispose()
        {
            //  true - очистка инициирована пользавателем обхъекта
            Cleaning(true);
            //  запретить сборщику мусора осузествлять финализацию
            GC.SuppressFinalize(this);
        }

        ~DisposeExample()
        {
            //  false указывает на то что очистку инициировал сборзик мусора
            Cleaning(false);
        }

        public void DoSomething()
        {
            Console.WriteLine("Выполнение определенныз операций");
        }

    }
}
