using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeatSensor : MonoBehaviour
{
    public DayNightController DayNight;

    public Heater[] Heaters;

   
    /// <summary>
    /// Return the temperature of the sensor
    /// </summary>
    /// <returns>Temperatur of the sensor</returns>
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
