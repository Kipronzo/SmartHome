using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatSensor : MonoBehaviour
{
    public DayNightController DayNight;

    public Heater[] Heaters;

   

    public float GetTemperature()
    {
        float baseTemp = DayNight.GetTemperature();

        foreach (var heater in Heaters)
        {
            baseTemp += heater.GetTemperature(gameObject);
        }

        return baseTemp;
    }
}
