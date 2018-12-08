using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITShare.csharp.Module4.Classes
{
    // IComparable built in interface
     public class Car:IComparable
    {
        public override bool Equals(object obj)
        {
            Car car = obj as Car;
            if (this.Name == car.Name) return true;
            else return false;
        }

        //fields
        protected string name;
        string model;
        string carState;
        int yearOfMade;
        int km;


        //properties
        public int KM { get { return km; } set { km = value; } }
        public string Name {
            get { return name; }
            set
            {
                this.name = value;
            }
        }
        public string Model { get { return this.model; } }
        public string CarState { set { carState = value; } }
        public bool IsExpired { get; set; }
        public DateTime ExpirationDate => DateTime.Now; 
        /// <summary>
        /// indexer
        /// </summary>
        /// 
        public string this[int index] { get { if (index == 0) return name; else return string.Empty; } }
        

        // car[0]

        //constructor

        public Car()
        {
            this.name = string.Empty; // "" or nulls
            
            

        }
        public Car(string name, int year,string motorSize)
        {
            this.name = name;
            this.carState = "off";
           
            yearOfMade = year;
        }
        public Car(string _name,int year)
        {

            this.carState = "off";
            name = _name;
            yearOfMade = year;
        }
        /// <summary>
        ///  common use of properties inside classes
        /// </summary>
        public int YearOfMade { get; set; }



        #region private functions

        void switchOn()
        {
            carState = "on";
        }
        void switchOff()
        {
            carState = "off";
        }
        void saveDtabase()
        {
            try
            {
                //

            }
            catch(Exception e)
            {
                FileLog logger = new FileLog();

                logger.LogMessage(e.Message);
            }
        }

       
        public int CalculateNumberofKM()
        {
            // return number of kilometers
            return km;
        }

        public int CompareTo(object obj)
        {
            if (obj is Car)
            {
                Car c = obj as Car;
                return this.km.CompareTo(c.km);
            }
            else return 1;
        }

        #endregion

        #region public function
        #endregion
    }



   public class CarCollection
    {
        Car[] carsList;
        public CarCollection()
        {
            carsList = new Car[] { new Car() };
        }
        public Car[] GetAllNewCars()
        {
            // filter cars list to get only the new cars
            return new Car[]{ new Car()};
        }

        public Car this[int index] { get { return this.carsList[index];
            } }
    }
}
