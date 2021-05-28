using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz : MonoBehaviour
{
   
    void Update()
    {
        
    }
    void refresh_quiz()
    {

    }
}
public class Question
{
    public string question;
    public string ansA;
    public string ansB;
    public string ansC;
    public string ansD;
    public string correctAns;
    public int points;
    public Texture2D image;

    public Question(string question, string ansA, string ansB, string ansC, string ansD, string correctAns, int points, Texture2D image)
    {
        this.question = question;
        this.ansA = ansA;
        this.ansB = ansB;
        this.ansC = ansC;
        this.ansD = ansD;
        this.correctAns = correctAns;
        this.points = points;
        this.image = image;
    }

    public Question()
    {
        this.question = "none";
        this.ansA = "none";
        this.ansB = "none";
        this.ansC = "none";
        this.ansD = "none";
        this.correctAns = "none";
        this.points = 0;
        this.image = null;
    }
}
