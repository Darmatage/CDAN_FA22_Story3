using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4aDialogue : MonoBehaviour {
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
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(false);
        ArtBG2.SetActive(true);
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
               ArtChar1.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
				Char3speech.text = "You look down at the whip and back at the ringmaster.";
		}
		else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
				Char3speech.text = "You think to yourself that you can't win another fight at this rate.";
		}
		else if (primeInt == 4){
      ArtBG1.SetActive(true);
      ArtBG2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
				Char3speech.text = "With your remaining breath, you sprint out of the tent.";
		}
       else if (primeInt ==5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "I think I lost them, lemme hide behind this booth to catch my breath.";
                Char3name.text = "";
				Char3speech.text = "";
				//gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
         ArtChar1.SetActive(true);
                Char1name.text = "Ringmaster";
                Char1speech.text = "Oh, how foolish can you be, outsider?";
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
				Char3speech.text = "Before you even get a breath, the Ringmaster is looming over you from the other side of the booth.";
				//gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "They crack their whip around your neck once again and yank you up to eye level.";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "Let go of me, you freak!";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==10){
                Char1name.text = "Ringmaster";
                Char1speech.text = "Awe, how rude.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		      else if (primeInt ==11){
                Char1name.text = "Ringmaster";
                Char1speech.text = "I'm no freak, but you wouldn't know that because we haven't even properly gotten to know each other.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt ==12){
                Char1name.text = "Ringmaster";
                Char1speech.text = "Well, not yet…";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
				Char3speech.text = "Your vision goes dark as you lose consciousness";
				// Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
			allowSpace = false;
			NextScene1Button.SetActive(true);

        }
// ENCOUNTER AFTER CHOICE #1


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
               SceneManager.LoadScene("End_Lose");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}
