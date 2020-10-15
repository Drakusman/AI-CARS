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
        showRaycast();
        startRayCasting();
    }
    //display debug rays of raycasts
    private void showRaycast()
    {
        if(DebugShowRaysToggle)
        {
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
    private void startRayCasting()
    {
        if (Physics.Raycast(F, out H_F, rayLength))
        {
            print(DebugShowHitInfo(H_F) + "Front");
        }    
       
        Physics.Raycast(FR, out H_FR, rayLength);
        Physics.Raycast(FL, out H_FL, rayLength);
        Physics.Raycast(B, out H_B, rayLength);
        Physics.Raycast(BL, out H_BL, rayLength);
        Physics.Raycast(BR, out H_BR, rayLength);
        Physics.Raycast(L, out H_L, rayLength);
        Physics.Raycast(R, out H_R, rayLength);
    }
    private string DebugShowHitInfo(RaycastHit hit)
    {
        return "Detected raycast hit name: " + hit.transform.name + ". At distance: " + hit.distance +". Direction: ";
    }
}
