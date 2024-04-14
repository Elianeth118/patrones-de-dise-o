using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    internal class MySingleton
    {
        private static MySingleton _instance;

        private MySingleton() 
        {

        } //Constructor

        public static MySingleton GetInstance()
        {
            //metodo que devuelve una instancia
            if (_instance == null)// valida que no 
            {
                _instance = new MySingleton();

            }
            return _instance;   
        }

    }
}
