using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public float CurrentIntensity;
    [SerializeField] private Light myLight;
    public static int scroll = 8;
    public float desired = scroll / 10;

    void Update()
    {
        if (LightCheck.LightLevel > 450000 || (DayNightController.currentTimeOfDay > 0.3))
        {
            myLight.intensity = 0;
        }
        if (LightCheck.LightLevel > 450000 || (DayNightController.currentTimeOfDay < 0.7))
        {
            myLight.intensity = 0;
        }
        if (LightCheck.LightLevel <= 450000 && (DayNightController.currentTimeOfDay < 0.3))
        {
        CurrentIntensity = LightCheck.LightLevel / 1000000;
        myLight.intensity = 2 - (1 + CurrentIntensity) + desired;
        }
        if (LightCheck.LightLevel <= 450000 && (DayNightController.currentTimeOfDay > 0.7))
        {
            CurrentIntensity = LightCheck.LightLevel / 1000000;
            myLight.intensity = 2 - (1 + CurrentIntensity) + desired;
        }
    }
}
