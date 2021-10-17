using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singleton
    {
        private static string connectionString = "STH";
        static private Singleton instance;
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public string GetConnection()
        {
            //TRY CONNECT VIA connectionString
            string connectionState = "true";
            if (connectionState == "true")
            {
                return "SUCCESS";
            }
            else
            {
                return "FAIL";
            }
        }
    }
}
