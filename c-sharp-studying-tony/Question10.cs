using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony
{
    public class Question10
    {

    }
    public class CarInfo
    {
        private string id;
        private bool isPrivate;
        private int speed;

        public string GetId() { return id; }
        public void SetId(string value) { id = value; }

        public bool GetIsPrivate() { return isPrivate; }
        public void SetIsPrivate(bool value) { isPrivate = value; }

        public int GetSpeed() { return speed; }
        public void SetSpeed(int value) { speed = value; }

        internal bool Illegal(int maxSpeed)
        {
            return isPrivate || speed > maxSpeed;
        }
    }

    public class CameraInfo
    {
        private int city;
        private int maxSpeed;
        private CarInfo[] cars;

        public int GetCity() { return city; }
        public void SetCity(int value) { city = value; }

        public int GetMaxSpeed() { return maxSpeed; }
        public void SetMaxSpeed(int value) { maxSpeed = value; }

        public CarInfo[] GetCars() { return cars; }
        public void SetCars(CarInfo[] value) { cars = value; }


        internal bool AllGood()
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null && cars[i].Illegal(maxSpeed))
                {
                    return false;
                }
            }
            return true;
        }


        public static int LegalCities(CameraInfo[] cameras)
        {
            HashSet<int> citiesWithNoViolations = new HashSet<int>();

            for (int i = 0; i < cameras.Length; i++)
            {
                if (cameras[i].AllGood())
                {
                    citiesWithNoViolations.Add(cameras[i].GetCity());
                }
            }

            return citiesWithNoViolations.Count;
        }
    }
}
