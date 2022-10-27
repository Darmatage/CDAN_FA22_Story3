using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2dDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;	//player
        public Text Char1speech;
        public Text Char2name;	//karl
        public Text Char2speech;
        public Text Char3name;	//narrator
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
		public GameObject ArtChar1d;
		public GameObject ArtChar1e;
		public GameObject ArtChar1f;

       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
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
        ArtBG1.SetActive(false);
        ArtBG2.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "You stare back at the rabbit. It runs off and you follow it.";

				GameHandler.sawRabbit=true;
        }
       else if (primeInt ==3){
         ArtBG1.SetActive(true);
               ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "It leads you to a magicians booth where you run into the magician.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                ArtChar1a.SetActive(false);
                ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Karl";
                Char2speech.text = "Oww, watch where you're going buddy!";
				Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
       else if (primeInt == 100){
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Karl";
                Char2speech.text = "Aw it’s okay! It's not a big deal!";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Karl";
                Char2speech.text = "I’m Karl, the circus resident magician.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==102){
                ArtChar1e.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Karl";
                Char2speech.text = "I don’t think I've ever seen you around here before.";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 103){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah, I’m not from here. Just checking out the circus.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 104){
            ArtChar1a.SetActive(false);
            ArtChar1b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "The rabbit Karl is holding moves.";
        }
       else if (primeInt == 105){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "You look closer at it and notice it looks a little odd.";
                //nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene1Button.SetActive(true);
        }

       else if (primeInt == 106){
                Char1name.text = "YOU";
                Char1speech.text = "Is your rabbit okay?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 107){
         ArtChar1b.SetActive(false);
         ArtChar1e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Karl";
                Char2speech.text = "Oh yeah! Little Dee is just fine.";
				Char3name.text = "";
                Char3speech.text = "";
              //  nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene2Button.SetActive(true);
        }
        else if (primeInt == 108){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "He’s just a little rough around the edges from being dead.";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 109){
                 Char1name.text = "YOU";
                 Char1speech.text = "Your rabbit’s dead!";
                 Char2name.text = "";
                 Char2speech.text = "";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 110){
          ArtChar1e.SetActive(false);
          ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "It’s cool buddy, I’m a necromancer.";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 111){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "Little Dee was only dead for like a week max anyway.";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 112){
                 Char1name.text = "YOU";
                 Char1speech.text = "Oh. That's fine then I guess?";
                 Char2name.text = "";
                 Char2speech.text = "";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 113){
          ArtChar1a.SetActive(false);
          ArtChar1e.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "Yeah! Little Dee’s the best!";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 114){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "He was a gift from my boyfriend actually!";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 115){
                 Char1name.text = "YOU";
                 Char1speech.text = "Ummmm, okay.";
                 Char2name.text = "";
                 Char2speech.text = "";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 116){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "I was just about to go meet him!";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 117){
          ArtChar1e.SetActive(false);
          ArtChar1b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "Do you wanna come with me?";
 				         Char3name.text = "";
                 Char3speech.text = "";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 Choice2a.SetActive(true); // function Choice1aFunct()
                 Choice2b.SetActive(true);
        }
        else if (primeInt == 200){
          ArtChar1d.SetActive(false);
          ArtChar1c.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "Oh, it's not a big deal...";
 				Char3name.text = "";
                 Char3speech.text = "";
                 //gameHandler.AddPlayerStat(1);
         }
        else if (primeInt == 201){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "I’m Karl, the circus resident magician.";
 				Char3name.text = "";
                 Char3speech.text = "";
         }
        else if (primeInt ==202){
          ArtChar1c.SetActive(false);
          ArtChar1a.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "I don’t think I've ever seen you around here before.";
 				Char3name.text = "";
                 Char3speech.text = "";
         }
        else if (primeInt == 203){
                 Char1name.text = "YOU";
                 Char1speech.text = "Yeah, I’m not from here. Just checking out the circus.";
                 Char2name.text = "";
                 Char2speech.text = "";
 				Char3name.text = "";
                 Char3speech.text = "";
                 // Turn off "Next" button, turn on "Choice" buttons
         }
 // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 204){
          ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
 				Char3name.text = "";
                 Char3speech.text = "The rabbit Karl is holding moves.";
         }
        else if (primeInt == 205){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
 				Char3name.text = "";
                 Char3speech.text = "You look closer at it and notice it looks a little odd.";
                 //nextButton.SetActive(false);
                 //allowSpace = false;
                 //NextScene1Button.SetActive(true);
         }

        else if (primeInt == 206){
                 Char1name.text = "YOU";
                 Char1speech.text = "Is your rabbit okay?";
                 Char2name.text = "";
                 Char2speech.text = "";
 				Char3name.text = "";
                 Char3speech.text = "";
         }
        else if (primeInt == 207){
          ArtChar1b.SetActive(false);
          ArtChar1e.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "Oh yeah! Little Dee is just fine.";
 				Char3name.text = "";
                 Char3speech.text = "";
               //  nextButton.SetActive(false);
                 //allowSpace = false;
                 //NextScene2Button.SetActive(true);
         }
         else if (primeInt == 208){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "He’s just a little rough around the edges from being dead.";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 209){
                  Char1name.text = "YOU";
                  Char1speech.text = "Your rabbit’s dead!";
                  Char2name.text = "";
                  Char2speech.text = "";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 210){
           ArtChar1e.SetActive(false);
           ArtChar1a.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "It’s cool buddy, I’m a necromancer.";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 211){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "Little Dee was only dead for like a week max anyway.";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 212){
                  Char1name.text = "YOU";
                  Char1speech.text = "Oh. That's fine then I guess?";
                  Char2name.text = "";
                  Char2speech.text = "";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 213){
           ArtChar1a.SetActive(false);
           ArtChar1e.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "Yeah! Little Dee’s the best!";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 214){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "He was a gift from my boyfriend actually!";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 215){
                  Char1name.text = "YOU";
                  Char1speech.text = "Ummmm, okay.";
                  Char2name.text = "";
                  Char2speech.text = "";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 216){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "I was just about to go meet him!";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 217){
           ArtChar1e.SetActive(false);
           ArtChar1b.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "Anyway, did you need something?";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 218){
                  Char1name.text = "YOU";
                  Char1speech.text = "Yeah, I just wanted to ask you some questions.";
                  Char2name.text = "";
                  Char2speech.text = "";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 219){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "Go ahead.";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 220){
                  Char1name.text = "YOU";
                  Char1speech.text = "Is there anything you can tell me about the Ringmaster?";
                  Char2name.text = "";
                  Char2speech.text = "";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 221){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "Well, I don't really pay attention to him.";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 222){
           ArtChar1b.SetActive(false);
           ArtChar1d.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Karl";
                  Char2speech.text = "However, I have noticed he has a weird obsession with my boyfriend Damien.";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 223){
                  Char1name.text = "YOU";
                  Char1speech.text = "Interesting, thank you.";
                  Char2name.text = "";
                  Char2speech.text = "";
  				         Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 224){
           ArtChar1d.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
  				         Char3name.text = "";
                  Char3speech.text = "You decide to go back to the main tent.";
                  nextButton.SetActive(false);
                  allowSpace = false;
                  NextScene1Button.SetActive(true);
         }
        else if (primeInt == 300){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "Go ahead.";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 301){
                 Char1name.text = "YOU";
                 Char1speech.text = "Is there anything you can tell me about the Ringmaster?";
                 Char2name.text = "";
                 Char2speech.text = "";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 302){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "Well, I don't really pay attention to him.";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 303){
          ArtChar1b.SetActive(false);
          ArtChar1d.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Karl";
                 Char2speech.text = "However, I have noticed he has a weird obsession with my boyfriend Damien.";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 304){
                 Char1name.text = "YOU";
                 Char1speech.text = "Interesting, thank you.";
                 Char2name.text = "";
                 Char2speech.text = "";
 				         Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 305){
          ArtChar1d.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
 				         Char3name.text = "";
                 Char3speech.text = "You decide to go back to the main tent.";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 NextScene1Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Oh jeez I’m so sorry.";
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
                Char1speech.text = "Hey man, don't be a jerk.";
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
        public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "No thanks, I actually wanted to ask you some questions";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Sure, why not.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene0");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3d");
        }
}
