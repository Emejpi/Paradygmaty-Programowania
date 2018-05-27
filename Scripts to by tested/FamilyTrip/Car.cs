using System;
using System.Collections.Generic;
using System.Text;


    public class Car
    {
        public string _model;
        public int _trunkCapacity;
        public Car(string model, int trunkCapacity)
        {
            _model = model;
            _trunkCapacity = trunkCapacity;
        }


        public Boolean PackLuggageToTheTrunk(List<Luggage> luggage)
        {
            if (luggage == null)
            {
                try
                {
                    throw new Exception("Luggage does not exit!");
                }catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }

            }
            else
            {
                if (luggage.Capacity > _trunkCapacity)
                {
                    Console.WriteLine("Car trunk is not is not big enough for such a luggage" + _trunkCapacity);
                    return false;
                }
            }
            return true;
        }

    }

