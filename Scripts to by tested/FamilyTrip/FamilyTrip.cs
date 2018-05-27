using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class FamilyTrip : MonoBehaviour
{
    public Boolean _printToConsole;
    private Car _car;
    private List<Luggage> _listLuggage;
    public FamilyTrip(List<Luggage> listLuggage, ref Car car)
    {
        _car = car;
        _listLuggage = listLuggage;
    }
    public FamilyTrip(List<Luggage> listLuggage, Car car, Boolean printToConsole)
    {
        _printToConsole = printToConsole;
        _car = car;
        _listLuggage = listLuggage;
    }
    public Boolean PrepareFamilyTrip()
    {
        if (_printToConsole)
            print("Family is Packing the car!");
        Boolean packingIsSuccess = false;
        packingIsSuccess = _car.PackLuggageToTheTrunk(_listLuggage);

        if (!packingIsSuccess)
        {
            if (_printToConsole)
                print("Too much luggage!");
            return false;
        }

        int carFuelLevel = FuelChecker.ReturnfullelLevel();

        if (carFuelLevel < 50)
        {
            if (_printToConsole)
                print("Dad needs to tank our family car!");
        }
        if (_printToConsole)
            print("Yea! We are ready to go!");

        return packingIsSuccess;
    }

    public Boolean PrepareFamilyTripWithoutFunction()
    {
        if (_printToConsole)
            print("Family is Packing the car!");
        Boolean packingIsSuccess = false;
        if (_listLuggage == null)
        {
            try
            {
                throw new Exception("Luggage does not exit!");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

            if (_listLuggage.Capacity > _car._trunkCapacity)
            {
                if (_printToConsole)
                    print("Car trunk is not is not big enouh for such a luggage");
            }
        }
        else
        {
            packingIsSuccess = true;
        }

        if (!packingIsSuccess)
        {
            if (_printToConsole)
                print("Too much luggage!");
        }
        System.Random r = new System.Random();
        int carFuelLevel = r.Next(100);

        if (carFuelLevel < 50)
        {
            if (_printToConsole)
                print("Dad needs to tank our family car!");
        }

        if (_printToConsole)
            print("Yea! We are ready to go!");

        return packingIsSuccess;
    }
}

