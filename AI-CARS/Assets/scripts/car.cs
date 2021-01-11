using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    //car wheel colliders
    public WheelCollider wheelColliderFL;
    public WheelCollider wheelColliderFR;
    public WheelCollider wheelColliderBL;
    public WheelCollider wheelColliderBR;

    // car wheel transforms
    public Transform wheelFL;
    public Transform wheelFR;
    public Transform wheelBL;
    public Transform wheelBR;

    private Rigidbody rigidbody;
    //speed
    public float motorTorque = 400f;
    //max steer of wheels
    public float maxSteer = 20f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }
    private void FixedUpdate()
    {
        
    }
    private void Update()
    {
        wheelColliderBL.motorTorque = Input.GetAxis("Vertical") * motorTorque;
        wheelColliderBR.motorTorque = Input.GetAxis("Vertical") * motorTorque;
        wheelColliderFL.motorTorque = Input.GetAxis("Vertical") * motorTorque;
        wheelColliderFR.motorTorque = Input.GetAxis("Vertical") * motorTorque;

        wheelColliderFL.steerAngle = Input.GetAxis("Horizontal") * maxSteer;
        wheelColliderFR.steerAngle = Input.GetAxis("Horizontal") * maxSteer;

        front_wheel_rotation();
    }
    //methode which set rotation and position of front wheels while driving
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
