using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questions_database : MonoBehaviour
{
    public List<Question> all_questions = new List<Question>();

    void Start()
    {
        Question quest = new Question(
            "What does this curved arrow road marking mean?",
            "Heavy vehicles should take the next road on the left to avoid a weight limit",
            "The road ahead bends to the left",
            "Overtaking traffic should move back to the left",
            "The road ahead has a camber to the left",
            "C",
            1,
            Resources.Load<Sprite>("img/1"));
        all_questions.Add(quest);

        quest = new Question(
            "What should you do when you move off from behind a parked car?",
            "Give a signal after moving off",
            "Look around before moving off",
            "Look around after moving off",
            "Use the exterior mirrors only",
            "B",
            1,
            null);
        all_questions.Add(quest);

        quest = new Question(
            "Why is it dangerous to travel too close to the vehicle ahead?",
            "Your engine will overheat",
            "Your mirrors will need adjusting",
            "Your view of the road ahead will be restricted",
            "our satnav will be confused",
            "C",
            1,
            null);
        all_questions.Add(quest);

        quest = new Question(
            "You're approaching a red light at a puffin crossing. Pedestrians are on the crossing. When will the red light change ?",
            "When you start to edge forward onto the crossing",
            "When the pedestrians have cleared the crossing",
            "When the pedestrians push the button on the far side of the crossing",
            "When a driver from the opposite direction reaches the crossing",
            "B",
            1,
            null);
        all_questions.Add(quest);

        quest = new Question(
           "You wish to turn right ahead. Why should you take up the correct position in good time?",
           "To allow other drivers to pull out in front of you",
           "To give a better view into the road that you're joining",
           "To help other road users know what you intend to do",
           "To allow drivers to pass you on the right",
           "C",
           1,
           null);
        all_questions.Add(quest);

        quest = new Question(
          "What should you do when you leave your car unattended for a few minutes?",
          "Leave the engine running",
          "Switch the engine off but leave the key in",
          "Lock it and remove the key",
          "Park near a traffic warden",
          "C",
          1,
          null);
        all_questions.Add(quest);

        quest = new Question(
         "What part of the car does the law require you to keep in good condition?",
         "The gearbox",
         "The transmission",
         "The door locks",
         "The seat belts",
         "D",
         1,
         null);
        all_questions.Add(quest);

        quest = new Question(
         "How should you dispose of a used vehicle battery?",
         "Bury it in your garden",
         "Put it in the dustbin",
         "Take it to a local-authority disposal site",
         "Leave it on waste land",
         "C",
         1,
         null);
        all_questions.Add(quest);

        quest = new Question(
        "What should you do if your anti-lock brakes (ABS) warning light stays on?",
        "Check the brake-fluid level",
        "Check the footbrake free play",
        "Check that the parking brake is released",
        "Have the brakes checked immediately",
        "D",
        1,
        null);
        all_questions.Add(quest);

        quest = new Question(
        "You're carrying an 11-year-old child on the front seat of your car. They're under 1.35 metres (4 feet 5 inches) tall. What seat belt security must be in place ?",
        "They must use an adult seat belt",
        "They must be able to fasten their own seat belt",
        "They must use a suitable child restraint",
        "They must be able to see clearly out of the front window",
        "D",
        1,
        null);
        all_questions.Add(quest);

        quest = new Question(
        "What should you do if the vehicle starts reversing off the driveway?",
        "Move to the opposite side of the road",
        "Drive through as you have priority",
        "Sound your horn and be prepared to stop",
        "Speed up and drive through quickly",
        "C",
        1,
        Resources.Load<Sprite>("img/2"));
        all_questions.Add(quest);


    }

   
}
