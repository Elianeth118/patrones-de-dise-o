using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.ThreadSafe
{
    public class ThreadSafeSingleton
    {
        // Instancia privada y estática de la clase singleton
        private static ThreadSafeSingleton _instance;

        // Objeto privado, estático y de solo lectura utilizado para bloquear durante la creación de la instancia
        private static readonly Object _lock = new object();

        // Constructor privado para evitar la instanciación directa de la clase
        private ThreadSafeSingleton()
        {

        }

        // Método público para obtener la instancia de la clase singleton
        public static ThreadSafeSingleton GetInstance()
        {
            // Verifica si la instancia es nula (aún no se ha creado)
            if (_instance == null)
            {
                // Utiliza un bloqueo para garantizar que solo un hilo pueda crear una instancia a la vez
                lock (_lock)
                {
                    // Verifica nuevamente si la instancia sigue siendo nula dentro del bloqueo
                    if (_instance == null)
                    {
                        // Crea una nueva instancia si todavía es nula
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }

            // Devuelve la instancia de la clase singleton
            return _instance;
        }
    }
}