using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private bool privateCar;
        private int speed;

        public string GetId() { return id; }
        public void SetId(string id) { this.id = id; }

        public bool GetIsPrivate() { return privateCar; }
        public void SetIsPrivate(bool privateCar) { this.privateCar = privateCar; }

        public int GetSpeed() { return speed; }
        public void SetSpeed(int speed) { this.speed = speed; }

        public bool Illegal(int maxSpeed)
        {
            return privateCar || speed > maxSpeed;
        }
    }

    public class CameraInfo
    {
        private int city;
        private int maxSpeed;
        private CarInfo[] cars;

        public int GetCity() { return city; }
        public void SetCity(int city) { this.city = city; }

        public int GetMaxSpeed() { return maxSpeed; }
        public void SetMaxSpeed(int maxSpeed) { this.maxSpeed = maxSpeed; }

        public CarInfo[] GetCars() { return cars; }
        public void SetCars(CarInfo[] cars) { this.cars = cars; }


        public bool AllGood()
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
            int count = 0;
            for (int cityCode = 0; cityCode < 100; cityCode++)
            {
                bool allGood = true;
                
                for (int j = 0; j < cameras.Length; j++)
                {
                    if (cityCode == cameras[j].GetCity())
                    {
                        if (!cameras[j].AllGood())
                        {
                            allGood = false;
                            break;
                        }
                    }
                }
                if (allGood)
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
