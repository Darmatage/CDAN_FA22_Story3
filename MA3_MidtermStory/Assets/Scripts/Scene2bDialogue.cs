using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name; // player
        public Text Char1speech;
        public Text Char2name; //beatrice <3
        public Text Char2speech;
        public Text Char3name; //narrator
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;
        public GameObject ArtChar1f;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;
		private string thisScene;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtChar1e.SetActive(false);
        ArtChar1f.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);

		thisScene = SceneManager.GetActiveScene().name;
		GameHandler.lastScene = thisScene;
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You decide to follow the tall woman, jogging a little to reach the more distant area.";

				GameHandler.sawHotLady=true;
        }
       else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Pulling back the tattered curtains, you step over broken wood planks and bent nails strewn about the dirt floor. ";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You walk down the narrow hallway, taking a peek inside some of the rooms only to find nothing but destruction. ";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "A faint light from one of the rooms at the end of the hallway catches your attention, and you head towards it.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "…hello?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Stupidly, you call out for any sort of answer. None arrives.";
        }
       else if (primeInt == 8){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "You’re beginning to doubt your sanity as you approach the dimly lit room, once more poking your head inside. ";
        }
       else if (primeInt == 9){
         ArtBG1.SetActive(false);
         ArtBG2.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "This room seems more intact than the rest. \nRipped clothes are sloppily hung on a nearby rack. ";
        }
        else if (primeInt == 10){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "A vanity with flickering lights and a cracked mirror sits on the opposite end of the room.";
        }
         else if (primeInt == 11){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "The woman from before is sitting on the cushioned stool in front of the mirror, \nher head leaning forward as she applies lipstick.";
        }
        else if (primeInt == 12){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "After a brief moment of silence, her eyes meet yours through the mirror.";
        }
        else if (primeInt == 13){
           StartCoroutine(FadeIn(ArtChar1a));
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "Well then, this is unexpected.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 14){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "It’s been so long since I’ve had company.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 15){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
          ArtChar1c.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "Especially one that isn’t a giant cat or a ditzy gymnast.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 16){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "Oh, sorry, um–";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 17){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Before you can explain further, the woman turns to face you and stands from her seat.";
        }
        else if (primeInt == 18){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "You’re caught off guard by the unexpected but luscious beard covering the lower half of her face.";
        }
        else if (primeInt == 19){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
          ArtChar1c.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "Beatrice.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 20){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "That’s my name.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 21){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "She catches your surprise, but only seems amused by it.";
        }
        else if (primeInt == 22){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "In her hand is a comb now, \nidly brushing the tangled locks from that amazing beard.";
        }
        else if (primeInt == 23){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "I’ve rendered you speechless now, haven’t I, sweetheart? \nI tend to have that effect on people. ";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 24){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "It’s good to know my charm hasn’t faded.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 25){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "She’s teasing you, and you crack a nervous laugh.";
        }
        else if (primeInt == 26){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "No, just, uh…";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
       else if (primeInt == 27){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You decide to change the subject.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// CONVERGENCE

        else if (primeInt == 31){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "She gazes at you for a moment longer, as if scrutinizing you.";
        }
        else if (primeInt == 32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Then she speaks, but her voice is lower than before.";
        }
        else if (primeInt == 33){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
          ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "I know you’re not here for those kinds of silly questions.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 34){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "No one ever is.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 35){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "And as much as I’d love to humor a cute thing like you, we both have places to be. ";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 36){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
          ArtChar1e.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "You have more important questions, hmm? \nGo on, then.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 37){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1e.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Well…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1c.SetActive(true);
                NextScene1Button.SetActive(false);
                NextScene2Button.SetActive(true);
        }

// ENCOUNTER AFTER CHOICE #1a
       else if (primeInt == 100){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I’ve heard rumors about it on the Internet, but I didn’t think any of them were actually true.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 101){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(true);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "I don’t know where this ‘Internet’ is that you’re talking about.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 102){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Really? That’s kind of hard to believe.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 103){
                 Char1name.text = "YOU";
                 Char1speech.text = "Everyone’s heard of the Internet.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 104){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1d.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "I am not one to lie, my dear.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
         else if (primeInt == 105){
           ArtChar1a.SetActive(true);
           ArtChar1b.SetActive(false);
           ArtChar1d.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "You feel like this is going nowhere.";
        }
          else if (primeInt == 106){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "You sigh, and wave your hand dismissively.";
        }
           else if (primeInt == 107){
             ArtChar1a.SetActive(false);
             ArtChar1b.SetActive(false);
             ArtChar1d.SetActive(false);
                    Char1name.text = "YOU";
                    Char1speech.text = "…nevermind.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "";
                    Char3speech.text = "";
        primeInt = 30;
        }

// ENCOUNTER AFTER CHOICE #1b

       else if (primeInt == 200){
         ArtChar1a.SetActive(true);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "Ah, the Ringmaster.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 201){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "Yeah! Wait, how’d you know?";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
         else if (primeInt == 202){
           ArtChar1a.SetActive(false);
           ArtChar1b.SetActive(true);
           ArtChar1c.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Beatrice";
                  Char2speech.text = "Darling, the Ringmaster greets any and all who come here.";
                  Char3name.text = "";
                  Char3speech.text = "";
        }
          else if (primeInt == 203){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Beatrice";
                   Char2speech.text = "They run the show, surely you’ve been to a circus before.";
                   Char3name.text = "";
                   Char3speech.text = "";
        }
           else if (primeInt == 204){
             ArtChar1a.SetActive(false);
             ArtChar1b.SetActive(false);
             ArtChar1c.SetActive(false);
                    Char1name.text = "YOU";
                    Char1speech.text = "Once or twice as a kid, but I don’t remember it well.";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "";
                    Char3speech.text = "";
        }
            else if (primeInt == 205){
                     Char1name.text = "YOU";
                     Char1speech.text = "The popcorn and corn dogs were amazing, though.";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "";
                     Char3speech.text = "";
        }
             else if (primeInt == 206){
               ArtChar1a.SetActive(false);
               ArtChar1b.SetActive(false);
               ArtChar1c.SetActive(true);
                      Char1name.text = "";
                      Char1speech.text = "";
                      Char2name.text = "Beatrice";
                      Char2speech.text = "Circus food is quite the special treat every now and then.";
                      Char3name.text = "";
                      Char3speech.text = "";
        }
              else if (primeInt == 207){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "An awkward silence hangs between the both of you.";
        }
       else if (primeInt == 208){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You clear your throat in an attempt to mask your embarrassment.";
          primeInt = 30;
        }

// ENCOUNTER AFTER "ASK ABOUT CIRCUS HISTORY"

        else if (primeInt == 300){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "What happened here?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 301){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "That, my dear, is a long story. You’ll want to sit down if you want to know everything.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "She points to another dusty cushioned stool that’s laying on its side nearby, and you move to prop it up. ";
        }
        else if (primeInt == 303){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "";
              Char2speech.text = "";
              Char3name.text = "";
              Char3speech.text = "You cough a bit as you brush away the dust, before taking a seat.";
        }
        else if (primeInt == 304){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(true);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Beatrice";
              Char2speech.text = "The circus was built in 1920, founded by our dear Ringmaster. \nIt was a huge success!";
              Char3name.text = "";
              Char3speech.text = "";
        }
        else if (primeInt == 305){
              Char1name.text = "";
              Char1speech.text = "";
              Char2name.text = "Beatrice";
              Char2speech.text = "So many people from the town would come see what we had to offer. ";
              Char3name.text = "";
              Char3speech.text = "";
        }
        else if (primeInt == 306){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(true);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Beatrice";
               Char2speech.text = "Fire eaters, trapeze artists, elephants.";
               Char3name.text = "";
               Char3speech.text = "";
        }
        else if (primeInt == 307){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(true);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "I garnered quite the audience myself.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 308){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(true);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Her gaze saddens, as she looks to her lap.";
        }
        else if (primeInt == 309){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "But…I don’t think it was ever enough for them. ";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 310){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "They wanted to be known all over the world. \nTo have everyone know of their name.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 311){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "She shakes her head, her expression unreadable now.";
        }
        else if (primeInt == 312){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(true);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "They sacrificed everything to get what they wanted.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 313){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(true);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "Even us.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 314){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(true);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "It’s funny to think that, in the end, it didn’t even work. It’s not finished.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 315){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "What’s not finished?";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 316){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(true);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Beatrice is silent, for a long while. ";
        }
        else if (primeInt == 317){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Finally, after a few minutes, she raises her head and stares at you.";
        }
        else if (primeInt == 318){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "It’s not my place to say.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 319){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "Karl will tell you what you need to know.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 320){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "She looks around the dressing room, before standing.";
        }
        else if (primeInt == 321){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Beatrice";
                 Char2speech.text = "You shouldn’t stay here long. I appreciate you listening. It means a lot.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 322){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
          ArtChar1e.SetActive(false);
          ArtChar1f.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "Of course. I’ll do what I can to help.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 323){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "With that, you stand as well.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(false);
        }


     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){ //choice 1a
                Char1name.text = "YOU";
                Char1speech.text = "I have a lot of questions about this place.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){ //choice 1b
                Char1name.text = "YOU";
                Char1speech.text = "So there was this weird person who welcomed me to the place.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){ //choice 1b
                Char1name.text = "YOU";
                Char1speech.text = "Why is the circus abandoned?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                NextScene2Button.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene0");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3b");
        }

        IEnumerator FadeIn(GameObject fadeImage){
                float alphaLevel = 0;
                fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel += 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }

        IEnumerator FadeOut(GameObject fadeImage){
                float alphaLevel = 1;
                fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                for(int i = 0; i < 100; i++){
                        alphaLevel -= 0.01f;
                        yield return null;
                        fadeImage.GetComponent<Image>().color = new Color(1, 1, 1, alphaLevel);
                        Debug.Log("Alpha is: " + alphaLevel);
                }
        }
}
