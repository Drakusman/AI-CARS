using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public enum Traction
    {
        front, back, _4x4
    }
    public enum SpeedValue
    {
        km_h,mph
    }
   
    //car wheel colliders
    [Header("Wheel Colliders")]
    public WheelCollider wheelColliderFL;
    public WheelCollider wheelColliderFR;
    public WheelCollider wheelColliderBL;
    public WheelCollider wheelColliderBR;

    // car wheel transforms
    [Header("Wheel Transforms")]
    public Transform wheelFL;
    public Transform wheelFR;
    public Transform wheelBL;
    public Transform wheelBR;

    // is car braking or not.
    private bool braking = false;

    private Rigidbody rigidbody;

    //acceleration
    [Header("Motor settings")]
    public float motorTorque = 400f;
    public float maxSpeed = 100f;
    public SpeedValue speedValue;
    //max angle of steering
    [Header("Wheel settings")]
    public Traction traction;
    public float maxSteer = 20f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

        maxSpeed /= 3.6f;
   
    }
    private void Update()
    {
        if(speedValue == SpeedValue.km_h)
        {
            print("Velocity: " + Mathf.Round(rigidbody.velocity.magnitude * 3.6f) + " Km/h");
        }
        else
        {
            print("Velocity: " + Mathf.Round(rigidbody.velocity.magnitude * 3.6f * 0.62f) + " Mph");
        }
       
    }

    private void FixedUpdate()
    {
        
        //car's traction type
        switch(traction)
        {
            case Traction.front:
            {
                    wheelColliderFL.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                    wheelColliderFR.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                    break;
            }
            case Traction.back:
                {
                    wheelColliderBL.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                    wheelColliderBR.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                    break;
                }
            case Traction._4x4:
                {
                    wheelColliderBL.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                    wheelColliderBR.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                    wheelColliderFL.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                    wheelColliderFR.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                    break;
                }
        }
        

        //max steering angle of wheels
        wheelColliderFL.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
        wheelColliderFR.steerAngle = Input.GetAxis("Horizontal") * maxSteer;

        //wheel rotation
        front_wheel_rotation();

        //check if you pass the max speed
        var velocityVector = rigidbody.velocity;

        if (rigidbody.velocity.magnitude > maxSpeed)
        {
            rigidbody.velocity = velocityVector.normalized * maxSpeed;
        }
    }
    //methode which set rotation and position of front wheels while driving *just animation of rotation*
    private void front_wheel_rotation()
    {
        var pos = Vector3.zero;
        var rot = Quaternion.identity;
        
        wheelColliderFL.GetWorldPose(out pos, out rot);
        wheelFL.position = pos;
        wheelFL.rotation = rot;

        wheelColliderFR.GetWorldPose(out pos, out rot);
        wheelFR.position = pos;
        wheelFR.rotation = rot * Quaternion.Euler(0, 180, 0);
        
        wheelColliderBL.GetWorldPose(out pos, out rot);
        wheelBL.position = pos;
        wheelBL.rotation = rot;
        
        wheelColliderBR.GetWorldPose(out pos, out rot);
        wheelBR.position = pos;
        wheelBR.rotation = rot * Quaternion.Euler(0, 180, 0);
        
    }
}
