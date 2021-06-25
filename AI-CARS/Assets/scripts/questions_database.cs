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


        quest = new Question(
        "What can result when you travel for long distances in neutral (known as coasting)?",
        "Reduction in control",
        "Easier steering",
        "Increased fuel consumption",
        "Improvement in control",
        "A",
        1,
        null);
        all_questions.Add(quest);

        quest = new Question(
        "You're driving on the motorway. Well before you reach your intended exit, where should you position your vehicle?",
        "In the left-hand lane",
        "In any lane",
        "On the hard shoulder",
        "In the middle lane",
        "A",
        1,
        null);
        all_questions.Add(quest);

        quest = new Question("The fluid level in your battery is low. What should you top it up with?", "Engine coolant", "Distilled water", "Engine oil", "Battery acid", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("What's the national speed limit for cars and motorcycles on a dual carriageway?", "60 mph", "70 mph", "50 mph", "30 mph", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("After passing your driving test, you suffer from ill health. This affects your driving. What must you do?", "Avoid using motorways", "Inform the licensing authority", "Always drive accompanied", "Inform your local police", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("Before driving through a tunnel, what should you do?", "Switch on your windscreen wipers", "Switch off your radio", "Remove any sunglasses", "Close your sunroof", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("Your vehicle has a puncture on a motorway. What should you do?", "Pull up on the hard shoulder. Use the emergency phone to get assistance", "Pull up on the hard shoulder. Change the wheel as quickly as possible", "Switch on your hazard warning lights. Stop in your lane", "Drive slowly to the next service area to get assistance", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're driving on an open road in dry weather. What should the distance be between you and the vehicle in front?", "One car length", "Two metres (6 feet 6 inches)", "Two car lengths", "A two-second time gap", "D", 1, Resources.Load<Sprite>("img/3"));
        all_questions.Add(quest);

        quest = new Question("Where would you see these road markings?", "At a level crossing", "At a pedestrian crossing", "On a motorway slip road", "On a single-track road", "C", 1, Resources.Load<Sprite>("img/4"));
        all_questions.Add(quest);

        quest = new Question("What will be the result of having your vehicle properly serviced?", "Slower journey times", "Reduced insurance premiums", "Lower vehicle excise duty (road tax)", "Better fuel economy", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("On which part of a motorway are amber reflective studs found?", "Between the acceleration lane and the carriageway", "Between each pair of lanes", "Between the central reservation and the carriageway", "Between the hard shoulder and the carriageway", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("Why should you allow extra room when overtaking a motorcyclist on a windy day?", "The rider may turn off suddenly to get out of the wind", "The rider may be travelling faster than normal", "The rider may be blown across in front of you", "The rider may stop suddenly", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("A person has been injured. They may be suffering from shock. What are the warning signs to look for?", "Slow pulse", "Warm dry skin", "Pale grey skin", "Flushed complexion", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("When may you stop and wait in a box junction?", "When you're in a queue of traffic going ahead", "When oncoming traffic prevents you from turning right", "When you're in a queue of traffic turning left", "When you're on a roundabout", "B", 1, Resources.Load<Sprite>("img/5"));
        all_questions.Add(quest);

        quest = new Question("You're approaching a crossroads. The traffic lights have failed. What should you do?", "Be prepared to stop for any traffic", "Be prepared to brake sharply to a stop", "Brake sharply to a stop before looking", "Brake and stop only for large vehicles", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're in a line of traffic. The driver behind you is following very closely. What action should you take?", "Slow down, gradually increasing the gap between you and the vehicle in front", "Signal left and wave the following driver past", "Move over to a position just left of the centre line of the road", "Ignore the following driver and continue to travel within the speed limit", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("Before starting a journey, it's wise to plan your route. How can you do this?", "Check your vehicle registration document", "Look in your vehicle handbook", "Contact your local garage", "Look at a map", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does this sign mean?", "Oncoming trams", "Trams only", "Trams crossing ahead", "No trams ahead", "C", 1, Resources.Load<Sprite>("img/6"));
        all_questions.Add(quest);

        quest = new Question("You're on a three-lane motorway. There are red reflective studs on your left and white ones to your right. Which lane are you in?", "In the left-hand lane", "In the middle lane", "In the right-hand lane", "On the hard shoulder", "A", 1, Resources.Load<Sprite>("img/7"));
        all_questions.Add(quest);

        quest = new Question("Your vehicle catches fire while driving through a tunnel. It's still driveable. What should you do?", "Park it away from the carriageway", "Pull up, then walk to an emergency telephone", "Leave it where it is, with the engine running", "Drive it out of the tunnel if you can do so", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("When must you use dipped headlights during the day?", "In poor visibility", "When parking", "All the time", "On narrow streets", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("What must a driver do at a pelican crossing when the amber light is flashing?", "Wait for the red-and-amber light before proceeding", "Give way to any pedestrians on the crossing", "Always wait for the green light before proceeding", "Signal the pedestrian to cross", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're on a motorway. There's a contraflow system ahead. What would you expect to find?", "Wider lanes than normal", "Lower speed limits", "Speed humps", "Temporary traffic lights", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("What should you do when you see two elderly pedestrians about to cross the road ahead?", "Stop and wave them across the road", "Speed up to get past them quickly", "Be careful; they may misjudge your speed", "Expect them to wait for you to pass", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're driving towards this left-hand bend. What dangers should you be aware of?", "A vehicle overtaking you", "No sign to warn you of the bend", "No white lines in the centre of the road", "Pedestrians walking towards you", "D", 1, Resources.Load<Sprite>("img/8"));
        all_questions.Add(quest);

        quest = new Question("What should the driver of the grey car (arrowed) be especially aware of?", "Traffic following behind", "Doors opening on parked cars", "Empty parking spaces", "The uneven road surface", "B", 1, Resources.Load<Sprite>("img/9"));
        all_questions.Add(quest);

        quest = new Question("Your vehicle is insured third-party only. What does this cover?", "All damage and injury", "Damage to your vehicle", "Injury to yourself", "Damage to other vehicles", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're involved in a collision. Afterwards, which document may the police ask you to produce?", "Theory test certificate", "Vehicle registration document", "Driving licence", "Vehicle service record", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("What must you make sure of before you drive someone else's vehicle?", "That the insurance documents are in the vehicle", "That the vehicle is insured for your use", "That your own vehicle has insurance cover", "That the vehicle owner has third-party insurance cover", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does driving a vehicle with anti-lock brakes allow you to do?", "Pay less attention to the road ahead", "Drive at higher speeds", "Brake harder because it's impossible to skid", "Steer and brake harshly at the same time", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("How will a school crossing patrol signal you to stop?", "By giving you an arm signal", "By displaying a red light", "By pointing to children on the opposite pavement", "By displaying a 'stop' sign", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("Overall stopping distance is made up of thinking distance and braking distance. You're on a good, dry road surface, with good brakes and tyres. What's the typical braking distance from 50 mph?", "55 metres (180 feet)", "38 metres (125 feet)", "14 metres (46 feet)", "24 metres (80 feet)", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does this signal mean?", "Cars must stop", "Both trams and cars must stop", "Both trams and cars can continue", "Trams must stop", "D", 1, Resources.Load<Sprite>("img/10"));
        all_questions.Add(quest);

        quest = new Question("Why must you take extra care when turning right at this junction?", "The road markings are faint", "The footpaths are narrow", "The road surface is poor", "The view is restricted", "D", 1, Resources.Load<Sprite>("img/11"));
        all_questions.Add(quest);

        quest = new Question("You're at the front of a queue of traffic waiting to turn right into a side road. Why is it important to check your right mirror just before turning?", "To look for pedestrians about to cross", "To make sure the side road is clear", "To check for overtaking vehicles", "To check for emerging traffic", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("Your vehicle is fitted with a hand-held telephone. What should you do to use the phone?", "Steer the vehicle with one hand", "Find a safe place to stop", "Reduce your speed", "Be particularly careful at junctions", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("You intend to turn left from a main road into a minor road. What should you do as you approach it?", "Keep well to the left of the road", "Keep just left of the middle of the road", "Keep in the middle of the road", "Swing out to the right just before turning", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("There are no speed-limit signs on the road. How is a 30 mph limit indicated?", "By street lighting", "By hazard warning lines", "By pedestrian islands", "By double or single yellow lines", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("What must you have when you apply to renew your vehicle excise licence?", "The handbook", "A valid driving licence", "Valid insurance", "The vehicle's chassis number", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does 'tailgating' mean?", "Using the rear door of a hatchback car", "Following another vehicle too closely", "Reversing into a parking space", "Driving with rear fog lights on", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("When will you feel the effects of engine braking?", "When you change to a lower gear", "When you're in neutral", "When you only use the handbrake", "When you change to a higher gear", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're following a long vehicle. As it approaches a crossroads, it signals left but moves out to the right. What should you do?", "Assume the signal is wrong and that it's turning right", "Overtake it as it starts to slow down", "Get closer in order to pass it quickly", "Stay well back and give it room", "D", 1, Resources.Load<Sprite>("img/12"));
        all_questions.Add(quest);

        quest = new Question("You're signalling to turn right in busy traffic. How would you confirm your intention safely?", "Sound the horn", "Give an arm signal", "Position over the centre line", "Flash your headlights", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("What must you do when you see this sign?", "Stop only if children are waiting to cross", "Stop only if traffic is approaching", "Stop even if the road is clear", "Stop only if a red light is showing", "C", 1, Resources.Load<Sprite>("img/13"));
        all_questions.Add(quest);

        quest = new Question("You're travelling along this narrow country road. How should you pass the cyclist?", "Sound your horn as you pass", "Leave them plenty of room as you pass", "Change down one gear before you pass", "Keep close to them as you pass", "B", 1, Resources.Load<Sprite>("img/14"));
        all_questions.Add(quest);

        quest = new Question("You break down on a motorway. You need to call for help. Why may it be better to use an emergency roadside telephone rather than a mobile phone?", "Using a mobile phone will distract other drivers", "Mobile phones don't work on motorways", "It connects you to a local garage", "It allows easy location by the emergency services", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("You see a car on the hard shoulder of a motorway with a 'help' pennant displayed. What does this mean?", "The driver is likely to be a disabled person", "The driver is a foreign visitor", "The driver is first-aid trained", "The driver is a rescue patrol officer", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're travelling on a road that has speed humps. What should you do when the driver in front is travelling more slowly than you?", "Sound your horn", "Overtake as soon as you can", "Slow down and stay behind", "Flash your headlights", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("When is it acceptable for a passenger to travel in a car without wearing a seat belt?", "When they're sitting in the rear seat", "When they're under 14 years old", "When they're under 1.5 metres (5 feet) in height", "When they're exempt for medical reasons", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does this sign mean?", "Right-hand lane closed ahead", "Right-hand lane T-junction only", "11 tonne weight limit", "Through traffic to use left lane", "A", 1, Resources.Load<Sprite>("img/15"));
        all_questions.Add(quest);

        quest = new Question("For how long is a Statutory Off-Road Notification (SORN) valid?", "Until the vehicle is taxed, sold or scrapped", "Until the vehicle is repaired or modified", "Until the vehicle is insured and MOT'd", "Until the vehicle is used on the road", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're using a contraflow system. What should you do?", "Increase speed to pass through quickly", "Choose an appropriate lane in good time", "Switch lanes at any time to make progress", "Follow other motorists closely to avoid long queues", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("What must you do when overtaking a car at night?", "Switch your lights to full beam before overtaking", "Select a higher gear", "Flash your headlights before overtaking", "Make sure you don't dazzle other road users", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does this sign mean?", "Turn left for parking area", "Turn left for ferry terminal", "No entry for traffic turning left", "No through road on the left", "D", 1, Resources.Load<Sprite>("img/16"));
        all_questions.Add(quest);

        quest = new Question("How will your vehicle be affected when you drive up steep hills?", "The engine will work harder", "Overtaking will be easier", "The steering will feel heavier", "The higher gears will pull better", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("In what way are provisional car licence holders restricted?", "They can't drive unaccompanied", "They can't drive between 11.30 pm and 7.00 am", "They can't carry passengers in the rear seats", "They can't drive at more than 40 mph", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("When must you stop your vehicle?", "If you're involved in an incident that causes damage or injury", "At the end of a one-way street", "At a junction where there are 'give way' lines", "Before merging onto a motorway", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("Which vehicle is most likely to take an unusual course at a roundabout?", "Estate car", "Delivery van", "Milk float", "Long lorry", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("Why must these road markings be kept clear?", "To allow schoolchildren to be dropped off", "To allow a clear view of the crossing area", "To allow teachers to park", "To allow schoolchildren to be picked up", "B", 1, Resources.Load<Sprite>("img/17"));
        all_questions.Add(quest);

        quest = new Question("Why should you switch off your rear fog lights when the fog has cleared?", "To stop draining the battery", "To stop the engine losing power", "To allow your headlights to work", "To prevent dazzling following drivers", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're travelling at 50 mph on a good, dry road. What's your typical overall stopping distance?", "96 metres (315 feet)", "36 metres (118 feet)", "75 metres (245 feet)", "53 metres (175 feet)", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("Why are place names painted on the road surface?", "To prevent you changing lanes", "To restrict the flow of traffic", "To warn you of oncoming traffic", "To enable you to change lanes early", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does this sign mean?", "No motorcycles", "Cars only", "Motorcycles only", "No cars", "A", 1, Resources.Load<Sprite>("img/18"));
        all_questions.Add(quest);

        quest = new Question("Why should you make sure that your indicators are cancelled after turning?", "To avoid flattening the battery", "To avoid dazzling other road users", "To avoid damage to the indicator relay", "To avoid misleading other road users", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're driving in fog. Why should you keep well back from the vehicle in front?", "In case its brake lights dazzle you", "In case it changes direction suddenly", "In case it stops suddenly", "In case its fog lights dazzle you", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("How can driving in an ecosafe manner help protect the environment?", "By reducing exhaust emissions", "By increasing the number of cars on the road", "Through increased fuel bills", "Through the legal enforcement of speed regulations", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("What should the left-hand lane of a motorway be used for?", "Normal driving", "Slow vehicles only", "Overtaking slower traffic in the other lanes", "Breakdowns and emergencies only", "A", 1, Resources.Load<Sprite>("img/19"));
        all_questions.Add(quest);

        quest = new Question("It's very windy. You're behind a motorcyclist who's overtaking a high-sided vehicle. What should you do?", "Keep well back", "Keep close to the motorcyclist", "Stay level with the motorcyclist", "Overtake the motorcyclist immediately", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("You see this line across the road at the entrance to a roundabout. What does it mean?", "Stop at the line", "You have right of way", "Traffic from the left has right of way", "Give way to traffic from the right", "D", 1, Resources.Load<Sprite>("img/20"));
        all_questions.Add(quest);

        quest = new Question("How can you reduce the environmental harm caused by your motor vehicle?", "Drive faster than normal", "Only use it for short journeys", "Keep engine revs low", "Don't service it", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're towing a small trailer on a busy three-lane motorway. What must you do if all the lanes are open?", "Have a stabiliser fitted", "Not overtake", "Not exceed 50 mph", "Use only the left-hand and centre lanes", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("There's a tractor ahead. You want to overtake but you aren't sure whether it's safe. What should you do?", "Sound your horn to make the tractor pull over", "Speed past, flashing your lights at oncoming traffic", "Follow another vehicle as it overtakes the tractor", "Stay behind the tractor if you're in any doubt", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("You've broken down on a two-way road. You have a warning triangle. At least how far from your vehicle should you place the warning triangle?", "25 metres (82 feet)", "45 metres (147 feet)", "100 metres (328 feet)", "5 metres (16 feet)", "B", 1, Resources.Load<Sprite>("img/21"));
        all_questions.Add(quest);

        quest = new Question("What does the term 'blind spot' mean for a driver?", "An area not covered by your headlights", "An area covered by your right-hand mirror", "An area covered by your left-hand mirror", "An area not covered by your mirrors", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("Who's responsible for making sure that a vehicle isn't overloaded?", "The driver of the vehicle", "The licensing authority", "The owner of the items being carried", "The person who loaded the vehicle", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("What do these motorway signs show?", "They warn of a police control ahead", "They're countdown markers to a bridge", "They're countdown markers to the next exit", "They're distance markers to the next telephone", "C", 1, Resources.Load<Sprite>("img/22"));
        all_questions.Add(quest);

        quest = new Question("What colour are the reflective studs between a motorway and its slip road?", "White", "Red", "Amber", "Green", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("How would you identify a section of road used by trams?", "There would be zigzag markings alongside it", "There would be yellow hatch markings around it", "There would be metal studs around it", "There would be a different surface texture", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does this sign mean?", "End of restricted parking area", "End of clearway", "End of cycle route", "End of restricted speed area", "A", 1, Resources.Load<Sprite>("img/23"));
        all_questions.Add(quest);

        quest = new Question("You're approaching a zebra crossing. Pedestrians are waiting to cross. What should you do?", "Give way to the elderly and infirm only", "Use your headlights to indicate they can cross", "Slow down and prepare to stop", "Wave at them to cross the road", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're driving down a long, steep hill. You suddenly notice that your brakes aren't working as well as normal. What's the usual cause of this?", "Oil on the brakes", "Badly adjusted brakes", "Air in the brake fluid", "The brakes overheating", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("When do windscreen pillars cause a serious obstruction to your view?", "When you're driving on a dual carriageway", "When you're approaching a one-way street", "When you're approaching bends and junctions", "When you're driving on a motorway", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("As you approach a pelican crossing, the lights change to green. What should you do if elderly people are halfway across?", "Rev your engine to make them hurry", "Wait patiently because they'll probably take longer to cross", "Flash your lights in case they haven't noticed you", "Wave them to cross as quickly as they can", "B", 1, null);
        all_questions.Add(quest);

        quest = new Question("What's the meaning of this sign?", "No entry for vehicles", "National speed limit applies", "No waiting on the carriageway", "Local speed limit applies", "B", 1, Resources.Load<Sprite>("img/24"));
        all_questions.Add(quest);

        quest = new Question("How should you use the emergency telephone on a motorway?", "Stand on the hard shoulder", "Keep your back to the traffic", "Face the oncoming traffic", "Stay close to the carriageway", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("When may you wait in a box junction?", "When you're stationary in a queue of traffic", "When approaching a zebra crossing", "When oncoming traffic prevents you turning right", "When approaching a pelican crossing", "C", 1, Resources.Load<Sprite>("img/25"));
        all_questions.Add(quest);

        quest = new Question("When traffic lights are out of order, who has priority?", "Traffic turning left", "Traffic going straight on", "Nobody", "Traffic turning right", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does this sign mean?", "No vehicles over 30 tonnes", "End of 20 mph zone", "Minimum speed limit 30 mph", "New speed limit 20 mph", "B", 1, Resources.Load<Sprite>("img/26"));
        all_questions.Add(quest);

        quest = new Question("What's the national speed limit on a single carriageway road for cars and motorcycles?", "60 mph", "50 mph", "70 mph", "30 mph", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("What should you do when you're approaching traffic lights that have been on green for some time?", "Be ready to stop", "Brake hard", "Maintain your speed", "Accelerate hard", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("You take some cough medicine given to you by a friend. What should you do before driving?", "Drive a short distance to see if the medicine is affecting your driving", "Ask your friend if taking the medicine affected their driving", "Check the label to see if the medicine will affect your driving", "Drink some strong coffee one hour before driving", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("Which of these is needed before you can legally use a vehicle on the road?", "Proof of your identity", "Breakdown cover", "A vehicle handbook", "A valid driving licence", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're driving a friend's children home from school. They're both under 14 years old. Who's responsible for making sure they wear a seat belt or approved child restraint where required?", "You, the driver", "An adult passenger", "The children", "Your friend", "A", 1, null);
        all_questions.Add(quest);

        quest = new Question("An adult casualty isn't breathing. To maintain circulation, compressions should be given. What's the correct depth to press for each compression?", "1 to 2 centimetres", "15 to 20 centimetres", "5 to 6 centimetres", "10 to 15 centimetres", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("You're driving down a steep hill. Why could it be dangerous to keep the clutch down or roll in neutral for too long?", "Fuel consumption will be higher", "It will damage the engine", "It will wear tyres out more quickly", "Your vehicle will pick up speed", "D", 1, null);
        all_questions.Add(quest);

        quest = new Question("What does this sign mean?", "Minimum speed 30 mph", "Lay-by 30 miles ahead", "Maximum speed 30 mph", "Service area 30 miles ahead", "A", 1, Resources.Load<Sprite>("img/27"));
        all_questions.Add(quest);

        quest = new Question("Where would you see this road marking?", "At a box junction", "On road humps", "At traffic lights", "Near a level crossing", "B", 1, Resources.Load<Sprite>("img/28"));
        all_questions.Add(quest);

        quest = new Question("What should you do when overtaking a motorcyclist in strong winds?", "Pass immediately", "Pass very slowly", "Pass wide", "Pass closely", "C", 1, null);
        all_questions.Add(quest);

        quest = new Question("What should you do as you approach this bridge?", "Move to the right", "Slow down", "Keep to 30 mph", "Change gear", "B", 1, Resources.Load<Sprite>("img/29"));
        all_questions.Add(quest);
        quest = new Question("What’s the main hazard shown in this picture?", "Vehicles turning right", "The cyclist crossing the road", "Parked cars around the corner", "Vehicles doing U-turns", "B", 1, Resources.Load<Sprite>("img/30"));
        all_questions.Add(quest);
        quest = new Question("You’re travelling in very heavy rain. How is this likely to affect your overall stopping distance?", "It will be no different", "It will be doubled", "It will be ten times greater", "It will be halved", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("By how much can stopping distances increase in icy conditions?", "Two times", "Three times", "Ten times", "Five times", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You intend to turn right into a side road. Why should you check for motorcyclists just before turning?", "They may be overtaking on your right", "They may be overtaking on your left", "They may be following you closely", "They may be emerging from the side road", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("How can you identify traffic signs that give orders?", "Green rectangles", "Red triangles", "Blue rectangles", "Red circles", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("In windy conditions, which activity requires extra care?", "Using the brakes", "Moving off on a hill", "Turning into a narrow road", "Passing pedal cyclists", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("When may you overtake another vehicle on the left?", "When a slower vehicle is travelling in the right-hand lane of a dual carriageway", "When the vehicle in front is signalling to turn left", "When approaching a motorway slip road where you’ll be turning off", "When you’re in a one-way street", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What’s badly affected if the tyres are under-inflated?", "Indicating", "Braking", "Parking", "Changing gear", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "Cars and motorcycles only", "Clearway (no stopping)", "No motor vehicles", "No overtaking", "C", 1, Resources.Load<Sprite>("img/31"));
        all_questions.Add(quest);
        quest = new Question("What should you do when you’re joining a motorway?", "Use the hard shoulder", "Stop at the end of the acceleration lane", "Slow to a stop before joining the motorway", "Give way to traffic already on the motorway", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Why is a toucan crossing different from other crossings?", "Cyclists can use it", "Moped riders can use it", "It's controlled by a traffic warden", "It's controlled by two flashing lights", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("When mustn’t you sound your vehicle’s horn?", "At any time in a built-up area", "Between 10.00 pm and 6.00 am in a built-up area", "Between 11.30 pm and 6.00 am on any road", "Between 11.30 pm and 7.00 am in a built-up area", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("When approaching a right-hand bend, you should keep well to the left. Why is this?", "To improve your view of the road", "To overcome the effect of the road’s slope", "To let faster traffic from behind overtake", "To be positioned safely if you skid", "A", 1, Resources.Load<Sprite>("img/32"));
        all_questions.Add(quest);
        quest = new Question("Which of these isn’t allowed to travel in the right-hand lane of a three-lane motorway?", "A motorcycle and sidecar", "A vehicle towing a trailer", "A motorcycle", "A small delivery van", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What’s the national speed limit for cars and motorcycles on a dual carriageway?", "70 mph", "60 mph", "50 mph", "30 mph", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "Maximum speed limit with traffic calming", "Minimum speed limit with traffic calming", "‘20 cars only’ parking zone", "Only 20 cars allowed at any one time", "A", 1, Resources.Load<Sprite>("img/33"));
        all_questions.Add(quest);
        quest = new Question("What is a cover note?", "A document issued before you receive your registration document", "A document issued before you receive your insurance certificate", "A document issued before you receive your driving licence", "A document issued before you receive your MOT certificate", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("For how long is an MOT certificate normally valid?", "Three years after the date it was issued", "10,000 miles", "One year after the date it was issued", "30,000 miles", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should the driver of the grey car (arrowed) be especially aware of?", "Empty parking spaces", "Doors opening on parked cars", "Traffic following behind", "The uneven road surface", "B", 1, Resources.Load<Sprite>("img/34"));
        all_questions.Add(quest);
        quest = new Question("When should you use hazard warning lights?", "When you slow down quickly on a motorway because of a hazard ahead", "When you leave your car at the roadside to visit a shop", "When you wish to stop on double yellow lines", "When you need to park on the pavement", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("There are no speed-limit signs on the road. How is a 30 mph limit indicated?", "By pedestrian islands", "By hazard warning lines", "By double or single yellow lines", "By street lighting", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You’re turning left at a junction where pedestrians have started to cross. What should you do?", "Go around them, leaving plenty of room", "Stop and wave at them to cross", "Sound your horn and proceed", "Give way to them", "D", 1, Resources.Load<Sprite>("img/35"));
        all_questions.Add(quest);
        quest = new Question("What’s the meaning of this sign?", "No waiting on the carriageway", "Local speed limit applies", "No entry for vehicles", "National speed limit applies", "D", 1, Resources.Load<Sprite>("img/36"));
        all_questions.Add(quest);
        quest = new Question("You see a car on the hard shoulder of a motorway with a ‘help’ pennant displayed. What does this mean?", "The driver is first-aid trained", "The driver is likely to be a disabled person", "The driver is a foreign visitor", "The driver is a rescue patrol officer", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which road user has caused a hazard?", "The parked car (arrowed A)", "The car turning (arrowed D)", "The pedestrian waiting to cross (arrowed B)", "The moving car (arrowed C)", "A", 1, Resources.Load<Sprite>("img/37"));
        all_questions.Add(quest);
        quest = new Question("What’s the national speed limit on motorways for cars and motorcycles?", "30 mph", "50 mph", "60 mph", "70 mph", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "Route for trams only", "Route for buses only", "Parking for buses only", "Parking for trams only", "A", 1, Resources.Load<Sprite>("img/38"));
        all_questions.Add(quest);
        quest = new Question("You break down on a motorway. You need to call for help. Why may it be better to use an emergency roadside telephone rather than a mobile phone?", "It connects you to a local garage", "Using a mobile phone will distract other drivers", "It allows easy location by the emergency services", "Mobile phones don't work on motorways", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Why have ‘red routes’ been introduced in major cities?", "To help the traffic flow", "To raise the speed limits", "To provide better parking", "To allow lorries to load more freely", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("After refuelling your vehicle, what should you do to avoid spillage?", "Check that your tank is only three-quarters full", "Check that you've used a locking filler cap", "Check that your fuel gauge is working", "Check that your filler cap is securely fastened", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do when you’re overtaking at night?", "Wait until a bend so that you can see oncoming headlights", "Beware of bends in the road ahead", "Sound your horn twice before moving out", "Put your headlights on full beam", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("When are you allowed to use hazard warning lights?", "When travelling slowly because you're lost", "When parked on double yellow lines to visit a shop", "When travelling during darkness without headlights", "When stopped and temporarily obstructing traffic", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You’re waiting to emerge left from a minor road. A large vehicle is approaching from the right. You have time to turn, but you should wait. Why?", "The large vehicle can easily hide an overtaking vehicle", "The large vehicle can turn suddenly", "The large vehicle can easily hide vehicles from the left", "The large vehicle is difficult to steer in a straight line", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You see street lights but no speed-limit signs. What will the speed limit usually be?", "30 mph", "60 mph", "40 mph", "50 mph", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You’re going through a congested tunnel and have to stop. What should you do?", "Ignore any message signs, as they're never up to date", "Pull up very close to the vehicle in front to save space", "Make a U-turn and find another route", "Keep a safe distance from the vehicle in front", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("How will a school crossing patrol signal you to stop?", "By displaying a 'stop' sign", "By displaying a red light", "By pointing to children on the opposite pavement", "By giving you an arm signal", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "End of 20 mph zone", "New speed limit 20 mph", "Minimum speed limit 30 mph", "No vehicles over 30 tonnes", "A", 1, Resources.Load<Sprite>("img/39"));
        all_questions.Add(quest);
        quest = new Question("You’re towing a small trailer on a busy three-lane motorway. What must you do if all the lanes are open?", "Use only the left-hand and centre lanes", "Have a stabiliser fitted", "Not overtake", "Not exceed 50 mph", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You’re turning left into a side road. What hazard should you be especially aware of?", "Traffic congestion", "Pedestrians", "One-way street", "Parked vehicles", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "No right turn", "Bend to the right", "Road on the right closed", "No traffic from the right", "A", 1, Resources.Load<Sprite>("img/40"));
        all_questions.Add(quest);
        quest = new Question("What should the driver of the car approaching the crossing do?", "Slow down and get ready to stop", "Continue at the same speed", "Drive through quickly", "Sound the horn", "A", 1, Resources.Load<Sprite>("img/41"));
        all_questions.Add(quest);
        quest = new Question("Which type of vehicle does this sign apply to?", "High vehicles", "Long vehicles", "Wide vehicles", "Heavy vehicles", "A", 1, Resources.Load<Sprite>("img/42"));
        all_questions.Add(quest);
        quest = new Question("What can a loose filler cap on your diesel fuel tank cause?", "It can increase the level of exhaust emissions", "It can improve your vehicle’s fuel consumption", "It can make the roads slippery for other road users", "It can make the engine difficult to start", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "No through road", "No parking", "No road markings", "No entry", "D", 1, Resources.Load<Sprite>("img/43"));
        all_questions.Add(quest);
        quest = new Question("What’s the purpose of road humps, chicanes and narrowings?", "To reduce traffic speed", "To allow pedestrians to cross", "To separate lanes of traffic", "To increase traffic speed", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What makes the vehicle in the picture ‘environmentally friendly’?", "It's powered by gravity", "It's powered by diesel", "It's powered by electricity", "It's powered by unleaded petrol", "C", 1, Resources.Load<Sprite>("img/44"));
        all_questions.Add(quest);
        quest = new Question("Where would you expect to see these markers?", "On a motorway sign", "On a railway bridge", "On a large goods vehicle", "On a diversion sign", "C", 1, Resources.Load<Sprite>("img/45"));
        all_questions.Add(quest);
        
        quest = new Question("Which vehicles should use the left-hand lane on a three-lane motorway?", "Any vehicle", "Large vehicles only", "Slow vehicles only", "Emergency vehicles only", "A", 1, Resources.Load<Sprite>("img/46"));
        all_questions.Add(quest);
        quest = new Question("What should you do before making a U-turn?", "Give an arm signal as well as using your indicators", "Select a higher gear than normal", "Check signs to see that U-turns are permitted", "Look over your shoulder for a final check", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("How often should you check fluid levels?", "At least yearly", "At least monthly", "At least weekly", "At least daily", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You want to park you car facing downhill, what should you do?", "Turn your steering wheel towards the kerb", "Select a forward gear", "Turn your steering wheel away from the kerb", "Keep your engine running", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("In what case can the vehicle used to commit an offence be confiscated?", "Where you accumulate 10 penalty points", "Where an offence is punishable by discretionary disqualification", "Where an offence is punishable in a £2,500 fine", "Where an offence is punishable by imprisonment", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("In which of these conditions will your overall stopping distance increase?", "In strong winds", "In fog", "In the rain", "At night", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are forced to stop in a tunnel due to stationary traffic. How much space should you leave between you and the vehicle in front?", "At least 5 metres", "2 metres", "3 metres", "4 metres", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do if your engine overheats?", "Immediately remove the coolant filler cap and add water or other coolant", "Drive to the nearest garage", "Wait until it has cooled naturally", "Call the fire brigade", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a motorway when something falls from your vehicle on to the road. What should you do?", "Stop on the road and turn on your hazard lights", "Stop at the next emergency telephone and call for help", "Immediately call for help", "Stop on the hard shoulder and pick it up", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are crossing a dual carriageway with a central reservation which is too shallow for your vehicle. What should you do?", "Wait until you can cross both carriageways at once", "Wait in the central reservation, treat each half of the carriageway as a separate road", "Look right to see if you have time to drive into the central reservation", "Drive into the central reservation", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a road when you get dazzled by bright sunlight. What should you do?", "Accelerate to get through the road quicker", "Slam on the brakes to stop", "Warn other road users by turning on hazard lights", "Slow down", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You decide to drive on a foggy day. What should you do before you set out?", "Make sure that you have a warning triangle in the vehicle", "Top up the radiator with anti-freeze", "Make sure that the windows are clean", "Check the battery", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("It is snowing heavily and the weather conditions are getting worse. What should you do?", "Don't drive unless it's essential", "Only drive when your journey is short", "Don't drive unless you have a mobile phone", "Drive with your hazard warning lights on", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You were pulled over by the police. What is the first thing you should do?", "Get your driving licence ready", "Prepare to drive off", "Switch off the engine", "Prepare your insurance document", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Once you get your provisional moped licence and complete your CBT training you can ride unaccompanied, with L plates, for up to how many years?", "3", "2", "1", "4", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("In what case do you apply for SORN?", "If you want an exemption from an MOT requirement", "If you want to apply for Third-Party insurance", "If you want to keep a motor vehicle untaxed and off the public road", "If you want to buy or sell a motor vehicle", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the speed limit for cars towing a trailer, on a single carriageway?", "60 mph", "70 mph", "50 mph", "40 mph", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the first thing to do when providing emergency care?", "Gently shake their shoulders", "Check you are not in danger", "Try to get a response by asking questions", "Make them warm and as comfortable as you can", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Why should you be particularly careful of electric vehicles?", "They are silent", "They are bigger", "They are harder to see", "They are faster", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You have taken some over-the-counter medicine. Which of the following is appropriate?", "It is never safe to drive after taking over-the-counter medicine", "Check if you are ok to drive by reading your plate number from 10 m away", "It is always safe to drive after taking over-the-counter medicine", "Check the label to see if it impairs driving", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("How many penalty points can you get for a traffic light offence?", "3", "6", "12", "9", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can you do to save fuel?", "Accelerate sharply in each gear", "Use lower gears as often as possible", "Miss out some gears", "Use each gear in turn", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You have just filled up your tank, you double-check for leaks and make sure that", "The fuel cap is removed", "The fuel cap is fastened loosely", "There is no visual damage to the fuel cap", "You have overfilled your tank", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you have on your bicycle?", "A bell", "A basket", "A seat belt", "A water bottle", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Your vehicle should be properly maintained at all times. Which of these must you not do?", "Keeping lights and number plates clean and clear", "Keeping windscreens and windows clean", "Exceeding prescribed levels of exhaust emissions", "Keepings lights properly adjusted", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving behind a slow moving vehicle which you want to overtake. When must you not overtake?", "If you have to cross solid double white lines", "If the road is wet", "At night", "If the vehicle in front is in the crawler lane", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What’s a common effect of drinking alcohol?", "Faster reactions", "Increased confidence", "Colour blindness", "Increased concentration", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("It’s important to keep in mind the stopping distances in wet weather. Compared to dry roads, the stopping distance will", "Stay the same", "Double", "Triple", "Half", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does having your registration number etched on all your car windows do?", "Attracts potential car buyers", "Decreases the value of your car", "Increases the cost of your insurance", "Acts as a deterrent to professional thieves", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the maximum penalty for failing to identify the driver of the vehicle?", "3-6 penalty points", "6-8 penalty points", "£500 fine", "£1,000 fine / Discretionary disqualification", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are providing emergency care to a casualty. They are unconscious but breathing. What do you do?", "Wait until medics arrive", "Place them in the recovery position", "Administer chest compressions", "Gently shake their shoulders", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a road and decide to stop on the roadside. You should not", "Apply the handbrake before leaving the vehicle", "Switch off the engine", "Park facing against the traffic flow", "Stop as close as you can to the side", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("When should you check tyre pressure?", "Before the journey, when tyres are cold", "At the end of the journey, when the tyres have cooled down", "In the middle of the journey, when the tyres are warm", "At the end of the journey, when the tyres are warm", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is a level crossing?", "A road which crosses a railway line", "Road accessing the motorway", "Crossing for cyclists", "Crossing for horses", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these organisations does not provide first aid training?", "St John Ambulance and Brigade", "St Andrew's First Aid", "British Red Cross Society", "Your local GP", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do if your vehicle breaks down in a tunnel?", "Switch on hazard warning lights, then go and call for help", "Stay in your vehicle and wait for the police", "Stand in the lane behind your vehicle to warn others", "Stand in front of your vehicle to warn oncoming drivers", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are approaching a long downhill slope, which gear should you select?", "Higher gear", "No gear (Coasting)", "Lower gear", "Same gear", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are involved in an accident with a vehicle containing dangerous goods. What is the first thing you should do?", "Switch off the engine", "Smoke a cigarette", "Rescue other casualties", "Call the emergency services", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a well-lit 30 mph road at night. What must you ensure?", "Front and rear fog lights are on", "Headlights are on full beam", "All sidelights and rear registration plate lights are lit", "Hazard warning lights are on", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a road and see a parked ice cream van further ahead. The road ahead is clear. What should you do?", "Proceed as normal", "Drive carefully and slowly", "Use your horn to let others know you are there", "Select a higher gear", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are a holder of a non-European Community licence and are now resident in the UK. What is the maximum period of time you may drive on that licence?", "1 year", "Indefinitely", "5 years", "2 years", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are approaching a zebra crossing. What should you do?", "Flash your headlights", "Stop before the zebra crossing", "Drive as normal", "Prepare to slow down or stop", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these is a non-motoring offence which can earn you penalty points?", "Selling your car", "Speeding", "Failure to rectify vehicle defects", "Careless driving", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a motorway when you see hitchhikers on the hard shoulder asking for a lift. What should you do?", "Take the next exit", "Carry on driving", "Stop and pick them up", "Call the emergency services immediately", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("When driving on a road with a tramway you notice a tram approaching a stop without platform. You must", "Enter the road, lane or other route reserved for trams", "Drive between the tram and the left-hand kerb when the tram stops to pick up passengers", "Follow the route shown by the road signs and markings", "Overtake the tram", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You will be disqualified from driving if you get", "10 or more penalty points within a 2-year period", "12 or more penalty points within a 3-year period", "6 or more penalty points within a 1-year period", "8 or more penalty points within a 3-year period", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which vehicles are exempted from MOT requirement?", "Motor vehicles that are insured", "Motor vehicles that are over 3 years old", "Motorcycles", "Motor vehicles manufactured before 1960", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving a vehicle fitted with anti-lock brakes. How would you brake in case of an emergency?", "Firmly", "Gently tapping your foot on the brake", "Using the handbrake", "Slowly", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("How old do you have to be to drive Category A1 vehicle?", "21", "17", "16", "19", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can you use the right lane of the three-lane dual carriageway for?", "General driving", "Stopping when tired", "Overtaking", "Towing a trailer", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do when joining the motorway using a slip road?", "Give priority to traffic on the motorway", "Drive faster than the traffic already on the motorway", "Use the hard shoulder as an extra lane", "Cross solid white lines to get into the correct lane", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You see this amber traffic light ahead. Which light, or lights, will come on next?", "Red alone", "Red and amber together", "Green and amber together", "Green alone", "A", 1, Resources.Load<Sprite>("img/47"));
        all_questions.Add(quest);

        quest = new Question("Which of these offences could result in 14 years’ imprisonment?", "Causing death by dangerous driving", "Failing to stop after an accident", "Dangerous driving", "Driving while disqualified", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("On unrestricted dual carriageways, vehicles with what maximum speed must have a flashing amber beacon?", "30 mph", "25 mph", "35 mph", "40 mph", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Who is responsible for ensuring that all adult passengers (over 14 years old) wear a seat belt where available?", "DVLA", "Nobody", "Passengers", "Driver", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What’s the maximum speed of the powered vehicles used by disabled people?", "12 mph", "8 mph", "10 mph", "6 mph", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a dual carriageway and you see an accident on the other side of the dual carriageway. You can see the ambulance at the crash scene. What should you do?", "Stop and call the emergency services", "Slow down", "Carry on driving", "Look more closely to see if anyone is injured", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Your vehicle continues to bounce after pushing down on the front or rear. What is the problem?", "There are no anti-freeze agents in your radiator", "The tyres are not inflated correctly", "The shock absorbers are worn", "There is a brake fault", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the minimum cover insurance required by law?", "Comprehensive", "Third-Party, Fire and Theft", "Third-Party", "No insurance is required", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("As a non-European Community licence holder, what do you need to do to obtain continuous driving entitlement?", "Immediately apply for a full British licence", "A British provisional licence should be obtained and a driving test(s) passed before the 12-month period elapses", "Contact DVLA and inform them of your address change", "Nothing, you are allowed to drive with a non-European Community licence", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You stopped before the box junction as the exit is not clear. When is it acceptable to enter the box junction?", "When turning right", "When going straight", "When someone flashes their headlights", "If there is enough space", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("When can you drive on or over a pavement?", "To drop off children at school", "To gain access to property", "In busy traffic", "To park safely", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("How do you deal with a bleed if the limb is bleeding but not broken?", "Lower the limb below the level of the heart", "Do not touch it until medics arrive", "Try to get them to stand up", "Raise the limb above the level of the heart", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("A warning sign comes up on the vehicle instrument panel. What do you do?", "Stop and investigate the problem", "Ignore it", "Keep driving until you see a garage", "Ask a friend", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You stopped behind the solid white line at a level crossing. The red light continues to flash after the train had passed. What should you do?", "Leave the car to see if everything is fine", "Continue to wait", "Call the emergency services", "Edge forward and proceed if it's safe to do so", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a motorway and accidentally miss your exit. What should you do?", "Carry on driving and take the next exit", "Check your phone for an alternative route", "Reverse back and take your exit", "Stop on the hard shoulder and plan you journey", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("If you are convicted of a serious driving offence the insurance is", "Not affected", "Likely to rise", "Cancelled", "Likely to drop", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You have a provisional licence and are 21 years old. Who can supervise you when you are driving?", "Someone who has a full licence", "Someone who is 21 years old", "Someone who is 21 years old and has a full licence", "Someone who is at least 21 years old and has had a full licence for 3 years", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is Pass Plus?", "A certificate you get when passing both your theory and driving tests", "A plate that you put on your car after you pass your test", "A grade you get if you get no minor faults in your driving test", "Further driving training", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the maximum penalty for a traffic light offence?", "£2,500 fine / Discretionary disqualification", "Unlimited fine", "£1,000 fine / Discretionary disqualification", "£500 fine", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the primary reason for flashing your headlights?", "To signal that you are yielding the right of way to another driver", "To warn other drivers of dangers on the road", "To warn others of your presence", "To dazzle other road users", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the typical stopping distance for a car travelling at 50 mph?", "36 metres (118 feet)", "23 metres (75 feet)", "73 metres (240 feet)", "53 metres (175 feet)", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("It’s important to keep in mind the stopping distances in icy weather. Compared to dry roads, the stopping distance can be", "Remain the same", "Twice smaller", "Twice bigger", "Ten times bigger", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the maximum penalty for seat belt offences?", "£200 fine", "£1,000 fine", "£100 fine", "£500 fine", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You earn 12 points within a 3-year period. What is the minimum number of months you can be disqualified for?", "6", "12", "9", "3", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Who orders points to be endorsed on the licence?", "DVLA", "Police", "Parliament", "Court", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are in a stationary queue of traffic, the traffic in front of you has stopped completely. What should you do after applying the parking brake?", "Switch off the engine", "Check your phone", "Take your foot off the footbrake", "Sound your horn", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a road when another vehicle tries to overtake you. What should you do?", "Speed up to match their speed", "Drive competitively", "Press on the brakes", "Prepare to slow down if necessary", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are involved in a collision which injured a person. You must report this to the police within", "3 days", "1 week", "1 day", "2 days", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Where are you allowed to park or wait?", "On yellow lines outside the hours of operation", "The hard shoulder of a motorway", "Pedestrian crossing", "Clearway", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving in the countryside and have to drive through deep water. What should you do?", "Test your brakes afterwards", "Drive slower than normal", "Drive in a lower gear than normal", "Drive in a higher gear than normal", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You have witnessed a crash and want to help those who were involved in the crash. What should you do?", "Give them something to eat or drink", "Move casualties still in vehicles", "Give reassurance confidently and try not to leave them alone", "Remove a motorcyclist’s helmet", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You do not feel confident cycling on the road. What should you do?", "Talk to your doctor", "Talk to your family", "Undertake cycle training", "Ask someone to come with you", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Who sets the maximum penalties for road traffic offences?", "DVLA", "Police", "Parliament", "Supreme Court", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can over- or under-inflated tyres affect?", "Engine oil", "Fluid levels", "Battery", "Steering", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these is classified as Category AM vehicle?", "Motorcycles up to 125 cc, with a power output not exceeding 11 kW", "Motorcycles with a power output not exceeding 35 kW", "Two-wheeled vehicle with a maximum design speed of 45 km/h (28 mph)", "Tricycles with a power output over 15 kW", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You stopped at a pelican crossing to let a pedestrian cross the road. He crossed it very quickly and the road is clear. When can you first proceed?", "When the amber light is flashing", "As soon as there is enough space for you to move safely", "As soon as the pedestrian finished crossing", "When the light turns green", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What do you do if a tyre bursts while you are driving?", "Slam on the breaks", "Call the fire brigade and continue to drive", "Grip the steering wheel firmly and allow the vehicle to roll to a stop at the side of the road", "Ignore it and keep driving until you see a garage", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("As a provisional licence holder, you can not use", "Dual carriageways", "Motorways", "All roads with a speed limit of 70 mph", "Narrow country lanes", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do if your vehicle catches fire?", "Attempt to extinguish a fire in the engine compartment whilst calling the fire brigade", "Leave the vehicle quickly and call the fire brigade", "Open the bonnet and investigate", "Attempt to extinguish a fire", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is a major fire risk on the forecourt of petrol stations?", "Ignition keys", "Children", "Pets", "Usage of mobile phones", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the time of high risk for new drivers?", "5 pm - 12 am", "9 am - 5 pm", "6 am - 9 am", "12 am - 6 am", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are providing emergency care to a casualty. They have no signs of life and there is no pulse. What should you do?", "Gently shake their shoulders", "Try to get a response by asking questions", "Put them in the recovery position", "Administer chest compressions", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("How old do you have to be to drive Category A2 vehicle?", "16", "17", "21", "19", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you always keep in mind when towing?", "Overtaking cars", "Additional noise pollution", "Additional fuel consumption", "Extra length and weight", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("The central reservation of a dual carriageway or motorway is marked with studs of which colour?", "White", "Red", "Amber", "Green", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these offences could result in 2 years’ imprisonment?", "Dangerous driving", "Driving while unfit through drink or drugs", "Failing to stop after an accident", "Driving while disqualified", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the maximum penalty for cycling on the pavement?", "£200 fine", "£100 fine", "£500 fine", "£1,000 fine", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What must you do when cycling at night?", "Use lit front and rear lights and have a red rear reflector", "Use GPS to show you the safest route", "Only use cycle lanes", "Not wear any reflective clothing", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these is classified as Category A vehicle?", "Motorcycles up to 125 cc, with a power output not exceeding 11 kW", "Motorcycles with a power output not exceeding 35 kW", "Two-wheeled vehicle with a maximum design speed of 45 km/h (28 mph)", "Tricycles with a power output over 15 kW", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a road when your vehicle breaks down. What should you not do?", "Stand between your vehicle and oncoming traffic", "Put a warning triangle on the road at least 45 metres (147 feet) behind your broken-down vehicle", "Wear light-coloured or fluorescent clothing in daylight and reflective clothing at night", "Get your vehicle off the road if possible", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What do you have to do to gain a full moped licence?", "Pass the theory test for motorcycles, followed by the practical test", "Pass the hazard perception test", "Drive with a provisional licence for 3 years", "Complete CBT training", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("When should you check tyre pressure?", "Before the journey, when tyres are cold", "In the middle of the journey, when the tyres are warm", "At the end of the journey, when the tyres are warm", "At the end of the journey, when the tyres have cooled down", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are crossing a dual carriageway with a central reservation which is too shallow for your vehicle. What should you do?", "Drive into the central reservation", "Look right to see if you have time to drive into the central reservation", "Wait until you can cross both carriageways at once", "Wait in the central reservation, treat each half of the carriageway as a separate road", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do when joining the motorway using a slip road?", "Drive faster than the traffic already on the motorway", "Give priority to traffic on the motorway", "Cross solid white lines to get into the correct lane", "Use the hard shoulder as an extra lane", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("In what case do you apply for SORN?", "If you want to buy or sell a motor vehicle", "If you want to keep a motor vehicle untaxed and off the public road", "If you want to apply for Third-Party insurance", "If you want an exemption from an MOT requirement", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a well-lit 30 mph road at night. What must you ensure?", "All sidelights and rear registration plate lights are lit", "Headlights are on full beam", "Hazard warning lights are on", "Front and rear fog lights are on", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are approaching a zebra crossing. What should you do?", "Stop before the zebra crossing", "Drive as normal", "Prepare to slow down or stop", "Flash your headlights", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You were pulled over by the police. What is the first thing you should do?", "Prepare to drive off", "Switch off the engine", "Get your driving licence ready", "Prepare your insurance document", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("How old do you have to be to drive Category A1 vehicle?", "19", "21", "17", "16", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You have taken some over-the-counter medicine. Which of the following is appropriate?", "It is never safe to drive after taking over-the-counter medicine", "Check the label to see if it impairs driving", "Check if you are ok to drive by reading your plate number from 10 m away", "It is always safe to drive after taking over-the-counter medicine", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do if your engine overheats?", "Immediately remove the coolant filler cap and add water or other coolant", "Drive to the nearest garage", "Wait until it has cooled naturally", "Call the fire brigade", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Your vehicle should be properly maintained at all times. Which of these must you not do?", "Exceeding prescribed levels of exhaust emissions", "Keeping windscreens and windows clean", "Keepings lights properly adjusted", "Keeping lights and number plates clean and clear", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you have on your bicycle?", "A basket", "A bell", "A seat belt", "A water bottle", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a road when you get dazzled by bright sunlight. What should you do?", "Slow down", "Warn other road users by turning on hazard lights", "Accelerate to get through the road quicker", "Slam on the brakes to stop", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What’s a common effect of drinking alcohol?", "Faster reactions", "Increased confidence", "Increased concentration", "Colour blindness", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You see this amber traffic light ahead. Which light, or lights, will come on next?", "Red and amber together", "Green alone", "Red alone", "Green and amber together", "C", 1, Resources.Load<Sprite>("img/48"));
        all_questions.Add(quest);
        quest = new Question("What is the speed limit for cars towing a trailer, on a single carriageway?", "70 mph", "60 mph", "50 mph", "40 mph", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("In what case can the vehicle used to commit an offence be confiscated?", "Where an offence is punishable in a £2,500 fine", "Where an offence is punishable by discretionary disqualification", "Where an offence is punishable by imprisonment", "Where you accumulate 10 penalty points", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You want to park you car facing downhill, what should you do?", "Keep your engine running", "Turn your steering wheel towards the kerb", "Select a forward gear", "Turn your steering wheel away from the kerb", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do if your vehicle breaks down in a tunnel?", "Stand in front of your vehicle to warn oncoming drivers", "Stand in the lane behind your vehicle to warn others", "Stay in your vehicle and wait for the police", "Switch on hazard warning lights, then go and call for help", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("When driving on a road with a tramway you notice a tram approaching a stop without platform. You must", "Enter the road, lane or other route reserved for trams", "Drive between the tram and the left-hand kerb when the tram stops to pick up passengers", "Overtake the tram", "Follow the route shown by the road signs and markings", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving a vehicle fitted with anti-lock brakes. How would you brake in case of an emergency?", "Using the handbrake", "Gently tapping your foot on the brake", "Slowly", "Firmly", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which vehicles are exempted from MOT requirement?", "Motor vehicles manufactured before 1960", "Motor vehicles that are over 3 years old", "Motor vehicles that are insured", "Motorcycles", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Once you get your provisional moped licence and complete your CBT training you can ride unaccompanied, with L plates, for up to how many years?", "4", "3", "2", "1", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these organisations does not provide first aid training?", "St Andrew's First Aid", "Your local GP", "St John Ambulance and Brigade", "British Red Cross Society", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving behind a slow moving vehicle which you want to overtake. When must you not overtake?", "If the road is wet", "At night", "If the vehicle in front is in the crawler lane", "If you have to cross solid double white lines", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("How often should you check fluid levels?", "At least daily", "At least weekly", "At least monthly", "At least yearly", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are approaching a long downhill slope, which gear should you select?", "Lower gear", "Higher gear", "Same gear", "No gear (Coasting)", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a motorway when something falls from your vehicle on to the road. What should you do?", "Stop on the hard shoulder and pick it up", "Stop at the next emergency telephone and call for help", "Stop on the road and turn on your hazard lights", "Immediately call for help", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Why should you be particularly careful of electric vehicles?", "They are faster", "They are harder to see", "They are silent", "They are bigger", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a road and decide to stop on the roadside. You should not", "Apply the handbrake before leaving the vehicle", "Park facing against the traffic flow", "Switch off the engine", "Stop as close as you can to the side", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can you use the right lane of the three-lane dual carriageway for?", "General driving", "Towing a trailer", "Stopping when tired", "Overtaking", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("How many penalty points can you get for a traffic light offence?", "6", "9", "3", "12", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You decide to drive on a foggy day. What should you do before you set out?", "Make sure that the windows are clean", "Top up the radiator with anti-freeze", "Make sure that you have a warning triangle in the vehicle", "Check the battery", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You will be disqualified from driving if you get", "12 or more penalty points within a 3-year period", "10 or more penalty points within a 2-year period", "8 or more penalty points within a 3-year period", "6 or more penalty points within a 1-year period", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does having your registration number etched on all your car windows do?", "Increases the cost of your insurance", "Decreases the value of your car", "Acts as a deterrent to professional thieves", "Attracts potential car buyers", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a road and see a parked ice cream van further ahead. The road ahead is clear. What should you do?", "Drive carefully and slowly", "Use your horn to let others know you are there", "Select a higher gear", "Proceed as normal", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a motorway when you see hitchhikers on the hard shoulder asking for a lift. What should you do?", "Call the emergency services immediately", "Stop and pick them up", "Carry on driving", "Take the next exit", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the maximum penalty for failing to identify the driver of the vehicle?", "£500 fine", "3-6 penalty points", "£1,000 fine / Discretionary disqualification", "6-8 penalty points", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are forced to stop in a tunnel due to stationary traffic. How much space should you leave between you and the vehicle in front?", "2 metres", "At least 5 metres", "3 metres", "4 metres", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the first thing to do when providing emergency care?", "Gently shake their shoulders", "Make them warm and as comfortable as you can", "Check you are not in danger", "Try to get a response by asking questions", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You have just filled up your tank, you double-check for leaks and make sure that", "There is no visual damage to the fuel cap", "You have overfilled your tank", "The fuel cap is fastened loosely", "The fuel cap is removed", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are a holder of a non-European Community licence and are now resident in the UK. What is the maximum period of time you may drive on that licence?", "1 year", "2 years", "Indefinitely", "5 years", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these is a non-motoring offence which can earn you penalty points?", "Selling your car", "Failure to rectify vehicle defects", "Speeding", "Careless driving", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are involved in an accident with a vehicle containing dangerous goods. What is the first thing you should do?", "Rescue other casualties", "Switch off the engine", "Call the emergency services", "Smoke a cigarette", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can you do to save fuel?", "Miss out some gears", "Accelerate sharply in each gear", "Use lower gears as often as possible", "Use each gear in turn", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("It’s important to keep in mind the stopping distances in wet weather. Compared to dry roads, the stopping distance will", "Half", "Stay the same", "Triple", "Double", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are providing emergency care to a casualty. They are unconscious but breathing. What do you do?", "Gently shake their shoulders", "Wait until medics arrive", "Place them in the recovery position", "Administer chest compressions", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("In which of these conditions will your overall stopping distance increase?", "In strong winds", "In fog", "In the rain", "At night", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("It is snowing heavily and the weather conditions are getting worse. What should you do?", "Drive with your hazard warning lights on", "Don't drive unless you have a mobile phone", "Only drive when your journey is short", "Don't drive unless it's essential", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is a level crossing?", "A road which crosses a railway line", "Crossing for horses", "Crossing for cyclists", "Road accessing the motorway", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("The central reservation of a dual carriageway or motorway is marked with studs of which colour?", "Green", "Amber", "Red", "White", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a motorway when you see red lights flashing and a red ‘X’ above your lane. You can see cars queuing past the signal. What does it indicate?", "Proceed carefully with caution", "You must stop and not go beyond the signal in any lane", "Drive very slowly, there is a hazard ahead", "You must not go beyond the signal in that lane only", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is meant by the term ‘Progressive access’?", "A rider is allowed to progress to higher-category vehicles without passing any practical tests", "A rider is allowed to take a higher-category practical test if they already have at least two years’ experience on a lower-category motorcycle", "A rider is allowed to drive but only in the presence of a pillion passenger", "A rider is allowed to drive Category A vehicle if they've had a provisional licence for 1 year", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("The right-hand lane of a motorway with three or more lanes can’t be used by", "Vehicles drawing a trailer", "Cars", "Motorcycles", "Vans", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a slippery road and start skidding after applying the footbrake. What should you do?", "Release the brake pedal, steer into the direction opposite to the skid", "Ease off the accelerator and steer into the direction opposite to the skid", "Release the brake pedal, steer into the direction of the skid", "Ease off the accelerator and grip the steering wheel firmly", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are filling up your tank and you spill some fuel on the forecourt. What do you do?", "Warn the next person in line", "Drive away", "Try to clean it up yourself before telling the petrol station attendant", "Report it to the petrol station attendant", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the typical stopping distance for a car travelling at 70 mph?", "36 metres (118 feet)", "53 metres (175 feet)", "73 metres (240 feet)", "96 metres (315 feet)", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the minimum tread depth for cars?", "2 mm", "2.5 mm", "1 mm", "1.6 mm", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You stop to give assistance at a road incident. You think that one of the people involved is injured. There is no immediate danger. What should you do?", "Offer them a cigarette", "Leave the scene after calling the emergency services", "Move uninjured people away from the vehicles to safety", "Move injured people from their vehicles", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are providing emergency care to a casualty. You have cleared their airway and should check their breathing for up to how many seconds?", "5", "8", "10", "20", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("How often should you check tyre pressure?", "Daily", "Weekly", "Monthly", "Yearly", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are disqualified for an offence linked to the use of alcohol. What do you have to do to get your licence returned at the end of the period of disqualification?", "Satisfy your GP that you do not have an alcohol problem and are otherwise fit to drive", "Satisfy Court's Medical branch that you do not have an alcohol problem and are otherwise fit to drive", "Satisfy Police Medical branch that you do not have an alcohol problem and are otherwise fit to drive", "Satisfy DVLA's Medical branch that you do not have an alcohol problem and are otherwise fit to drive", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("If the police want to stop your vehicle they will, where possible, attract your attention by", "Flashing blue lights, headlights or sounding their siren or horn, usually from behind", "Directing you to pull over to the right side by using the right indicator.", "Overtaking, braking gently and using the left indicator", "Driving beside and pushing your vehicle to the left side of the road", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these is not the cause of excessive or uneven tyre wear?", "Low battery", "Not aligned wheels", "Fault in suspension system", "Fault in breaking system", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the maximum penalty for speeding on the motorway?", "£2,500 fine / Discretionary disqualification", "£1,000 fine / Discretionary disqualification", "Unlimited fine", "£500 fine", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do if your vehicle breaks down on a level crossing and the alarm starts to sound?", "Physically move the vehicle clear of the crossing", "Leave the vehicle and get clear of the crossing immediately", "Try to restart the engine", "Put the warning triangle on the railway track", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("How much room should you give a cyclist while overtaking?", "Depending on the cyclist's behaviour", "No room at all", "At least 3 metres", "As much as when overtaking a car", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You want to turn left at a junction when you notice a pedestrian who is already crossing the road. What should you do?", "Crawl forward to let them know you are there", "You have priority, but should let them cross", "The pedestrian has priority, give way to let them cross", "Keep going forward to keep the traffic behind you moving", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the maximum penalty for not having an MOT certificate?", "£100 fine", "£200 fine", "£500 fine", "£1,000 fine", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("When must you use your headlights?", "When you can't see for more than 100 metres", "When you can't see for more than 150 metres", "When you can't see for more than 200 metres", "When you can't see for more than 1 kilometre", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving on a motorway when your vehicle breaks down. You don’t have enough time to take the next exit or pull into a service area. What should you not do?", "Put a warning triangle on the road at least 45 metres (147 feet) behind your broken-down vehicle", "Leave the vehicle by the left-hand door and ensure your passengers do the same.", "Walk to an emergency telephone on your side of the carriageway", "Don't attempt repairs", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these is not one of the requirements to drive a moped?", "Be accompanied when driving on the public road", "Be 16 or over", "Have a provisional moped licence", "Complete CBT training", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("How do you treat a burn when providing emergency care?", "Cool the burn for at least 10 minutes", "Remove anything that's sticking to the burn", "Do not do anything until the medics arrive", "Use any liquid you have to cool the burn", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("How old do you have to be to drive Category AM vehicle?", "16", "17", "19", "21", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the name of the system intended to deter drivers and motorcyclists from following unsafe motoring practices?", "The penalty point system", "The 2-year system", "The 10-point system", "The Highway Code system", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving a vehicle and the passengers are distracting you. What should you do?", "Show off and compete with another driver", "Tell your passengers that you need to concentrate on the driving", "Try to concentrate on what they are doing", "Be encouraged to take risks", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these is allowed?", "Not having a valid driving licence for the category of motor vehicle you are driving", "Not informing DVLA if you change your name and/or address", "Not having an MOT certificate when driving to a pre-arranged test appointment", "Not having a valid insurance policy", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a road and want to turn left. You’ve already used your mirrors and gave a left-turn signal. There is a cyclist in front of you, what should you do?", "Pull up beside the cyclist, ready to turn left", "Flash your headlights to let the cyclist know you are there", "Tuck in behind the cyclist", "Overtake if there is enough time to complete the manoeuvre", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What do white studs mark?", "The lanes or the middle of the road", "The central reservation of a motorway", "The left edge of the road", "Slip roads", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You want to reverse from a side road into a main road. What should you do?", "Find a different place to reverse", "Check there are no pedestrians", "Check your blindspot", "Use all mirrors", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do before moving off?", "Turn radio on", "Use a high gear", "Check all mirrors", "Use your horn", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are following a large vehicle which signals left but moves to the right. What should you do?", "Give it time and space", "Tuck in the left", "Sound your horn", "Flash your headlights", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("How old do you have to be to drive tricycles with a power output over 15 kW?", "21", "19", "17", "16", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the minimum period of disqualification for dangerous driving or drink-driving?", "12", "9", "6", "3", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Coasting is known to reduce driver’s control. Which of these is not a consequence of coasting?", "Skidding when braking", "Engine braking is eliminated", "It's harder to steer on bends", "When going downhill vehicle speed increases quickly", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are a new driver. Your licence can be revoked automatically if", "You get 4 points or more within 1 year", "You get 6 points or more within 2 years", "You get 2 or more points within 1 year", "You get 8 points or more within 2 years", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What acts as a warning to drivers and motorcyclists that they risk disqualification?", "Accumulation of penalty points", "A police car driving behind", "Accumulation of dents", "Breakdown", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a busy road with vehicles in front and behind you. You see the word ‘Fog’ displayed on a road sign. The road ahead seems clear. You should", "Check your mirrors and slow down", "Turn on your fog lights", "Be prepared for a bank of fog ahead", "Continue as normal", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("When driving in a built-up area, when must you not use your horn?", "Between 10 pm and 6.00 am", "Between 11.30 pm and 7.00 am", "Between 11 pm and 6.00 am", "Between 10 pm and 7.00 am", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is Third-Party insurance?", "Covers you against your motor vehicle being stolen or damaged by fire", "Covers you against your motor vehicle being stolen, or damaged by fire as well as anyone you might injure or whose property you might damage", "Covers damage to your own motor vehicle, up to the market value of that vehicle, and personal injury to yourself", "Covers anyone you might injure or whose property you might damage", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You see a car with red L plates. Who is driving the car?", "Someone who holds a full licence in presence of a learner driver", "Someone who has recently passed their test", "A learner supervised by someone qualified to do so", "A learner driver alone", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Your vehicle pulls to one side when braking. What is the problem?", "The shock absorbers are worn", "Overheated engine", "There is a brake fault", "There are no anti-freeze agents in your radiator", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What is the maximum penalty for careless cycling?", "£500 fine", "£1,000 fine", "£200 fine", "£100 fine", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Vehicles parked on a 40 mph road at night must", "Keep the headlights on", "Be safely locked", "Park against the traffic", "Display parking lights", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("How many months of imprisonment could result for driving while disqualified in Scotland?", "6", "12", "3", "9", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these is NOT classified as Category A1 vehicle?", "Motorcycles with a power output of up to 11kW", "Vehicle and trailer combination up to 8,250kg maximum authorised mass (MAM)", "Motorcycles with an engine size up to 125cc", "Tricycles with a power output not exceeding 15 kW", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are feeling a bit tired but have to travel a long distance in the afternoon. Which of these should you not do?", "If you are feeling sleepy on the motorway, stop on the hard shoulder and take a nap", "Do not begin a journey if you are tired. Get a good night’s sleep before embarking on a long journey", "Plan your journey to take sufficient breaks", "Drink two cups of caffeinated coffee and take a short nap", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are leaving your vehicle. You should not", "Take your vehicle documents", "Leave your children or pets in an unventilated car", "Lock the car when you are only leaving for a few minutes", "Close the windows completely", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Before using your bike you must ensure that", "It is not raining and wind speed is less than 20 mph", "There's someone coming with you", "It is still light outside", "Your brakes are working", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Emergency services can be reached by dialling which number?", "999", "888", "777", "666", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You are driving along a road and you see the ‘Roadworks Ahead’ sign displayed. You MUST not", "Exceed any temporary maximum speed limit", "Keep a safe distance", "Use your mirrors", "Take extra care near cyclists and motorcyclists as they are vulnerable to skidding on grit, mud or other debris at road works", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You’re following a long vehicle. As it approaches a crossroads, it signals left but moves out to the right. What should you do?", "Overtake it as it starts to slow down", "Get closer in order to pass it quickly", "Stay well back and give it room", "Assume the signal is wrong and that it's turning right", "C", 1, Resources.Load<Sprite>("img/49"));
        all_questions.Add(quest);
        quest = new Question("What’s the meaning of this traffic sign?", "You have priority over vehicles coming towards you", "Give priority to vehicles coming towards you", "End of two-way road", "Bus lane ahead", "A", 1, Resources.Load<Sprite>("img/50"));
        all_questions.Add(quest);
        quest = new Question("At an incident, a casualty is unconscious. You need to check whether they’re breathing. How long should you allow for this check?", "At least 10 seconds", "At least 2 seconds", "At least 1 minute", "At least 2 minutes", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("On which part of a motorway are amber reflective studs found?", "Between the hard shoulder and the carriageway", "Between the acceleration lane and the carriageway", "Between the central reservation and the carriageway", "Between each pair of lanes", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which vehicle is most likely to take an unusual course at a roundabout?", "Long lorry", "Milk float", "Estate car", "Delivery van", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You’re approaching this cyclist. What should you do?", "Slow down and allow the cyclist to turn", "Overtake the cyclist on the left-hand side", "Flash your headlights at the cyclist", "Overtake before the cyclist gets to the junction", "A", 1, Resources.Load<Sprite>("img/51"));
        all_questions.Add(quest);
        quest = new Question("When mustn’t you stop on a clearway?", "During daylight hours", "At any time", "When it's busy", "In the rush hour", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You’re on a motorway in fog. The left-hand edge of the motorway can be identified by reflective studs. What colour are they?", "Green", "Amber", "Red", "White", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What’s the purpose of a catalytic converter?", "To reduce harmful exhaust gases", "To reduce the risk of fire", "To reduce engine wear", "To reduce fuel consumption", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What action would you take when elderly people are crossing the road?", "Wave them across so they know that you've seen them", "Be patient and allow them to cross in their own time", "Rev the engine to let them know that you're waiting", "Tap the horn in case they're hard of hearing", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do if a trailer starts to swing from side to side while you’re towing it?", "Accelerate until it stabilises", "Let go of the steering wheel and let it correct itself", "Ease off the accelerator to reduce your speed", "Brake hard and hold the pedal down", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You see a pedestrian carrying a white stick with a red band. What does this tell you?", "They have limited mobility", "They're deaf and blind", "They're deaf", "They're blind", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which type of vehicle should you be ready to give way to as you approach this bridge?", "Bicycles", "Buses", "Cars", "Motorcycles", "B", 1, Resources.Load<Sprite>("img/52"));
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "Distance to public telephone ahead", "Distance to passing place ahead", "Distance to parking place ahead", "Distance to public house ahead", "C", 1, Resources.Load<Sprite>("img/53"));
        all_questions.Add(quest);
        quest = new Question("Following a collision, someone has suffered a burn. The burn needs to be cooled. What’s the shortest time it should be cooled for?", "5 minutes", "10 minutes", "15 minutes", "20 minutes", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You see this sign ahead. What should you expect?", "The road will bend sharply to the right", "The road will bend sharply to the left", "The road will go steeply downhill", "The road will go steeply uphill", "B", 1, Resources.Load<Sprite>("img/54"));
        all_questions.Add(quest);
        quest = new Question("You’ve just passed your practical test. You don’t hold a full licence in another category. Within two years you get six penalty points on your licence. What will you have to do?", "Retake only your theory test", "Retake your theory and practical tests", "Retake only your practical test", "Reapply for your full licence immediately", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "Minimum speed 30 mph", "End of maximum speed", "End of minimum speed", "Maximum speed 30 mph", "C", 1, Resources.Load<Sprite>("img/55"));
        all_questions.Add(quest);
        quest = new Question("At a pelican crossing, what must you do when the amber light is flashing?", "Give way to pedestrians waiting to cross", "Stop and wait for the red light", "Stop and wait for the green light", "Give way to pedestrians already on the crossing", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What type of vehicle could you expect to meet in the middle of the road?", "Car", "Bicycle", "Lorry", "Motorcycle", "C", 1, Resources.Load<Sprite>("img/56"));
        all_questions.Add(quest);
        quest = new Question("What does this traffic sign mean?", "Give priority to oncoming traffic", "Two-way traffic", "No overtaking allowed", "One-way traffic only", "A", 1, Resources.Load<Sprite>("img/57"));
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "Vehicles may park on the right-hand side of the road only", "Vehicles may park on the left-hand side of the road only", "Vehicles may not park on the verge or footway", "Vehicles may park fully on the verge or footway", "D", 1, Resources.Load<Sprite>("img/58"));
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "Waiting permitted", "National speed limit applies", "Waiting restrictions apply", "Clearway (no stopping)", "C", 1, Resources.Load<Sprite>("img/59"));
        all_questions.Add(quest);
        quest = new Question("What does this road marking mean?", "Overtaking traffic should move back to the left", "The road bends to the left", "It's safe to overtake", "Traffic should use the hard shoulder", "A", 1, Resources.Load<Sprite>("img/60"));
        all_questions.Add(quest);
        quest = new Question("What colour are the reflective studs between the lanes on a motorway?", "White", "Amber", "Green", "Red", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What do these motorway signs show?", "They're countdown markers to the next exit", "They're distance markers to the next telephone", "They warn of a police control ahead", "They're countdown markers to a bridge", "A", 1, Resources.Load<Sprite>("img/61"));
        all_questions.Add(quest);
        quest = new Question("It’s essential that tyre pressures are checked regularly. When should this be done?", "When tyres are cold", "After any lengthy journey", "After travelling at high speed", "When tyres are hot", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What’s most likely to cause high fuel consumption?", "Accelerating around bends", "Poor steering control", "Harsh braking and accelerating", "Staying in high gears", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Where are you most likely to be affected by side winds?", "On a busy stretch of road", "On an open stretch of road", "On a narrow country lane", "On a long, straight road", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("How should you dispose of a used vehicle battery?", "Leave it on waste land", "Take it to a local-authority site", "Put it in the dustbin", "Bury it in your garden", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("When may you wait in a box junction?", "When you're stationary in a queue of traffic", "When approaching a pelican crossing", "When oncoming traffic prevents you turning right", "When approaching a zebra crossing", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "End of restricted speed area", "End of restricted parking area", "End of cycle route", "End of clearway", "B", 1, Resources.Load<Sprite>("img/62"));
        all_questions.Add(quest);
        quest = new Question("You’ve had a breakdown on the hard shoulder of a motorway. When the problem has been fixed, how should you rejoin the main carriageway?", "Wait on the hard shoulder until someone flashes their headlights at you", "Gain speed on the hard shoulder before moving out onto the carriageway", "Move out onto the carriageway using your hazard warning lights", "Move out onto the carriageway, then build up your speed", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Where would you see this sign?", "On the rear of a school bus or coach", "At playground areas", "At the side of the road", "In the window of a car taking children to school", "A", 1, Resources.Load<Sprite>("img/63"));
        all_questions.Add(quest);
        quest = new Question("On a motorway, when should the hard shoulder be used?", "When checking a road map", "When an emergency arises", "When taking a short rest", "When answering a mobile phone", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You’re travelling along a motorway. Where would you find a crawler or climbing lane?", "Before a junction", "On a steep gradient", "Along the hard shoulder", "Before a service area", "B", 1, Resources.Load<Sprite>("img/64"));
        all_questions.Add(quest);
        quest = new Question("For how long is a Statutory Off-Road Notification (SORN) valid?", "Until the vehicle is taxed, sold or scrapped", "Until the vehicle is insured and MOT’d", "Until the vehicle is repaired or modified", "Until the vehicle is used on the road", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What do traffic-calming measures do?", "Stop road rage", "Make overtaking easier", "Slow traffic down", "Make parking easier", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("When will your vehicle use more fuel?", "When its tyres are over-inflated", "When its tyres are of different makes", "When its tyres are under-inflated", "When its tyres are new", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("There’s a tractor ahead. You want to overtake but you aren’t sure whether it’s safe. What should you do?", "Speed past, flashing your lights at oncoming traffic", "Sound your horn to make the tractor pull over", "Follow another vehicle as it overtakes the tractor", "Stay behind the tractor if you're in any doubt", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What style of driving causes increased risk to everyone?", "Competitive", "Responsible", "Considerate", "Defensive", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do when you see two elderly pedestrians about to cross the road ahead?", "Expect them to wait for you to pass", "Speed up to get past them quickly", "Stop and wave them across the road", "Be careful; they may misjudge your speed", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "A route for cyclists only", "No route for pedestrians and cyclists", "A route for pedestrians and cyclists", "A route for pedestrians only", "C", 1, Resources.Load<Sprite>("img/65"));
        all_questions.Add(quest);
        quest = new Question("You arrive at the scene of a crash. Someone is bleeding badly from an arm wound. Nothing is embedded in it. What should you do?", "Apply pressure over the wound and keep the arm down", "Get them a drink", "Apply pressure over the wound and raise the arm", "Dab the wound", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does this sign mean?", "You have priority", "No motor vehicles", "Two-way traffic", "No overtaking", "D", 1, Resources.Load<Sprite>("img/66"));
        all_questions.Add(quest);
        quest = new Question("Why must you take extra care when turning right at this junction?", "The road surface is poor", "The footpaths are narrow", "The road markings are faint", "The view is restricted", "D", 1, Resources.Load<Sprite>("img/67"));
        all_questions.Add(quest);
        quest = new Question("In very hot weather the road surface can become soft. What will this affect?", "The tyre grip", "The fuel consumption", "The exhaust emissions", "The suspension", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You’ve just gone through deep water. What should you do to make sure your brakes are working properly?", "Avoid using the brakes at all for a few miles", "Go slowly while gently applying the brakes", "Accelerate and keep to a high speed for a short time", "Stop for at least an hour to allow them time to dry", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You see this sign ahead. What does it mean?", "National speed limit applies", "Waiting restrictions apply", "No stopping", "No entry", "C", 1, Resources.Load<Sprite>("img/68"));
        all_questions.Add(quest);
        quest = new Question("In which of these situations should you avoid overtaking?", "On a 30 mph road", "In a one-way street", "Just after a bend", "Approaching a dip in the road", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("The fluid level in your battery is low. What should you top it up with?", "Battery acid", "Distilled water", "Engine oil", "Engine coolant", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're making an appointment and will have to travel a long distance. How should you plan for the journey?", "Allow plenty of time for the trip", "Plan to travel at busy times", "Avoid roads with the national speed limit", "Prevent other drivers from overtaking", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're carrying an 11-year-old child in the back seat of your car. They're under 1.35 metres (4 feet 5 inches) tall. What must you make sure of?", "That they sit between two belted people", "That they can fasten their own seat belt", "That a suitable child restraint is available", "That they can see clearly out of the front window", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Up to how much more fuel will you use by driving at 70 mph, compared with driving at 50 mph?", "0,1", "0,3", "0,75", "1", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What's most likely to cause high fuel consumption?", "Poor steering control", "Accelerating around bends", "Staying in high gears", "Harsh braking and accelerating", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do when you leave your car unattended for a few minutes?", "Leave the engine running", "Switch the engine off but leave the key in", "Lock it and remove the key", "Park near a traffic warden", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're checking your trailer tyres. What's the legal minimum tread depth over the central three-quarters of its breadth?", "1 mm", "1.6 mm", "2 mm", "2.6 mm", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("hat's the legal minimum depth of tread for car tyres?", "1 mm", "1.6 mm", "2.5 mm", "4 mm", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're parked at the side of the road. You'll be waiting some time for a passenger. What should you do?", "Switch off the engine", "Apply the steering lock", "Switch off the radio", "Use your headlights", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which driving technique can help you save fuel?", "Using lower gears as often as possible", "Accelerating sharply in each gear", "Using each gear in turn", "Missing out some gears", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You service your own vehicle. How should you get rid of the old engine oil?", "Take it to a local-authority site", "Pour it down a drain", "Tip it into a hole in the ground", "Put it in your dustbin", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("How can you reduce the damage your vehicle causes to the environment?", "Use narrow side streets", "Brake heavily", "Use busy routes", "Anticipate well ahead", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You have too much oil in your engine. What could this cause?", "Low oil pressure", "Engine overheating", "Chain wear", "Oil leaks", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can cause excessive or uneven tyre wear?", "A faulty gearbox", "A faulty braking system", "A faulty electrical system", "A faulty exhaust system", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do if your anti-lock brakes (ABS) warning light stays on?", "Check the brake-fluid level", "Check the footbrake free play", "Check that the handbrake is released", "Have the brakes checked immediately", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're driving a friend's children home from school. They're both under 14 years old. Who's responsible for making sure they wear a seat belt or approved child restraint where required?", "An adult passenger", "The children", "You, the driver", "Your friend", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of the following may help to deter a thief from stealing your car?", "Always keeping the headlights on", "Fitting reflective glass windows", "Always keeping the interior light on", "Etching the registration number on the windows", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("How can drivers help the environment?", "By accelerating harshly", "By accelerating gently", "By using leaded fuel", "By driving faster", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can people who live or work in towns and cities do to help reduce urban pollution levels?", "Drive more quickly", "Over-rev in a low gear", "Walk or cycle", "Drive short journeys", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("When you use the brakes, your vehicle pulls to one side. What should you do?", "Increase the pressure in your tyres", "Have the brakes checked as soon as possible", "Change gear and pump the brake pedal", "Use your parking brake at the same time", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What will happen if your car's wheels are unbalanced?", "The steering will pull to one side", "The steering will vibrate", "The brakes will fail", "The tyres will deflate", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're carrying a five-year-old child in the back seat of your car. They're under 1.35 metres (4 feet 5 inches) tall. A correct child restraint isn't available. How should you seat them?", "Behind the passenger seat", "Using an adult seat belt", "Sharing a belt with an adult", "Between two other children", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What should you do when leaving your vehicle parked and unattended?", "Park near a busy junction", "Park in a housing estate", "Lock it and remove the key", "Leave the left indicator on", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're carrying two 13-year-old children and their parents in your car. Who's responsible for seeing that the children wear seat belts?", "The children's parents", "You, the driver", "The front-seat passenger", "The children", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("How can you reduce the chances of your car being broken into when leaving it unattended?", "Take all valuables with you", "Park near a taxi rank", "Place any valuables on the floor", "Park near a fire station", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does ecosafe driving achieve?", "Increased fuel consumption", "Improved road safety", "Damage to the environment", "Increased exhaust emissions", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can cause excessive or uneven tyre wear?", "Faults in the gearbox", "Faults in the engine", "Faults in the suspension", "Faults in the exhaust system", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("When is it acceptable for a passenger to travel in a car without wearing a seat belt?", "When they're under 14 years old", "When they're under 1.5 metres (5 feet) in height", "When they're sitting in the rear seat", "When they're exempt for medical reasons", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What causes the most damage to the environment?", "Choosing a fuel-efficient vehicle", "Having your vehicle serviced regularly", "Driving in as high a gear as possible", "Making a lot of short journeys", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("It's essential that tyre pressures are checked regularly. When should this be done?", "After any lengthy journey", "After travelling at high speed", "When tyres are hot", "When tyres are cold", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Before starting a journey, it's wise to plan your route. How can you do this?", "Look at a map", "Contact your local garage", "Look in your vehicle handbook", "Check your vehicle registration document", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You enter a road where there are road humps. What should you do?", "Maintain a reduced speed throughout", "Accelerate quickly between each one", "Always keep to the maximum legal speed", "Drive slowly at school times only", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What will be the result of having your vehicle properly serviced?", "Reduced insurance premiums", "Lower vehicle excise duty (road tax)", "Better fuel economy", "Slower journey times", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("How will a roof rack affect your car's performance?", "There will be less wind noise", "The engine will use more oil", "The car will accelerate faster", "Fuel consumption will increase", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You need to top up your battery. What level should you fill it to?", "The top of the battery", "Halfway up the battery", "Just below the cell plates", "Just above the cell plates", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("On a vehicle, where would you find a catalytic converter?", "In the fuel tank", "In the air filter", "On the cooling system", "On the exhaust system", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What could you do to reduce the volume of traffic on the roads?", "Drive in a bus lane", "Use a car with a smaller engine", "Walk or cycle on short journeys", "Travel by car at all times", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("How can you lessen the risk of your vehicle being broken into at night?", "Leave it in a well-lit area", "Park in a quiet side road", "Don't engage the steering lock", "Park in a poorly-lit area", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("It's important to wear suitable shoes when you're driving. Why is this?", "To prevent wear on the pedals", "To maintain control of the pedals", "To enable you to adjust your seat", "To enable you to walk for assistance if you break down", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("How can you avoid wasting fuel?", "By having your vehicle serviced regularly", "By revving the engine in the lower gears", "By keeping an empty roof rack on your vehicle", "By driving at higher speeds where possible", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What's the main cause of brake fade?", "The brakes overheating", "Air in the brake fluid", "Oil on the brakes", "The brakes out of adjustment", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these makes your tyres illegal?", "They were bought second-hand", "They have a large, deep cut in the side wall", "They're of different makes", "They have different tread patterns", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can driving smoothly achieve?", "Reduction in journey times by about 15%", "Increase in fuel consumption by about 15%", "Reduction in fuel consumption by about 15%", "Increase in journey times by about 15%", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("What's the purpose of road humps, chicanes and narrowings?", "To separate lanes of traffic", "To increase traffic speed", "To allow pedestrians to cross", "To reduce traffic speed", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("It can be helpful to plan your route before starting a journey. Why should you also plan an alternative route?", "Your original route may be blocked", "Your maps may have different scales", "You may find you have to pay a congestion charge", "You may get held up by a tractor", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're testing your suspension. You notice that your vehicle keeps bouncing when you press down on the front wing. What does this mean?", "Worn tyres", "Tyres under-inflated", "Steering wheel not located centrally", "Worn shock absorbers", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these will help you to keep your car secure?", "Vehicle breakdown organisation", "Vehicle watch scheme", "Advanced driver's scheme", "Car maintenance class", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("You avoid busy times when travelling. How will this affect your journey?", "You're more likely to be held up", "Your journey time will be longer", "You'll travel a much shorter distance", "You're less likely to be delayed", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What's the most important reason for having a properly adjusted head restraint?", "To make you more comfortable", "To help you avoid neck injury", "To help you relax", "To help you maintain your driving position", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Fuel consumption is at its highest when you're doing what?", "Braking", "Coasting", "Accelerating", "Steering", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("Why do MOT tests include a strict exhaust emission test?", "To recover the cost of expensive garage equipment", "To help protect the environment against pollution", "To discover which fuel supplier is used the most", "To make sure diesel and petrol engines emit the same fumes", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What can rapid acceleration and heavy braking lead to?", "Reduced pollution", "Increased fuel consumption", "Reduced exhaust emissions", "Increased road safety", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("How can driving in an ecosafe manner help protect the environment?", "Through the legal enforcement of speed regulations", "By increasing the number of cars on the road", "Through increased fuel bills", "By reducing exhaust emissions", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("How can you reduce the environmental harm caused by your motor vehicle?", "Only use it for short journeys", "Don't service it", "Drive faster than normal", "Keep engine revs low", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of the following shouldn't be kept in your vehicle?", "The car dealer's details", "The owner's manual", "The service record", "The vehicle registration document", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're leaving your vehicle parked on a road and unattended. When may you leave the engine running?", "If you'll be parking for less than five minutes", "If the battery keeps going flat", "When parked in a 20 mph zone", "Never if you're away from the vehicle", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does the law require you to keep in good condition?", "Gears", "Transmission", "Door locks", "Seat belts", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Why have 'red routes' been introduced in major cities?", "To raise the speed limits", "To help the traffic flow", "To provide better parking", "To allow lorries to load more freely", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("What's badly affected if the tyres are under-inflated?", "Braking", "Indicating", "Changing gear", "Parking", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("Why is it a good idea to plan your journey to avoid busy times?", "You'll have an easier journey", "You'll have a more stressful journey", "Your journey time will be longer", "It will cause more traffic congestion", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What will reduce the risk of neck injury resulting from a collision?", "An air-sprung seat", "Anti-lock brakes", "A collapsible steering wheel", "A properly adjusted head restraint", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Turning the steering wheel while stationary can cause damage to which part of your car?", "Gearbox", "Engine", "Brakes", "Tyres", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("What's most likely to waste fuel?", "Reducing your speed", "Driving on motorways", "Using different brands of fuel", "Under-inflated tyres", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Where would parking your vehicle cause an obstruction?", "Alongside a parking meter", "In front of a property entrance", "On your driveway", "In a marked parking space", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("When leaving your vehicle, where should you try to park?", "Opposite a traffic island", "In a secure car park", "On a bend", "At or near a taxi rank", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("Which of these, if allowed to get low, could cause you to crash?", "Anti-freeze level", "Brake fluid level", "Battery water level", "Radiator coolant level", "B", 1, null);
        all_questions.Add(quest);
        quest = new Question("When should you especially check the engine oil level?", "Before a long journey", "When the engine is hot", "Early in the morning", "Every 6000 miles", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("What does it mean if this light comes on while you're driving?", "A fault in the braking system", "The engine oil is low", "A rear light has failed", "Your seat belt isn't fastened", "A", 1, Resources.Load<Sprite>("img/69"));
        all_questions.Add(quest);
        quest = new Question("You want to put a rear-facing baby seat on the front passenger seat, which is protected by a frontal airbag. What must you do before setting off?", "Deactivate the airbag", "Turn the seat to face sideways", "Ask a passenger to hold the baby", "Put the child in an adult seat belt", "A", 1, null);
        all_questions.Add(quest);
        quest = new Question("How can you help to prevent your car radio being stolen?", "Park in an unlit area", "Leave the radio turned on", "Park near a busy junction", "Install a security-coded radio", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("Can you park on the zigzag lines of a zebra crossing when there are no other parking spaces to be found?", "No, not unless you stay with your car", "Yes, in order to drop off a passenger", "Yes, if you don't block people from crossing", "No, not under any circumstances", "D", 1, null);
        all_questions.Add(quest);
        quest = new Question("You have to leave valuables in your car. What would it be safest to do?", "Put them in a carrier bag", "Park near a school entrance", "Lock them out of sight", "Park near a bus stop", "C", 1, null);
        all_questions.Add(quest);
        quest = new Question("You're parked on the road at night. Where must you use parking lights?", "Where there are continuous white lines in the middle of the road", "Where the speed limit exceeds 30 mph", "Where you're facing oncoming traffic", "Where you're near a bus stop", "B", 1, null);
        all_questions.Add(quest);

    }
}
