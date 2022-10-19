using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       public Text Char3name;
       public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        NextScene3Button.SetActive(false);
        NextScene4Button.SetActive(false);
        nextButton.SetActive(true);
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
               ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "After a few hours of surfing the internet, you come across a strange site. It lists the location of a nearby abandoned circus, often visited by rowdy teens who spout ghost stories about the place. Having nothing better to do, you decide to drive out to this place and see if the rumors are true.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "You";
                Char1speech.text = "At least the circus is actually here. I’m surprised it still looks this good after a hundred years or so.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "You enter through a tall gate, its sign half torn. You can barely make out the letters, [Circus Name]. A dilapidated tent stands in the distance, barely held up by the ropes attaching it to the ground. Many smaller tents are scattered around, as well as stalls.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Well, well, look what the clown dragged in!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "Out of nowhere, a loud voice greets you. A figure makes themselves known from behind one of the stalls, sporting a hat too big for their head and dressed in fancy clothing. They flash a big smile, taking your hand in one of theirs and shaking it – too much.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "You";
                Char1speech.text = "Ah, hello!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "You’re caught off guard by the eccentric nature of this person, and left with questions.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                //nextButton.SetActive(false);
                //allowSpace = false;
                //Choice1a.SetActive(true); // function Choice1aFunct()
                //Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 9){
                Char1name.text = "You";
                Char1speech.text = "Nice to meet you, er–";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Just call me The Ringmaster!";
                //nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene1Button.SetActive(true);
        }

       else if (primeInt == 11){
                Char1name.text = "You";
                Char1speech.text = "…right. So, uh, are you cosplaying or something? I wasn’t really expecting anyone else here, especially this late at night…";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "The Ringmaster gives you a quizzical look, their only response a slight shrug of their shoulders.";
                Char2name.text = "";
                Char2speech.text = "";
                //nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene2Button.SetActive(true);
        }
        else if (primeInt == 13){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "‘Cosplaying?’ What a peculiar term.";
        }
        else if (primeInt == 14){
                 Char1name.text = "";
                 Char1speech.text = "They seem to ignore that question, instead moving on with that same enthusiasm from before.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 15){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Anywho, you’re at the [Circus Name]! A fine place for anyone looking for a getaway from the monotonous reality we are all subject to!";
        }
        else if (primeInt == 16){
                 Char1name.text = "";
                 Char1speech.text = "They swing on their heel, now beside you as they wrap an arm around your shoulder and gesture to…what used to be the circus.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 17){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Don’t be shy, my carnies and I are just ecstatic to show you just what we can do! I’m sure you’ll love each and every act!";
        }
        else if (primeInt == 18){
                 Char1name.text = "";
                 Char1speech.text = "You’re unsure whether or not to mention the fact that the circus is literally abandoned, but decide to keep your mouth shut.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 19){
                 Char1name.text = "You";
                 Char1speech.text = "Okay…so, I had some questions about this place–";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 20){
                 Char1name.text = "";
                 Char1speech.text = "The one-sided conversation is cut short by a…howl? Whatever it is, it’s deep, and sounds like it came from the forest just beyond the circus tent. Out of the corner of your eye, you see the Ringmaster’s pleasant grin drop for a few seconds. Replaced by a scowl, before they quickly bring their act together and swing around again in front of you.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 21){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Ah, destiny calls! Don’t move a muscle, I’ll be right back to give you a grand old tour!";
        }
        else if (primeInt == 22){
                 Char1name.text = "";
                 Char1speech.text = "And just like that, they’re gone. For a few minutes you do stay put, but after fifteen minutes go by, and then twenty, you decide to stop sitting around and waiting. As you head deeper into the area, several curious things seem to happen all at once.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 23){
                 Char1name.text = "";
                 Char1speech.text = "A strange noise comes from one of the larger tents, akin to a tiger’s growl.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 24){
                 Char1name.text = "";
                 Char1speech.text = "An unnaturally tall woman heading inside one of the abandoned dressing rooms in the distance.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 25){
                 Char1name.text = "";
                 Char1speech.text = "A considerably large barrel off to the side of the main tent, and muffled noises coming from within it.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 26){
                 Char1name.text = "";
                 Char1speech.text = "And a small bunny, just staring at you from a few feet away.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt == 27){
                 Char1name.text = "You";
                 Char1speech.text = "Huh.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 NextScene1Button.SetActive(true);
                 NextScene2Button.SetActive(true);
                 NextScene3Button.SetActive(true);
                 NextScene4Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "I don't know what you're talking about!";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Sure, anything you want... just lay off the club.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene2c");
        }
        public void SceneChange4(){
                SceneManager.LoadScene("Scene2d");
        }
}
