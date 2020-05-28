using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
   public class ClassSingleton
    {
        private static ClassSingleton instance;
        public int number { get; set; }
        private static readonly object lockobj = new object();
        
        public ClassSingleton(int number)
        {
            this.number = number;
        }

        public static ClassSingleton GetInstance()
        {
            if (instance ==null)
            {
                lock (lockobj)
                {
                    if (instance == null)
                    {
                        Random ran = new Random();
                        instance = new ClassSingleton(ran.Next(1, 5));
                    }
                }
              
           }
          
            return instance;
        }

        public void helloSingleton()
        {
            Console.WriteLine("I'm Singleton num {0}",number);
        }

        
    }
}
