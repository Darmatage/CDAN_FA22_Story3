using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3aDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       public Text Char3name;
       public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
               ArtChar1a.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You arrive back at the main tent.";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Unlike the last time you were here; the circus is dead silent.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "Um, hello?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "Where did everybody go?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You hear a crunch of leaves behind you.";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Before you can turn around, something hits you in the back of the head and you black out.";
        }
       else if (primeInt == 8){
                ArtBG1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                //nextButton.SetActive(false);
                //allowSpace = false;
                //Choice1a.SetActive(true); // function Choice1aFunct()
                //Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 9){
                ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You open your eyes and see a blood soaked array.";
        }
       else if (primeInt == 10){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Wakey, wakey puny mortal.";
                Char3name.text = "";
                Char3speech.text = "";
                //nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene1Button.SetActive(true);
        }

       else if (primeInt == 11){
                Char1name.text = "YOU";
                Char1speech.text = "What the hell!?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Your attempts to meddle with my circus’ affairs has been truly pitiful.";
                Char3name.text = "";
                Char3speech.text = "";
                //nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene2Button.SetActive(true);
        }
        else if (primeInt == 13){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "You didn’t even come close to finding out what's going on.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 14){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Oh well, you’ll get a glimpse behind the curtain now.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 15){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "You try to move but realize your hands and feet are tired.";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 Choice1a.SetActive(true); // function Choice1aFunct()
                 Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 100){
                 ArtChar1a.SetActive(false);
                 ArtChar1b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Nice try, but no.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 101){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "I’d much rather barter your life for infinite power than barter for anything you have.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 102){
          ArtChar1b.SetActive(false);
          ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "You see, I’m going to sacrifice you to a demon.";
                 Char3name.text = "";
                 Char3speech.text = "";
                 primeInt = 299;
        }
        else if (primeInt == 200){
          ArtChar1a.SetActive(false);
          ArtChar1c.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "There's no need for a potty mouth.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 201){
                 Char1name.text = "YOU";
                 Char1speech.text = "*********** *********.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 202){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Yikes, you have issues.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 203){
          ArtChar1c.SetActive(false);
          ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Whatever, you won’t have anything after I sacrifice you.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 204){
                 Char1name.text = "YOU";
                 Char1speech.text = "You’re going to what?!";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 205){
          ArtChar1a.SetActive(false);
          ArtChar1c.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Wow you humans are really dumb.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 206){
          ArtChar1c.SetActive(false);
          ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "I had a long speech planned but I’ll cut it short.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 207){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "I’m going to kill you, and in return for your life gain immeasurable power.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 208){
                 Char1name.text = "YOU";
                 Char1speech.text = "You won't get away with this!";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 209){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Of course I will.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 210){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
          ArtChar1b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "After all, Rhubarb has agreed to help dispose of you.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 211){
          ArtChar1b.SetActive(false);
          ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "You really made him unhappy when you refused to pet him, you know.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 212){
          ArtChar1a.SetActive(false);
          ArtChar1c.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "What kind of monster refuses to pet a little kitty?";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 213){
          ArtChar1c.SetActive(false);
          ArtChar1b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "The Ringmaster gets distracted and starts petting and baby talking Rhubarb.";
        }
        else if (primeInt == 214){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "You’re a good boy aren’t you!";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 215){
          ArtChar1c.SetActive(false);
          ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Ahem. Anyway, let's get on with the show.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 216){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Rhubarb approaches you.";
        }
        else if (primeInt == 217){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Say bye bye to living punny mortal.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 218){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Mwahhahahhahahhahahahahha, mwahhhaahah mwahahaha.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 219){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "The last thing you see is Rhubarb’s mouth opening wide.";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 NextScene1Button.SetActive(true);
        }


     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Hey, we can talk about this.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "You ******** ***** ***** *** little ******!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}
