using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public Transform previous_point;
    public Transform next_point;
    
    [Header("Turn ways")]
    public Transform turnPoint1;
    public Transform turnPoint2;
    public Transform turnPoint3;
    public Transform returnPoint;

    [Header("Auto Set")]
    public bool turn = false;
    public bool returnPossible = false;

    [Header("List of all connected points")]
    public List<Transform> turnList = new List<Transform>();

    public enum Direction
    {
        right, left // right - > go by the right side of road / left -> go by the left side of road
    }
    public Direction direction;
    private void Start()
    {
        if(turnPoint1!=null || turnPoint2 != null || turnPoint3 != null || returnPoint != null)
        {
            turn = true;
        }
        try
        {
            turnList.Add(turnPoint1);
        }
        catch(Exception ex1)
        {
            try
            {
                turnList.Add(turnPoint2);
            }
            catch(Exception ex2)
            {
                try
                {
                    turnList.Add(turnPoint3);
                }
                catch(Exception ex3)
                {

                }
            }
        }
        if(returnPossible)
        {
            turnList.Add(returnPoint);
        }
        
    }
   

    private void OnDrawGizmosSelected()
    {
        if(direction == Direction.left)
        {
            Gizmos.color = Color.red;
        }
        else
        {
            Gizmos.color = Color.blue;

        }
        
        Gizmos.DrawLine(transform.position, next_point.transform.position);
    }
}
