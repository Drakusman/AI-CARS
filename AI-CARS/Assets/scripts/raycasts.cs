using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasts : MonoBehaviour
{
    //Debug - all date that are showed to the dev by consol or graphical

    //switch between visibility of rays 
    public bool DebugShowRaysToggle = true;
    public bool DebugShowHitInfoToggle = true;
    //Debug range of raycast
    public float DebugRayLength = 1f;
    //range of raycast
    public float rayLength = 5f;
    // all 8 raycasts and hits, that check collisions.
    /* 
     * F - Front
     * FR - FrontRight
     * BR - BackRight
     * B - Back
     * BL - BackLeft
     * L - Left
     * FL - FrontLeft
    */ 
    Ray F, FR, R, BR, B, BL, L, FL;
    RaycastHit H_F, H_FR, H_R, H_BR, H_B, H_BL, H_L, H_FL;

    void Start()
    {
       
    }

    void Update()
    {
        updateRays();

        showRaycast();

        startRayCasting();
    }

    //display debug raycasts of rays - don't care about other methodes
    private void showRaycast()
    {
        if(DebugShowRaysToggle)
        {

            //there is a issue with ray lenght of 4 diagonal rays frontleft etc... forced to set them to magnitude lenght
            //front
            Debug.DrawRay(transform.position, transform.forward * DebugRayLength, Color.green);
            //back
            Debug.DrawRay(transform.position, -transform.forward * DebugRayLength, Color.green);
            //right
            Debug.DrawRay(transform.position, transform.right * DebugRayLength, Color.green);
            //left
            Debug.DrawRay(transform.position, -transform.right * DebugRayLength, Color.green);
            //front right
            Debug.DrawRay(transform.position, (transform.forward + transform.right) * DebugRayLength, Color.green);
            // front left
            Debug.DrawRay(transform.position, (transform.forward - transform.right) * DebugRayLength, Color.green);
            //back right
            Debug.DrawRay(transform.position, (-transform.forward + transform.right) * DebugRayLength, Color.green);
            //back left
            Debug.DrawRay(transform.position, (-transform.forward - transform.right) * DebugRayLength, Color.green);
        }
        
    }
    //methode that updates position and direction of all rays.
    private void updateRays()
    {
        //source of ray
        F.origin = transform.position;
        FR.origin = transform.position;
        FL.origin = transform.position;
        BL.origin = transform.position;
        BR.origin = transform.position;
        B.origin = transform.position;
        R.origin = transform.position;
        L.origin = transform.position;

        //direction of ray
        F.direction = transform.forward;
        FR.direction = transform.forward + transform.right;
        FL.direction = transform.forward - transform.right;
        BL.direction = -transform.forward - transform.right;
        BR.direction = -transform.forward + transform.right;
        B.direction = -transform.forward;
        R.direction = transform.right;
        L.direction = -transform.right;
    }
    private void startRayCasting()
    {
        if(DebugShowHitInfoToggle)
        {
            if (Physics.Raycast(F, out H_F, rayLength))
            {
                print(DebugShowHitInfo(H_F) + "Front");
            }
            if (Physics.Raycast(FR, out H_FR, new Vector2(rayLength, rayLength).magnitude))
            {
                print(DebugShowHitInfo(H_FR) + "FrontRight");
            }
            if (Physics.Raycast(FL, out H_FL, new Vector2(rayLength, rayLength).magnitude))
            {
                print(DebugShowHitInfo(H_FL) + "FrontLeft");
            }
            if (Physics.Raycast(B, out H_B, rayLength))
            {
                print(DebugShowHitInfo(H_B) + "Back");
            }
            if (Physics.Raycast(BR, out H_BR, new Vector2(rayLength, rayLength).magnitude))
            {
                print(DebugShowHitInfo(H_BR) + "BackRight");
            }
            if (Physics.Raycast(BL, out H_BL, new Vector2(rayLength, rayLength).magnitude))
            {
                print(DebugShowHitInfo(H_BL) + "BackLeft");
            }
            if (Physics.Raycast(L, out H_L, rayLength))
            {
                print(DebugShowHitInfo(H_L) + "Left");
            }
            if (Physics.Raycast(R, out H_R, rayLength))
            {
                print(DebugShowHitInfo(H_R) + "Right");
            }
        }
        
    }
    //methode that generates text that will be displayed whenever ray hit target in range
    private string DebugShowHitInfo(RaycastHit hit)
    {
        return "Detected raycast hit name: " + hit.transform.name + ". At distance: " + hit.distance +". Direction: ";
    }
}
