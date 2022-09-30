using System;
using System.ServiceModel.Syndication;

namespace carSort
{

    class Car : IComparable<Car>
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public decimal Price { get; private set; }

        public Car(string make, string model, decimal price)
        {
            Make = make;
            Model = model;
            Price = price;
        }
        /*public int CompareTo(object obj){
            return Price.compareTo(((Car)obj).Price);
        }*/

        public int CompareTo(Car other)
        {
            return Price.CompareTo(other.Price);
        }
    }

    class CarComparer : IComparer<Car>
    {

        public int Compare(Car? x, Car? y)
        {

            int makeOrder = x.Make.CompareTo(y.Make);
            if (makeOrder != 0)
            {
                return makeOrder;
            }
            int modelOrder = x.Model.CompareTo(y.Model);
            if (modelOrder != 0)
            {
                return modelOrder;
            }
            return x.Price.CompareTo(y.Price);
        }

    }

    class MakeComparer : IComparer<Car>
    {

        public int Compare(Car? x, Car? y)
        {

            return x.Make.CompareTo(y.Make);

        }
    }

    class ModelComparer : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            return x.Model.CompareTo(y.Model);
        }
    }

    class PriceComparer : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }

}