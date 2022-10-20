using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3bDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name; //player
        public Text Char1speech;
        public Text Char2name; //beatrice
        public Text Char2speech;
        public Text Char3name; //narrator
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
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
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "She’s right.";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Her charms have gotten to you, but you have no intention of letting her go now. ";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You’ve completely forgotten about the task at hand, but what does that matter?";
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "You know, maybe you could humor me for just a while.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "Isn’t that quite the response? \nYou sound awfully bold. ";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You definitely feel bold.";
        }
       else if (primeInt == 8){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Well, how are you going to woo her now?";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

// CONVERGENCE

        else if (primeInt == 9){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Before you can say anything else, her finger presses against your lips to shut you up.";
        }
        else if (primeInt == 10){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(true);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "She can’t hold it anymore; a boisterous laugh erupts. ";
        }
        else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "Please, sweetheart, don’t utter another word.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 12){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You nod, and she removes her finger.";
        }
        else if (primeInt == 13){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(true);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "I haven’t felt that happy for the longest time. Thank you, cutie.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You give her a smile in return, thinking for a long moment.";
        }
        else if (primeInt == 15){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Then you move closer to her, taking her hands in yours.";
        }
        else if (primeInt == 16){
                Char1name.text = "YOU";
                Char1speech.text = "Why don’t we run away together, Beatrice? ";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 17){
                Char1name.text = "YOU";
                Char1speech.text = "Let’s forget this place and live in a cottage in the woods and make pumpkin pies together!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 18){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Hm..that’s a tempting offer, especially from someone like you.";
        }
        else if (primeInt == 19){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(true);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "I’d be happy to.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 20){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "And so, holding her hand in yours, you both exit the dressing room and slip away from the circus, never to be seen again.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

// ENCOUNTER AFTER CHOICE #1A
       else if (primeInt == 100){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "I’m sold.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "YOU";
                Char1speech.text = "Aw hell yeah.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(true);
                allowSpace = true;
                primeInt = 8;
        }

// ENCOUNTER AFTER CHOICE #1B

       else if (primeInt == 200){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "That was terrible.";
        }
        else if (primeInt == 201){
                Char1name.text = "YOU";
                Char1speech.text = "Are you Australian?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
         }
        else if (primeInt == 202){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Beatrice";
                Char2speech.text = "No–";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 203){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Because you meet all of my koalafications.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 204){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You swear you could hear a pin drop after that one, but the wide grin that’s on her face encourages you to spit out one more crappy pick up line.";
        }
        else if (primeInt == 205){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "If I could rearrange the alphabet…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 206){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "…I’d put U and I together.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(true);
                allowSpace = true;
            primeInt = 8;
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Okay, so, imagine this…";
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You take a step closer, winking slyly at her.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Win");
        }

}
