using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public enum Gearbox
    {
        manual, automatic
    }
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

    private Rigidbody _rigidbody;

    //acceleration
    [Header("Motor settings")]
    public float motorTorque = 400f;
    public float maxSpeed = 100f;
    
    //max angle of steering
    [Header("Wheel settings")]
    public Traction traction;
    public float maxSteer = 20f;
    public float brakeTorque = 10000f;
    public bool handBrake = false;

    [Header("Cockpit settings")]
    public bool DebugShowSpeed = true;
    public SpeedValue speedValue;
    public float speed;
    public float torque;

    [Header("Transmission settings")]
    public Gearbox gearbox;
    public int gears = 5;
    public int current_gear = 1;

    private string keyPressed;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();

        maxSpeed /= 3.6f;
   
    }
    private void Update()
    {
        //update the current torque
        if(traction==Traction.back || traction==Traction._4x4)
        {
            torque = wheelColliderBL.motorTorque;
        }
        else
        {
            torque = wheelColliderFL.motorTorque;
        }
        
        if(speedValue == SpeedValue.km_h)
        {
            speed = Mathf.Round(_rigidbody.velocity.magnitude * 3.6f);
        }
        else
        {
            speed = Mathf.Round(_rigidbody.velocity.magnitude * 3.6f * 0.62f);
        }
        if(Input.GetKey(KeyCode.W))
        {
            keyPressed = "w";
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            keyPressed = "s";
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            keyPressed = " ";
        }
      

        if (speedValue == SpeedValue.km_h && DebugShowSpeed)
        {
            print("Velocity: " + Mathf.Round(_rigidbody.velocity.magnitude * 3.6f) + " Km/h");
        }
        if(speedValue == SpeedValue.mph && DebugShowSpeed)
        {
            print("Velocity: " + Mathf.Round(_rigidbody.velocity.magnitude * 3.6f * 0.62f) + " Mph");
        }

       
    }

    private void FixedUpdate()
    {
        
        //car's traction type
        switch (traction)
        {
            case Traction.front:
            {
                    
                        switch (keyPressed)
                        {
                            case "w":
                                {
                                    wheelColliderFL.motorTorque = Input.GetAxis("Vertical") * motorTorque * 2;
                                    wheelColliderFR.motorTorque = Input.GetAxis("Vertical") * motorTorque * 2;

                                    break;
                                }

                            case "s":
                                {  
                                    wheelColliderBL.motorTorque = Input.GetAxis("Vertical") * brakeTorque;
                                    wheelColliderBR.motorTorque = Input.GetAxis("Vertical") * brakeTorque;
                                    wheelColliderFL.motorTorque = Input.GetAxis("Vertical") * brakeTorque;
                                    wheelColliderFR.motorTorque = Input.GetAxis("Vertical") * brakeTorque;

                                    break;
                                }

                            case " ":
                                {
                                    if (handBrake == false)
                                    {
                                        wheelColliderBL.motorTorque = 0;
                                        wheelColliderBR.motorTorque = 0;
                                        wheelColliderFL.motorTorque = 0;
                                        wheelColliderFR.motorTorque = 0;

                                        wheelColliderBL.brakeTorque = brakeTorque;
                                        wheelColliderBR.brakeTorque = brakeTorque;
                                        wheelColliderFL.brakeTorque = brakeTorque;
                                        wheelColliderFR.brakeTorque = brakeTorque;

                                        handBrake = true;
                                    }
                                    else
                                    {
                                        wheelColliderBL.brakeTorque = 0;
                                        wheelColliderBR.brakeTorque = 0;
                                        wheelColliderFL.brakeTorque = 0;
                                        wheelColliderFR.brakeTorque = 0;
                                        handBrake = false;
                                    }
                                keyPressed = "";
                                break;
                                }
                        }
                    

                    break;
            }
            case Traction.back:
                {
                   
                        switch (keyPressed)
                        {
                            case "w":
                                {
                                    wheelColliderBL.motorTorque = Input.GetAxis("Vertical") * motorTorque * 2;
                                    wheelColliderBR.motorTorque = Input.GetAxis("Vertical") * motorTorque * 2;

                                    break;
                                }

                            case "s":
                                { 
                                    wheelColliderBL.motorTorque = Input.GetAxis("Vertical") * brakeTorque;
                                    wheelColliderBR.motorTorque = Input.GetAxis("Vertical") * brakeTorque;
                                    wheelColliderFL.motorTorque = Input.GetAxis("Vertical") * brakeTorque;
                                    wheelColliderFR.motorTorque = Input.GetAxis("Vertical") * brakeTorque;

                                    break;
                                }

                            case " ":
                                {
                                    if (!handBrake)
                                    {
                                        wheelColliderBL.motorTorque = 0;
                                        wheelColliderBR.motorTorque = 0;
                                        wheelColliderFL.motorTorque = 0;
                                        wheelColliderFR.motorTorque = 0;

                                        wheelColliderBL.brakeTorque = brakeTorque;
                                        wheelColliderBR.brakeTorque = brakeTorque;
                                        wheelColliderFL.brakeTorque = brakeTorque;
                                        wheelColliderFR.brakeTorque = brakeTorque;

                                        handBrake = true;
                                    }
                                    else
                                    {
                                        wheelColliderBL.brakeTorque = 0;
                                        wheelColliderBR.brakeTorque = 0;
                                        wheelColliderFL.brakeTorque = 0;
                                        wheelColliderFR.brakeTorque = 0;
                                        handBrake = false;
                                    }
                                keyPressed = "";
                                break;
                                }
                        }
                    

                    break;
                }
            case Traction._4x4:
                {
                    
                        switch (keyPressed)
                        {
                            case "w":
                                {
                                    wheelColliderBL.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                                    wheelColliderBR.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                                    wheelColliderFL.motorTorque = Input.GetAxis("Vertical") * motorTorque;
                                    wheelColliderFR.motorTorque = Input.GetAxis("Vertical") * motorTorque;

                                    break;
                                }

                            case "s":
                                {
                                    wheelColliderBL.motorTorque = Input.GetAxis("Vertical") * brakeTorque;
                                    wheelColliderBR.motorTorque = Input.GetAxis("Vertical") * brakeTorque;
                                    wheelColliderFL.motorTorque = Input.GetAxis("Vertical") * brakeTorque;
                                    wheelColliderFR.motorTorque = Input.GetAxis("Vertical") * brakeTorque;

                                    break;
                                }

                            case " ":
                                {
                                    if (handBrake == false)
                                    {
                                        wheelColliderBL.motorTorque = 0;
                                        wheelColliderBR.motorTorque = 0;
                                        wheelColliderFL.motorTorque = 0;
                                        wheelColliderFR.motorTorque = 0;

                                        wheelColliderBL.brakeTorque = brakeTorque;
                                        wheelColliderBR.brakeTorque = brakeTorque;
                                        wheelColliderFL.brakeTorque = brakeTorque;
                                        wheelColliderFR.brakeTorque = brakeTorque;

                                        handBrake = true;
                                    }
                                    else
                                    {
                                        wheelColliderBL.brakeTorque = 0;
                                        wheelColliderBR.brakeTorque = 0;
                                        wheelColliderFL.brakeTorque = 0;
                                        wheelColliderFR.brakeTorque = 0;
                                        handBrake = false;
                                    }
                                keyPressed = "";
                                break;
                                }
                        }  
                    

                    break;
                }
        }
        

        //max steering angle of wheels
        wheelColliderFL.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
        wheelColliderFR.steerAngle = Input.GetAxis("Horizontal") * maxSteer;

        //wheel rotation
        front_wheel_rotation();

        //check if you pass the max speed
        var velocityVector = _rigidbody.velocity;

        if (_rigidbody.velocity.magnitude > maxSpeed)
        {
            _rigidbody.velocity = velocityVector.normalized * maxSpeed;
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
