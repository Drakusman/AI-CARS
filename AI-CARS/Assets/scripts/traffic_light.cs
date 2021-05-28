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


    bool change = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(change)
        {
            change = false;
            StartCoroutine(changeLight());
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
    IEnumerator changeLight()
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
}
