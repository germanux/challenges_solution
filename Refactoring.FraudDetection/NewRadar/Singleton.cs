using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.NewRadar
{
    public class Singleton<T> where T : class, new()
    {
        protected static T instance = null;

        protected Singleton() { }

        public static T GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new T();
                return instance;
            }
        }
    }
}
