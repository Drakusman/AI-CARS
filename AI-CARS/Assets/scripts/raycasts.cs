using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasts : MonoBehaviour
{
    //switch between visibility of rays 
    public bool Debug_show_rays = true;
    // all 8 raycasts and hits, that check collisions.
    Ray F, FR, R, RB, B, BL, L, FL;
    RaycastHit H_F, H_FR, H_R, H_RB, H_B, H_BL, H_L, H_FL;

    void Start()
    {
        
    }

    void Update()
    {
        showRaycast();
    }
    //display debug rays of raycasts
    private void showRaycast()
    {
        if(Debug_show_rays)
        {
            //front
            Debug.DrawRay(transform.position, transform.forward, Color.green);
            //back
            Debug.DrawRay(transform.position, -transform.forward, Color.green);
            //right
            Debug.DrawRay(transform.position, transform.right, Color.green);
            //left
            Debug.DrawRay(transform.position, -transform.right, Color.green);
            //front right
            Debug.DrawRay(transform.position, transform.forward + transform.right, Color.green);
            // front left
            Debug.DrawRay(transform.position, transform.forward - transform.right, Color.green);
            //back right
            Debug.DrawRay(transform.position, -transform.forward + transform.right, Color.green);
            //back left
            Debug.DrawRay(transform.position, -transform.forward - transform.right, Color.green);
        }
        
    }
}
