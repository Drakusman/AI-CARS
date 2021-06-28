using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour 
{
    public car player;

    //constant value that 
    private const float MAX_SPEED_ANGLE = -20;
    private const float ZERO_SPEED_ANGLE = 230;

    private Transform needleTranform;
    private Transform speedLabelTemplateTransform;

    private float speedMax;
    private float speed;

    private void Awake() 
    {
        needleTranform = transform.Find("needle");
        speedLabelTemplateTransform = transform.Find("speedLabelTemplate");
        speedLabelTemplateTransform.gameObject.SetActive(false);

        speed = 0f;
        speedMax = 200f;

        CreateSpeedLabels();
    }
    private void Start()
    {
        if(GameObject.Find("Car_player"))
        {
            GameObject car_player = GameObject.Find("Car_player");
            player = car_player.GetComponent<car>();
        }
        else
        {
            Debug.LogError("Can't find object with Player tag! Make sure that player exists on map!");
        }
           
       
       
    }

    private void Update() 
    {
        needleTranform.eulerAngles = new Vector3(0, 0, GetSpeedRotation(player.speed));
    }

    private void CreateSpeedLabels() 
    {
        int labelAmount = 10;
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        for (int i = 0; i <= labelAmount; i++) 
        {
            //create new label in speed meter 
            Transform speedLabelTransform = Instantiate(speedLabelTemplateTransform, transform);
            //fixed value of angle for each label
            float labelSpeedNormalized = (float)i / labelAmount;
            //calculate value of angle based on const speed label angle and calculated value of fixed angle in Quaterion notation with total angle size which is substraction of zero angle and speed angle max
            float speedLabelAngle = ZERO_SPEED_ANGLE - labelSpeedNormalized * totalAngleSize;
            //set new angle for new speed label
            speedLabelTransform.eulerAngles = new Vector3(0, 0, speedLabelAngle);
            //round the value of speed value (20,40,60) to full int value
            speedLabelTransform.Find("speedText").GetComponent<Text>().text = Mathf.RoundToInt(labelSpeedNormalized * speedMax).ToString();
            //set value of angle of new value text to 0
            speedLabelTransform.Find("speedText").eulerAngles = Vector3.zero;
            //show up new label
            speedLabelTransform.gameObject.SetActive(true);
        }

        needleTranform.SetAsLastSibling();
    }

    private float GetSpeedRotation(float player_speed) 
    {
        speed = Mathf.Clamp(player_speed, 0f, speedMax);
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = speed / speedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }
}
