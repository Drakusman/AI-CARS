using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarEngine : MonoBehaviour 
{
    [Header("Path start/end points")]
    public GameObject start;
    public GameObject end;

    public bool spawnSet = false;
    public List<Transform> pathTransforms = new List<Transform>();

    [Header("Wheel Colliders")]
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public WheelCollider wheelBL;
    public WheelCollider wheelBR;

    [Header("Wheel Transforms")]
    public Transform wheelFL_transform;
    public Transform wheelFR_transform;
    public Transform wheelBL_transform;
    public Transform wheelBR_transform;

    [Header("Motor settings")]
    public float maxMotorTorque = 80f;
    public float maxBrakeTorque = 150f;
    public float maxSpeed = 100f;
    public float currentSpeed;

    [Header("Wheels settings")]
    public float maxSteerAngle = 45f;
    public float turnSpeed = 5f;
    public bool isBraking = false;

    [Header("Sensors")]
    public float frontSensorLength = 30f;
    public float frontRight_frontLeft_SensorLength = 30f;
    public float right_left_SensorLength = 30f;
    public float frontRight_frontLeft_SensorAngle = 30f;
    public float right_left_SensorAngle = 30f;
    public bool avoiding = false;
    public float avoidMultiplier = 0;

    [Header("Raycast possitions")]
    public GameObject gameObject_F;
    public GameObject gameObject_F1R;
    public GameObject gameObject_F1L;
    public GameObject gameObject_FR;
    public GameObject gameObject_FL;
    public GameObject gameObject_B;
    public GameObject gameObject_BR;
    public GameObject gameObject_BL;
    public GameObject gameObject_R;
    public GameObject gameObject_L;

    [Header("Other")]
    public Vector3 centerOfMass;
    public Texture2D textureNormal;
    public Texture2D textureBraking;
    public Renderer carRenderer;

    public point.Direction direction; // direction of car when spawn

    private List<Transform> nodes;
    private int currectNode = 0;
    private float targetSteerAngle = 0;
    
    private void Start() 
    {
        
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;

        nodes = new List<Transform>();
        for (int i = 0; i < pathTransforms.Count; i++)
        {
            print(pathTransforms[i].name);
        }
        for (int i = 0; i < pathTransforms.Count; i++) 
        {  
            nodes.Add(pathTransforms[i]);
        }
       
    }

    private void FixedUpdate() 
    {
        if(spawnSet)
        {
            if (Vector3.Distance(transform.position, end.transform.position) < 5f)
            {
                Destroy(gameObject);
            }
            Sensors();
            ApplySteer();
            Drive();
            CheckWaypointDistance();
            //Braking();
            LerpToSteerAngle();
        }
        
    }

    private void Sensors() 
    {
        RaycastHit hit;

        int angle_min = 120, angle_max=270;
        float angle_fix = transform.localRotation.eulerAngles.y;
        //variable that fixs dodge depends of rotation of car
        print(angle_fix);
        bool angle_rotation_fix;//r>90 and r<270 true -> else false
        if (angle_fix>= angle_min && angle_fix<= angle_max)
        {
            angle_rotation_fix = true;
        }
        else
        {
            angle_rotation_fix = false;
        }
        avoidMultiplier = 0;
        avoiding = false;

       

        switch (isBraking)
        {
            case true:
                {
                    //front center sensor
                    if (Physics.Raycast(gameObject_F.transform.position, transform.forward, out hit, frontSensorLength) && !hit.collider.CompareTag("Terrain"))
                    {

                        Debug.DrawLine(gameObject_F.transform.position, hit.point);
                        avoiding = true;
                        //dodge depends where raycast hit.
                        if (hit.transform.position.x < hit.point.x)
                        {
                            if(angle_rotation_fix)
                            {
                                avoidMultiplier += 1;
                            }
                            else
                            {
                                avoidMultiplier -= 1;
                            }
                            
                        }
                        else
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier -= 1;
                            }
                            else
                            {
                                avoidMultiplier += 1;
                            }
                        }
                        if (Vector3.Distance(hit.transform.position, transform.position) < 20f + 10f)
                        {
                            isBraking = true;
                        }
                        else
                        {
                            isBraking = false;
                        }

                    }
                    // front right1 sensor
                    else if (Physics.Raycast(gameObject_F1R.transform.position, transform.forward, out hit, frontSensorLength) && !hit.collider.CompareTag("Terrain"))
                    {

                        Debug.DrawLine(gameObject_F1R.transform.position, hit.point);
                        avoiding = true;
                        if (hit.transform.position.x < hit.point.x)
                        {

                            if (angle_rotation_fix)
                            {
                                avoidMultiplier += 1;
                            }
                            else
                            {
                                avoidMultiplier -= 1;
                            }
                        }
                        else
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier -= 1;
                            }
                            else
                            {
                                avoidMultiplier += 1;
                            }
                        }
                        if (Vector3.Distance(hit.transform.position, transform.position) < 20f + 10f)
                        {
                            isBraking = true;
                        }
                        else
                        {
                            isBraking = false;
                        }

                    }
                    // front left1 sensor
                    else if (Physics.Raycast(gameObject_F1L.transform.position, transform.forward, out hit, frontSensorLength) && !hit.collider.CompareTag("Terrain"))
                    {

                        Debug.DrawLine(gameObject_F1L.transform.position, hit.point);
                        avoiding = true;
                        if (hit.transform.position.x < hit.point.x)
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier += 1;
                            }
                            else
                            {
                                avoidMultiplier -= 1;
                            }
                        }
                        else
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier -= 1;
                            }
                            else
                            {
                                avoidMultiplier += 1;
                            }
                        }
                        if (Vector3.Distance(hit.transform.position, transform.position) < 20f + 10f)
                        {
                            isBraking = true;
                        }
                        else
                        {
                            isBraking = false;
                        }
                    }
                    else
                    {
                        isBraking = false;
                    }
                   
                    break;
                }
            case false:
                {
                    //front center sensor
                    if (Physics.Raycast(gameObject_F.transform.position, transform.forward, out hit, frontSensorLength) && !hit.collider.CompareTag("Terrain"))
                    {
                        Debug.DrawLine(gameObject_F.transform.position, hit.point);
                        avoiding = true;
                        //dodge depends where raycast hit.
                        if (hit.transform.position.x < hit.point.x)
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier -= 1;
                            }
                            else
                            {
                                avoidMultiplier += 1;
                            }
                        }
                        else
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier += 1;
                            }
                            else
                            {
                                avoidMultiplier -= 1;
                            }
                        }
                        if (Vector3.Distance(hit.transform.position, transform.position) < 20f)
                        {
                            isBraking = true;
                        }
                        else
                        {
                            isBraking = false;
                        }

                    }
                    // front right1 sensor
                    else if (Physics.Raycast(gameObject_F1R.transform.position, transform.forward, out hit, frontSensorLength) && !hit.collider.CompareTag("Terrain"))
                    {

                        Debug.DrawLine(gameObject_F1R.transform.position, hit.point);
                        avoiding = true;
                        if (hit.transform.position.x < hit.point.x)
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier -= 1;
                            }
                            else
                            {
                                avoidMultiplier += 1;
                            }
                        }
                        else
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier += 1;
                            }
                            else
                            {
                                avoidMultiplier -= 1;
                            }
                        }
                        if (Vector3.Distance(hit.transform.position, transform.position) < 20f)
                        {
                            isBraking = true;
                        }
                        else
                        {
                            isBraking = false;
                        }

                    }
                    // front left1 sensor
                    else if (Physics.Raycast(gameObject_F1L.transform.position, transform.forward, out hit, frontSensorLength) && !hit.collider.CompareTag("Terrain"))
                    {

                        Debug.DrawLine(gameObject_F1L.transform.position, hit.point);
                        avoiding = true;
                        if (hit.transform.position.x < hit.point.x)
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier -= 1;
                            }
                            else
                            {
                                avoidMultiplier += 1;
                            }
                        }
                        else
                        {
                            if (angle_rotation_fix)
                            {
                                avoidMultiplier += 1;
                            }
                            else
                            {
                                avoidMultiplier -= 1;
                            }
                        }
                        if (Vector3.Distance(hit.transform.position, transform.position) < 20f)
                        {
                            isBraking = true;
                        }
                        else
                        {
                            isBraking = false;
                        }
                    }
                    // front right sensor or front left sensor
                    else if (Physics.Raycast(gameObject_FR.transform.position, Quaternion.AngleAxis(frontRight_frontLeft_SensorAngle, transform.up) * transform.forward, out hit, frontRight_frontLeft_SensorLength) || Physics.Raycast(gameObject_FL.transform.position, Quaternion.AngleAxis(-frontRight_frontLeft_SensorAngle, transform.up) * transform.forward, out hit, frontRight_frontLeft_SensorLength))
                    {
                        // front right sensor
                        if (Physics.Raycast(gameObject_FR.transform.position, Quaternion.AngleAxis(frontRight_frontLeft_SensorAngle, transform.up) * transform.forward, out hit, frontRight_frontLeft_SensorLength) && !hit.collider.CompareTag("Terrain"))
                        {

                            Debug.DrawLine(gameObject_FR.transform.position, hit.point);
                            avoiding = true;
                            if (isBraking)
                            {
                                avoidMultiplier += 0.5f;
                            }
                            else
                            {
                                avoidMultiplier -= 0.5f;
                            }
                        }
                        // front left sensor
                        else if (Physics.Raycast(gameObject_FL.transform.position, Quaternion.AngleAxis(-frontRight_frontLeft_SensorAngle, transform.up) * transform.forward, out hit, frontRight_frontLeft_SensorLength) && !hit.collider.CompareTag("Terrain"))
                        {
                            Debug.DrawLine(gameObject_FL.transform.position, hit.point);
                            avoiding = true;
                            if (isBraking)
                            {
                                avoidMultiplier -= 0.5f;
                            }
                            else
                            {
                                avoidMultiplier += 0.5f;
                            }
                        }
                    }
                    else
                    {
                        isBraking = false;
                    }
                    // right sensor
                    if(Physics.Raycast(gameObject_R.transform.position, Quaternion.AngleAxis(right_left_SensorAngle, transform.up) * transform.forward, out hit, right_left_SensorLength) && !hit.collider.CompareTag("Terrain"))
                    {
                        Debug.DrawLine(gameObject_R.transform.position, hit.point);
                        avoiding = true;
                        avoidMultiplier -= 0.25f;
                    }
                    else if(Physics.Raycast(gameObject_L.transform.position, Quaternion.AngleAxis(-right_left_SensorAngle, transform.up) * transform.forward, out hit, right_left_SensorLength) && !hit.collider.CompareTag("Terrain"))
                    {
                        Debug.DrawLine(gameObject_L.transform.position, hit.point);
                        avoiding = true;
                        avoidMultiplier += 0.25f;
                    }
                    break;
                }
                    
        }

       
            
                
        

        if (avoiding) 
        {
            targetSteerAngle = maxSteerAngle * avoidMultiplier;
        }

    }

    private void ApplySteer() 
    {
        if (avoiding) return;
        Vector3 relativeVector = transform.InverseTransformPoint(nodes[currectNode].position);
        float newSteer = (relativeVector.x / relativeVector.magnitude) * maxSteerAngle;
        targetSteerAngle = newSteer;

        front_wheel_rotation();
    }

    private void Drive() 
    {
        currentSpeed = 2 * Mathf.PI * wheelFL.radius * wheelFL.rpm * 60 / 1000;

        if (currentSpeed < maxSpeed && !isBraking) 
        {
            wheelFL.motorTorque = maxMotorTorque;
            wheelFR.motorTorque = maxMotorTorque;
        } 
        else 
        {
            wheelFL.motorTorque = -maxMotorTorque;
            wheelFR.motorTorque = -maxMotorTorque;
        }
    }

    private void CheckWaypointDistance() 
    {
        if (Vector3.Distance(transform.position, nodes[currectNode].position) < 5f) 
        {
            if (currectNode == nodes.Count - 1) 
            {
                currectNode = 0;
            } 
            else 
            {
                currectNode++;
            }
        }
    }

    private void Braking() 
    {
        if (isBraking) 
        {
            //carRenderer.material.mainTexture = textureBraking;
            wheelBL.brakeTorque = maxBrakeTorque;
            wheelBR.brakeTorque = maxBrakeTorque;
        } 
        else 
        {
            //carRenderer.material.mainTexture = textureNormal;
            wheelBL.brakeTorque = 0;
            wheelBR.brakeTorque = 0;
        }
    }
    private void LerpToSteerAngle() 
    {
        wheelFL.steerAngle = Mathf.Lerp(wheelFL.steerAngle, targetSteerAngle, Time.deltaTime * turnSpeed);
        wheelFR.steerAngle = Mathf.Lerp(wheelFR.steerAngle, targetSteerAngle, Time.deltaTime * turnSpeed);
    }
    private void front_wheel_rotation()
    {
        var pos = Vector3.zero;
        var rot = Quaternion.identity;

        wheelFL.GetWorldPose(out pos, out rot);
        wheelFL_transform.position = pos;
        wheelFL_transform.rotation = rot;

        wheelFR.GetWorldPose(out pos, out rot);
        wheelFR_transform.position = pos;
        wheelFR_transform.rotation = rot * Quaternion.Euler(0, 180, 0);

        wheelBL.GetWorldPose(out pos, out rot);
        wheelBL_transform.position = pos;
        wheelBL_transform.rotation = rot;

        wheelBR.GetWorldPose(out pos, out rot);
        wheelBR_transform.position = pos;
        wheelBR_transform.rotation = rot * Quaternion.Euler(0, 180, 0);

    }
    private void OnDrawGizmosSelected()
    {
        //draw start and end point of selected car
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(start.transform.position, 5f);
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(end.transform.position, 5f);


        //draw line of all points
        Gizmos.color = Color.cyan;
        for (int i = 0; i < pathTransforms.Count-1; i++)
        {
                Gizmos.DrawLine(pathTransforms[i].position, pathTransforms[i + 1].position);
            
        }

    }
}
