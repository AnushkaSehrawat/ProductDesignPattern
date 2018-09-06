using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class gettingtype
    {
        
       

        public IProduct DetermineItemType(string itemType)
        {
            History.Instance.AddToLogFile("returning the instance dynamically.");
         
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == itemType);
            return (IProduct)Activator.CreateInstance(productType);

        }

        public IRepository GetStorageType(string storageType)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var productType = assembly.GetTypes().FirstOrDefault(t => t.Name == storageType);
            return (IRepository)Activator.CreateInstance(productType);
        }

        public IFareStrategy GetItemTypeForFare(IProduct product)
        {
            Type t = product.GetType();
            if (t == typeof(CarProduct))
            {
                return new CarStrategy();
            }
            else
            {
                return new HotelStrategy();
            }

        }
    }
}
