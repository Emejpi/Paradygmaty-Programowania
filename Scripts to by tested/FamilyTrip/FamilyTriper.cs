using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyTriper : SpeedTesting
{
    protected FamilyTrip familyTrip;

    public bool printToConsole;

    protected void Awake()
    {
        Luggage momLuggage = new Luggage("Huge momy bag");
        Luggage dadLuggage = new Luggage("Dad tools");
        Luggage sonLuggage = new Luggage("My tennis racket");

        // luggage List:
        List<Luggage> listLuggage = new List<Luggage>();
        listLuggage.Add(momLuggage);
        listLuggage.Add(dadLuggage);
        listLuggage.Add(sonLuggage);

        // Car:
        Car car = new Car("Honda", 1);

        // Family Trip:
        familyTrip = new FamilyTrip(listLuggage, car, printToConsole);
    }
}
