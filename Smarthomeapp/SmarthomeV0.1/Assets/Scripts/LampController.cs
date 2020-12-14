using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public float CurrentIntensity;
    public float SensorData;
    [SerializeField] private Light myLight;
    public static int scroll = 10;
    public float desired = 36 / scroll;

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

    /// <summary>
    /// Updates the light's intensity to help reach the desired intensity.
    /// </summary>
    private void LateUpdate()
    {
        SensorData = LightCheck.AvarageLightLevel;
        float dt = Time.deltaTime;
        sensor = SensorData / 100000;
        float e = desired - sensor;
        float edot = (e - eprev) / dt;
        eint += e * dt;
        float u = (kp * e) + (ki * eint) + (kd * edot);
        if (u < 0f)
            u = 0f;
        eprev = e;
        myLight.intensity = u;
        CurrentIntensity = u;
    }

}
