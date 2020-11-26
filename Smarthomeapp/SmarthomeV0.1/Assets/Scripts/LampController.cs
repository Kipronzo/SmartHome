using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public float CurrentIntensity;
    public float SensorData;
    [SerializeField] private Light myLight;
    public static int scroll = 8;
    public float desired = scroll / 10;

    public float eint;
    public float eprev;

    public float kp;

    public float ki;

    public float kd;

    public float sensor = 0f;

    private void Awake()
    {
        eint = 0f;
        eprev = 0f;
        myLight.intensity = 0f;
    }

    private void OnValidate()
    {
        Awake();
    }

    private void LateUpdate()
    {
        SensorData = LightCheck.LightLevel;
        float dt = Time.deltaTime;
        sensor = SensorData / 100000;
        float e = desired - sensor;
        float edot = (e - eprev) / dt;
        eint = eint + e * dt;
        float u = kp * e + ki * eint + kd * edot;
        if (u < 0f)
            u = 0f;
        eprev = e;
        myLight.intensity = u;
        CurrentIntensity = u;
    }

    //void Update()
    //{
    //    if (LightCheck.LightLevel > 450000 || (DayNightController.currentTimeOfDay > 0.3))
    //    {
    //        myLight.intensity = 0;
    //    }
    //    if (LightCheck.LightLevel > 450000 || (DayNightController.currentTimeOfDay < 0.7))
    //    {
    //        myLight.intensity = 0;
    //    }
    //    if (LightCheck.LightLevel <= 450000 && (DayNightController.currentTimeOfDay < 0.3))
    //    {
    //    CurrentIntensity = LightCheck.LightLevel / 1000000;
    //    myLight.intensity = 2 - (1 + CurrentIntensity) + desired;
    //    }
    //    if (LightCheck.LightLevel <= 450000 && (DayNightController.currentTimeOfDay > 0.7))
    //    {
    //        CurrentIntensity = LightCheck.LightLevel / 1000000;
    //        myLight.intensity = 2 - (1 + CurrentIntensity) + desired;
    //    }
    //}
}
