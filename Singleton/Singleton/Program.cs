using System;
using System.Threading;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            var singelton = new Thread(()=> ClassSingleton.GetInstance().helloSingleton());

            var singelton1 = new Thread(() => ClassSingleton.GetInstance().helloSingleton());

            singelton.Start();
            singelton1.Start();
          
          
        }
    }
}
