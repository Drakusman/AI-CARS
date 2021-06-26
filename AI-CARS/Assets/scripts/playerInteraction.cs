using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteraction : MonoBehaviour
{
    [Header("Lights")]
    public GameObject lowBeams;
    public GameObject fullBeams;
    public GameObject hazardLights;
    public GameObject sideLights;
    public GameObject brakeLights;
    public GameObject blinkersL;
    public GameObject blinkersR;

    [Header("UI interface")]
    public GameObject blinkers_img;
    public GameObject fullBeams_img;
    public GameObject lowBeams_img;
    public GameObject sideLights_img;
    public GameObject brake_img;
    public GameObject fuel_img;
    public GameObject hazadLights_img;

    public bool lights_on = false;
    public bool brake_on = false;
    public bool blinkL = false;
    public bool blinkR = false;
    public bool hazard = false;
    public bool isblinkingTurn = false;
    public bool isblinkingHazard = false;

    //var to check if turn off sideLights when low/full beam turned off
    public bool sideLightsToogle = false;

    public bool tutorial_1_end = false;
    public bool tutorial_2_end = false;
    [Header("Audio sources")]
    public AudioClip blinkingAudio;
    public AudioClip hornAudio;
    private AudioSource mainAudio;

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

    private void Start()
    {
        #region UI Cockpit
        blinkers_img = GameObject.Find("blinkers_img");
        fullBeams_img = GameObject.Find("fullBeams_img");
        lowBeams_img = GameObject.Find("lowBeams_img");
        sideLights_img = GameObject.Find("sideLights_img");
        brake_img = GameObject.Find("brake_img");
        fuel_img = GameObject.Find("fuel_img");
        hazadLights_img = GameObject.Find("hazardLights_img");

        hide_UI_Cockpit();
        #endregion
        //load audio sources
        //for hazad na blinking lights
        blinkingAudio = Resources.Load<AudioClip>("sound/blinkingTurn");
        hornAudio = Resources.Load<AudioClip>("sound/car_horn1");
        mainAudio = GetComponent<AudioSource>();

        lowBeams.SetActive(false);
        fullBeams.SetActive(false);
        hazardLights.SetActive(false);
        sideLights.SetActive(false);
        brakeLights.SetActive(false);
        blinkersL.SetActive(false);
        blinkersR.SetActive(false);
    }
    void Update()
    {
        //horn sound
        if (Input.GetKey(KeyCode.H))
        {
            AudioSource.PlayClipAtPoint(hornAudio, transform.position);
        }
        //toogle brake
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (brake_on)
            {
                brake_img.SetActive(false);
                AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("sound/car_brake_down"), transform.position);
            }
            else
            {
                brake_img.SetActive(true);
                AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("sound/car_brake_up"), transform.position);
            }
            brake_on = !brake_on;

        }
        //toogle sidelights
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!fullBeams.activeSelf && !lowBeams.activeSelf)
            {
                sideLights.SetActive(!sideLights.activeSelf);
                sideLights_img.SetActive(!sideLights_img.activeSelf);
                sideLightsToogle = true;

            }
        }
        //toogle lowBeams
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!fullBeams.activeSelf)
            {
                lowBeams.SetActive(!lowBeams.activeSelf);
                lowBeams_img.SetActive(!lowBeams_img.activeSelf);
                sideLights.SetActive(true);
                sideLightsToogle = false;
            }

        }
        //toogle fullBeams
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (!lowBeams.activeSelf)
            {
                fullBeams.SetActive(!fullBeams.activeSelf);
                fullBeams_img.SetActive(!fullBeams_img.activeSelf);
                sideLights.SetActive(true);
                sideLightsToogle = false;
            }

        }
        if (!lowBeams.activeSelf && !fullBeams.activeSelf && !sideLightsToogle)
        {
            sideLights.SetActive(false);
            sideLightsToogle = false;
        }
        //turn on hazardLights
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!blinkL && !blinkR && !isblinkingTurn)
            {

                hazard = !hazard;
                hazadLights_img.SetActive(!hazadLights_img.activeSelf);
            }

        }
        if (hazard && !isblinkingHazard)
        {
            StartCoroutine(blinkingHazard());
        }
        //turn off hazard
        if (!hazard && !isblinkingHazard && !blinkL && !blinkR)
        {
            StopAllCoroutines();
        }
        //turn on left blinkers
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!blinkR && !hazard)
            {
                blinkers_img.SetActive(!blinkers_img.activeSelf);
                blinkL = !blinkL;
            }

        }
        //turn on right blinkers
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!blinkL && !hazard)
            {
                blinkers_img.SetActive(!blinkers_img.activeSelf);
                blinkR = !blinkR;
            }
        }

        //start/stop corutines blinking turn
        if (blinkL && !blinkR && !hazard)
        {
            if (!isblinkingTurn)
            {
                StartCoroutine(blinkingTurnLeft());
            }

        }
        else if (blinkR && !blinkL && !hazard)
        {
            if (!isblinkingTurn)
            {
                StartCoroutine(blinkingTurnRight());
            }
        }
        else if (hazard)
        {
            //dont stop corutine when hazard turned on and blinking off!
        }
        else
        {
            StopAllCoroutines();
            mainAudio.Stop();
            blinkers_img.SetActive(false); ;

            blinkersL.SetActive(false);
            blinkersR.SetActive(false);
            hazardLights.SetActive(false);

            isblinkingTurn = false;
            isblinkingHazard = false;
        }


        if (!tutorial_1_end)
        {
            tutorial_1_check();
        }
        if (!tutorial_2_end)
        {
            tutorial_2_check();
        }
    }
    void hide_UI_Cockpit()
    {
        blinkers_img.SetActive(false);
        fullBeams_img.SetActive(false);
        lowBeams_img.SetActive(false);
        sideLights_img.SetActive(false);
        brake_img.SetActive(false);
        fuel_img.SetActive(false);
        hazadLights_img.SetActive(false);
    }
    IEnumerator blinkingTurnLeft()
    {
        mainAudio.clip = blinkingAudio;
        mainAudio.Play();

        isblinkingTurn = true;

        blinkersL.SetActive(!blinkersL.activeSelf);
        yield return new WaitForSeconds(0.45f);

        blinkersL.SetActive(!blinkersL.activeSelf);
        yield return new WaitForSeconds(0.45f);

        isblinkingTurn = false;
    }
    IEnumerator blinkingTurnRight()
    {
        mainAudio.clip = blinkingAudio;
        mainAudio.Play();

        isblinkingTurn = true;

        blinkersR.SetActive(!blinkersR.activeSelf);
        yield return new WaitForSeconds(0.45f);

        blinkersR.SetActive(!blinkersR.activeSelf);
        yield return new WaitForSeconds(0.45f);

        isblinkingTurn = false;
    }
    IEnumerator blinkingHazard()
    {
        mainAudio.clip = blinkingAudio;
        mainAudio.Play();

        isblinkingHazard = true;

        hazardLights.SetActive(!hazardLights.activeSelf);
        yield return new WaitForSeconds(0.45f);

        hazardLights.SetActive(!hazardLights.activeSelf);
        yield return new WaitForSeconds(0.45f);

        isblinkingHazard = false;

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
        if (pressed_W && pressed_S && pressed_A && pressed_D)
        {
            tutorial_2_end = true;
        }


    }
}
