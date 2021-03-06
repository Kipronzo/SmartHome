﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    [SerializeField] private Light sun;
    [SerializeField] private float secondsInFullDay = 120f;

    [Range(0, 1)] 
    public float currentTimeOfDay = 0;
    private float timeMultiplier = 1f;
    private float sunInitialIntensity;

    public float MaxTempDelta = 5f;

    void Start()
    {
        sunInitialIntensity = sun.intensity;
    }
    void Update()
    {
        UpdateSun();

        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;
        if(currentTimeOfDay >= 1)
        {
            currentTimeOfDay = 0;
        }
    }

    /// <summary>
    /// Updates the Sun's position based on the time
    /// </summary>
    void UpdateSun()
    {
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 170, 0);
        float intensityMultiplier = 1;
        if(currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f)
        {
            intensityMultiplier = 0;
        }
        else if(currentTimeOfDay <= 0.25f)
        {
            intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
        }
        else if(currentTimeOfDay >= 0.73f)
        {
            intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));
        }
        sun.intensity = sunInitialIntensity * intensityMultiplier;
    }

    /// <summary>
    /// Returns the outside temperature based on the time of day
    /// </summary>
    /// <returns>Current temperature</returns>
    public float GetTemperature()
    {
        var mult = currentTimeOfDay + 0.5f;
        if (mult > 1f)
        {
            mult = 1f - (mult - 1f);
        }
        return 16f + (MaxTempDelta * mult);
    }
}
