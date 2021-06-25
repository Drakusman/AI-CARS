using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteraction : MonoBehaviour
{
    public GameObject lights;

    public bool lights_on = false;
    public bool brake_on = false;

    public bool tutorial_1_end = false;
    public bool tutorial_2_end = false;

    

    [Header("Task Tutorial 1")]
    bool pressed_HORN = false;
    bool pressed_BRAKE = false;
    bool pressed_LIGHT = false;
    bool pressed_engineON = false;
    bool pressed_engineOFF = false;

    [Header("Task Tutorial 2")]
    bool pressed_W = false;
    bool pressed_S = false;
    bool pressed_A = false;
    bool pressed_D = false;


    void Update()
    {
        if(Input.GetKey(KeyCode.H))
        {
            AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("sound/car_horn1"), transform.position);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            if (brake_on)
            {
                AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("sound/car_brake_down"), transform.position);
            }
            else
            {
                AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("sound/car_brake_up"), transform.position);
            }
            brake_on = !brake_on;
           
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            lights.SetActive(!lights.activeSelf);
            lights_on = !lights_on;
        }
        if(!tutorial_1_end)
        {
            tutorial_1_check();
        }
        if(!tutorial_2_end)
        {
            tutorial_2_check();
        }
    }
    public void tutorial_1_check()
    {
        if (pressed_HORN && pressed_BRAKE && pressed_LIGHT && pressed_engineON && pressed_engineOFF)
        {
            tutorial_1_end = true;
        }




    }
    public void tutorial_2_check()
    {
        if(pressed_W && pressed_S && pressed_A && pressed_D)
        {
            tutorial_2_end = true;
        }



        
    }
}
