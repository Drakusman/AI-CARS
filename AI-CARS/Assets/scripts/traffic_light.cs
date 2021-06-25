using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traffic_light : MonoBehaviour
{
    public enum LightColor
    {
        red, yellow, green
    }
    [Header("Light Gameobjects")]
    public GameObject red;
    public GameObject yellow;
    public GameObject green;

    [Header("Light's time")]
    public LightColor lightColor;
    public int greenTime;
    public int yellowTime;
    public int redTime;
    public float to_red = 0;

    public crossRoad.Traffic_Pair traffic_Pair;

    bool change = true;
    
    void Start()
    {
        to_red = greenTime + 2 * yellowTime;
        traffic_Pair = crossRoad.Traffic_Pair.green_red;
    }

    void Update()
    {
        to_red -= Time.deltaTime;
        if(change)
        {
            change = false;
            if(traffic_Pair == crossRoad.Traffic_Pair.green_red)
            {
                StopCoroutine(changeLight_red());
                StartCoroutine(changeLight_green());
            }
            if (traffic_Pair == crossRoad.Traffic_Pair.red_green)
            {
                StopCoroutine(changeLight_green());
                StartCoroutine(changeLight_red());
            }

        }
        

        switch (lightColor)
        {
            case LightColor.green:
                {
                    green.GetComponent<Renderer>().material.color = Color.green;
                    yellow.GetComponent<Renderer>().material.color = Color.white;
                    red.GetComponent<Renderer>().material.color = Color.white;
                    break;
                }
            case LightColor.yellow:
                {
                    yellow.GetComponent<Renderer>().material.color = Color.yellow;

                    green.GetComponent<Renderer>().material.color = Color.white;
                    red.GetComponent<Renderer>().material.color = Color.white;
                    break;
                }
            case LightColor.red:
                {
                    red.GetComponent<Renderer>().material.color = Color.red;

                    yellow.GetComponent<Renderer>().material.color = Color.white;
                    green.GetComponent<Renderer>().material.color = Color.white;
                    to_red = greenTime + 2 * yellowTime;
                    break;
                }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="player" && lightColor == LightColor.red)
        {
            print("Passed on red!");
        }
        if (other.gameObject.tag == "player" && lightColor == LightColor.yellow)
        {
            print("That was close!");
        }
    }
    public IEnumerator changeLight_green()
    {
        lightColor = LightColor.green;
        yield return new WaitForSeconds(greenTime);
        lightColor = LightColor.yellow;
        yield return new WaitForSeconds(yellowTime);
        lightColor = LightColor.red;
        yield return new WaitForSeconds(redTime);
        lightColor = LightColor.yellow;
        yield return new WaitForSeconds(yellowTime);
        change = true;
    }
    public IEnumerator changeLight_red()
    {
        lightColor = LightColor.red;
        yield return new WaitForSeconds(redTime);
        lightColor = LightColor.yellow;
        yield return new WaitForSeconds(yellowTime);
        lightColor = LightColor.green;
        yield return new WaitForSeconds(greenTime);
        lightColor = LightColor.yellow;
        yield return new WaitForSeconds(yellowTime);
        change = true;
    }
}
