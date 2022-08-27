using System;
namespace Design_Patterns.Class
{
    public abstract  class CarClassCreator
    {
        public abstract ICar CreatCar(CarClass carClass);
    }

    public class CarCreator : CarClassCreator
    {

        public override ICar CreatCar(CarClass carClass)
        {
            ICar car = null;
            switch (carClass)
            {
                case CarClass.Sedan:
                    car = new SedanCar();
                    break;
                case CarClass.Coupe:
                    car = new CoupeCar();
                    break;
                case CarClass.Van:
                    car = new VanCar();
                    break;
                case CarClass.Suv:
                    car = new SuvCar();
                    break;
                case CarClass.Cross:
                    car = new CossCar();
                    break;
            }
            return car;
        }
    }

    public interface ICar
    {
        string GetCarClass();
    }
    public class SedanCar : ICar
    {
        public string GetCarClass()
        {
            return CarClass.Sedan.ToString();
        }
    }

    public class CoupeCar : ICar
    {
        public string GetCarClass()
        {
            return CarClass.Coupe.ToString();
        }
    }

    public class VanCar : ICar
    {
        public string GetCarClass()
        {
            return CarClass.Van.ToString();
        }
    }
    public class SuvCar : ICar
    {
        public string GetCarClass()
        {
            return CarClass.Suv.ToString();
        }
    }
    public class CossCar : ICar
    {
        public string GetCarClass()
        {
            return CarClass.Cross.ToString();
        }
    }
    public enum CarClass
    {
        Sedan,
        Coupe,
        Van,
        Suv,
        Cross
    }
}