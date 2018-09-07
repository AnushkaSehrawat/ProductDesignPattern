using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    class Program
    {
        static void Main(string[] args)
        {
            History.Instance.AddToLogFile("----In Main -----");
            gettingtype obj = new gettingtype();
            ProductService serviceobj = new ProductService();
            int option;
            string itemType;
            string storageType;
            Console.WriteLine("Enter the type of product you want :");
            itemType = Console.ReadLine();
            History.Instance.AddToLogFile("Calling Function DetermineType to determine the type of object to be created.");
            IProduct finalObject= obj.DetermineItemType(itemType);
            IFareStrategy fareItemType = obj.GetItemTypeForFare(finalObject);
            Console.WriteLine("Enter which operartion you want to perform: 1:book 2:save ");
            option = Int32.Parse(Console.ReadLine());
            History.Instance.AddToLogFile("Entering into switch mode");
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter option where you want to save the details: 1: FileRepository 2: SqlRepository");
                        storageType = Console.ReadLine();
                        IRepository finalstorage = obj.GetStorageType(storageType);
                        serviceobj.Book(finalObject,finalstorage,fareItemType.CalculateFare(finalObject.fare));
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Enter option where you want to save the details: 1: File 2: Database");
                        storageType = Console.ReadLine();
                        IRepository finalstorage = obj.GetStorageType(storageType);
                        serviceobj.Save(finalObject,finalstorage, fareItemType.CalculateFare(finalObject.fare));
                        break;
                    }

              
            }
            Console.ReadKey();
        }
    }
}
