using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossRoad : MonoBehaviour
{
    //4 traffic lights
    [Header("Pair 1")]
    public GameObject light1;
    public GameObject light2;
    [Header("Pair 2")]
    public GameObject light3;
    public GameObject light4;

    public enum Traffic_Pair
    {
        green_red,
        red_green
    }

    void Start()
    {
        //set oposite timing between traffic light on crossroad
        if(light1!=null)
        {
            light1.GetComponent<traffic_light>().traffic_Pair = Traffic_Pair.green_red;
            light1.GetComponent<traffic_light>().lightColor = traffic_light.LightColor.green;
        }
        if (light2 != null)
        {
            light2.GetComponent<traffic_light>().traffic_Pair = Traffic_Pair.green_red;
            light2.GetComponent<traffic_light>().lightColor = traffic_light.LightColor.green;
        }
        if (light3 != null)
        {
            light3.GetComponent<traffic_light>().traffic_Pair = Traffic_Pair.red_green;
            light3.GetComponent<traffic_light>().lightColor = traffic_light.LightColor.red;
        }
        if (light4 != null)
        {
            light4.GetComponent<traffic_light>().traffic_Pair = Traffic_Pair.red_green;
            light4.GetComponent<traffic_light>().lightColor = traffic_light.LightColor.red;
        }
    }

    void Update()
    {
        
    }
}
