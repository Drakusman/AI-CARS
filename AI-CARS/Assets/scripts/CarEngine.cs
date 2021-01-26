using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CarEngine : MonoBehaviour {

    public Transform path;
    public float maxSteerAngle = 45f;
    public float turnSpeed = 5f;
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public WheelCollider wheelRL;
    public WheelCollider wheelRR;
    public float maxMotorTorque = 80f;
    public float maxBrakeTorque = 150f;
    public float currentSpeed;
    public float maxSpeed = 100f;
    public Vector3 centerOfMass;
    public bool isBraking = false;
    public Texture2D textureNormal;
    public Texture2D textureBraking;
    public Renderer carRenderer;

    [Header("Sensors")]
    public float frontSensorLength = 30f;
    public float frontRight_frontLeft_SensorLength = 30f;
    public float right_left_SensorLength = 30f;
    public float frontRight_frontLeft_SensorAngle = 30f;
    public float right_left_SensorAngle = 30f;

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

    private List<Transform> nodes;
    private int currectNode = 0;
    public bool avoiding = false;
    public float avoidMultiplier = 0;

    private float targetSteerAngle = 0;

    private void Start() 
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;

        Transform[] pathTransforms = path.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();

        for (int i = 0; i < pathTransforms.Length; i++) 
        {
            if (pathTransforms[i] != path.transform) 
            {
                nodes.Add(pathTransforms[i]);
            }
        }
    }

    private void FixedUpdate() 
    {
        Sensors();
        ApplySteer();
        Drive();
        CheckWaypointDistance();
        Braking();
        LerpToSteerAngle();
    }

    private void Sensors() 
    {
        RaycastHit hit;
        
        avoidMultiplier = 0;
        avoiding = false;

        //front right sensor
       
        if (Physics.Raycast(gameObject_F1R.transform.position, transform.forward, out hit, frontSensorLength)) 
        {
            if (!hit.collider.CompareTag("Terrain")) 
            {
                Debug.DrawLine(gameObject_F1R.transform.position, hit.point);
                avoiding = true;
                avoidMultiplier -= 1f;
            }
        }
        else if (Physics.Raycast(gameObject_F1L.transform.position, transform.forward, out hit, frontSensorLength))
        {
            if (!hit.collider.CompareTag("Terrain"))
            {
                Debug.DrawLine(gameObject_F1L.transform.position, hit.point);
                avoiding = true;
                avoidMultiplier += 1f;
            }
        }

        //front right angle sensor
        else if (Physics.Raycast(gameObject_FR.transform.position, Quaternion.AngleAxis(frontRight_frontLeft_SensorAngle, transform.up) * transform.forward, out hit, frontRight_frontLeft_SensorLength)) 
        {
            if (!hit.collider.CompareTag("Terrain")) 
            {
                Debug.DrawLine(gameObject_FR.transform.position, hit.point);
                avoiding = true;
                avoidMultiplier -= 0.5f;
            }
        }
        //front left sensor
        else if (Physics.Raycast(gameObject_R.transform.position, Quaternion.AngleAxis(right_left_SensorAngle,transform.up) * transform.forward,out hit,right_left_SensorLength))
        {
            if (!hit.collider.CompareTag("Terrain"))
            {
                Debug.DrawLine(gameObject_R.transform.position, hit.point);
                avoiding = true;
                avoidMultiplier -= 0.25f;
            }
        }

        
        
        

        //front left angle sensor
        else if (Physics.Raycast(gameObject_FL.transform.position, Quaternion.AngleAxis(-frontRight_frontLeft_SensorAngle, transform.up) * transform.forward, out hit, frontRight_frontLeft_SensorLength)) 
        {
            if (!hit.collider.CompareTag("Terrain")) 
            {
                Debug.DrawLine(gameObject_FL.transform.position, hit.point);
                avoiding = true;
                avoidMultiplier += 0.5f;
            }
        }
        else if (Physics.Raycast(gameObject_L.transform.position, Quaternion.AngleAxis(-right_left_SensorAngle, transform.up) * transform.forward, out hit, right_left_SensorLength))
        {
            if (!hit.collider.CompareTag("Terrain"))
            {
                Debug.DrawLine(gameObject_L.transform.position, hit.point);
                avoiding = true;
                avoidMultiplier += 0.25f;
            }
        }


        //front center sensor
        if (avoidMultiplier == 0) 
        {
            if (Physics.Raycast(gameObject_F.transform.position, transform.forward, out hit, frontSensorLength)) 
            {
                if (!hit.collider.CompareTag("Terrain")) 
                {
                    Debug.DrawLine(gameObject_F.transform.position, hit.point);
                    avoiding = true;
                    if (hit.normal.x < 0) 
                    {
                        avoidMultiplier = -1;
                    } 
                    else 
                    {
                        avoidMultiplier = 1;
                    }
                }
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
            wheelFL.motorTorque = 0;
            wheelFR.motorTorque = 0;
        }
    }

    private void CheckWaypointDistance() 
    {
        if (Vector3.Distance(transform.position, nodes[currectNode].position) < 3f) 
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
            wheelRL.brakeTorque = maxBrakeTorque;
            wheelRR.brakeTorque = maxBrakeTorque;
        } 
        else 
        {
            //carRenderer.material.mainTexture = textureNormal;
            wheelRL.brakeTorque = 0;
            wheelRR.brakeTorque = 0;
        }
    }
    private void LerpToSteerAngle() 
    {
        wheelFL.steerAngle = Mathf.Lerp(wheelFL.steerAngle, targetSteerAngle, Time.deltaTime * turnSpeed);
        wheelFR.steerAngle = Mathf.Lerp(wheelFR.steerAngle, targetSteerAngle, Time.deltaTime * turnSpeed);
    }
}
