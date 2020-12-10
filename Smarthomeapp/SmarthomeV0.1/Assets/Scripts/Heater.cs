using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heater : MonoBehaviour
{
    public float HeatIntensity = 1f;

    public float DesiredTemperature;

    public float StepValue = 1f;

    public float SensorData;

    public float eint;
    public float eprev;

    public float kp;

    public float ki;

    public float kd;

    public HeatSensor Sensor;

    private void Awake()
    {
        eint = 0f;
        eprev = 0f;
        //HeatIntensity = 0f;
    }

    private void OnValidate()
    {
        Awake();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //return;
        SensorData = Sensor.GetTemperature();
        float dt = Time.deltaTime;
        //float sensor = SensorData / 100000;
        float e = DesiredTemperature - SensorData;
        float edot = (e - eprev) / dt;
        eint += e * dt;
        float u = (kp * e) + (ki * eint) + (kd * edot);
        if (u < 0f)
            u = 0f;
        eprev = e;
        HeatIntensity = u;
        //myLight.intensity = u;
        //CurrentIntensity = u;
    }

    public float GetTemperature(GameObject gameObject)
    {
        var distance = Vector3.Distance(transform.position, gameObject.transform.position);

        var step = Mathf.Exp(-StepValue * Mathf.Pow(distance, StepValue));
        //Debug.LogError(step);
        return HeatIntensity * step;
    }
}
