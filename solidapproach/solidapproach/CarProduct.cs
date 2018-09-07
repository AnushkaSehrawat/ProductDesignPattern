using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solidapproach
{
    public class CarProduct:IProduct
    {
       
        public string prodtype = "Car";
        public string prodname = "abc";
        public bool isbooked = false;
        public int Fare = 30;
        public string ProductType { get { return prodtype; } set { prodtype = value; } }
        public string ProductName { get { return prodname; } set { prodname = value; } }
        public bool IsBooked  {get { return isbooked; } set { isbooked = value; } }

        public int fare { get { return Fare; } set { Fare = value; } }
        //public void Book(IProduct product,IRepository storage,int fare)
        //{
        //    History.Instance.AddToLogFile("In book method setting the boolean value to true.");
        //    product.IsBooked = true;
        //    History.Instance.AddToLogFile("Calling AddToFile method to add the booked product details to file.");
        //    storage.Add( product,fare);
        //    Console.WriteLine("Car Booked");
        //}

        //public void Save(IProduct product,IRepository storage,int fare )
        //{
            
        //    History.Instance.AddToLogFile("Calling AddToFile method to add the booked product details to file.");
        //    storage.Add(product,fare);

        //    Console.WriteLine("Car Product saved");
        //}
    }
}
