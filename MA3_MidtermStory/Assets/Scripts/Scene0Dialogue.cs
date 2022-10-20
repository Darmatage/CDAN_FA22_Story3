using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene0Dialogue : MonoBehaviour {
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
		public GameObject NextScene5Button;
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
		NextScene5Button.SetActive(false);
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
                Char3speech.text = "You’re back outside.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char1speech.text = "";
				
				if (GameHandler.lastScene=="Scene2a"){primeInt=9;}
				if (GameHandler.lastScene=="Scene2b"){primeInt=19;}
				if (GameHandler.lastScene=="Scene2c"){primeInt=29;}
				if (GameHandler.lastScene=="Scene2d"){primeInt=39;}
				
        }
		
		
        else if (primeInt == 10){
               ArtChar1.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char3speech.text = "Once you’re back outside, you feel a sense of accomplishment wash over you.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char1speech.text = "";
        }
        else if (primeInt ==11){
                 Char1name.text = "";
                 Char3speech.text = "The pieces are starting to fall together slowly, one by one.";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt ==12){
                 Char1name.text = "";
                 Char3speech.text = "But you’re not done yet.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
        else if (primeInt ==13){
                 Char1name.text = "";
                 Char3speech.text = "You take a look around again, scratching your head as you try to figure out where to go next.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
       else if (primeInt ==14){
                Char1name.text = "";
                Char3speech.text = "You take a look around again, scratching your head as you try to figure out where to go next.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
				if (GameHandler.sawTent==false){NextScene1Button.SetActive(true);}
				if (GameHandler.sawHotLady==false){NextScene2Button.SetActive(true);}
				if (GameHandler.sawBarrel==false){NextScene3Button.SetActive(true);}
				if (GameHandler.sawRabbit==false){NextScene4Button.SetActive(true);}
				
				if ((GameHandler.sawTent) && (GameHandler.sawHotLady) && (GameHandler.sawBarrel) && (GameHandler.sawRabbit)){
					NextScene5Button.SetActive(true);
				}
        }
		
		
	    else if (primeInt ==20){
                 Char1name.text = "";
                 Char3speech.text = "Holy cow, that lady was hot.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
       else if (primeInt ==21){
                Char1name.text = "";
                Char3speech.text = "(Hot lady)You take a look around again, scratching your head as you try to figure out where to go next.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
				if (GameHandler.sawTent==false){NextScene1Button.SetActive(true);}
				if (GameHandler.sawHotLady==false){NextScene2Button.SetActive(true);}
				if (GameHandler.sawBarrel==false){NextScene3Button.SetActive(true);}
				if (GameHandler.sawRabbit==false){NextScene4Button.SetActive(true);}
				
				if ((GameHandler.sawTent) && (GameHandler.sawHotLady) && (GameHandler.sawBarrel) && (GameHandler.sawRabbit)){
					NextScene5Button.SetActive(true);
				}
        }	
		
		
		else if (primeInt ==30){
                 Char1name.text = "";
                 Char3speech.text = "Yikes, that barrel smelled.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
       else if (primeInt ==31){
                Char1name.text = "";
                Char3speech.text = "(Barrel)You take a look around again, scratching your head as you try to figure out where to go next.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
				if (GameHandler.sawTent==false){NextScene1Button.SetActive(true);}
				if (GameHandler.sawHotLady==false){NextScene2Button.SetActive(true);}
				if (GameHandler.sawBarrel==false){NextScene3Button.SetActive(true);}
				if (GameHandler.sawRabbit==false){NextScene4Button.SetActive(true);}
				
				if ((GameHandler.sawTent) && (GameHandler.sawHotLady) && (GameHandler.sawBarrel) && (GameHandler.sawRabbit)){
					NextScene5Button.SetActive(true);
				}
        }
		
		
		else if (primeInt ==40){
                 Char1name.text = "";
                 Char3speech.text = "Yowza, that rabbit was hot.";
                 Char2name.text = "";
                 Char2speech.text = "";
        }
       else if (primeInt ==41){
                Char1name.text = "";
                Char3speech.text = "(Rabbit) You take a look around again, scratching your head as you try to figure out where to go next.";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
				if (GameHandler.sawTent==false){NextScene1Button.SetActive(true);}
				if (GameHandler.sawHotLady==false){NextScene2Button.SetActive(true);}
				if (GameHandler.sawBarrel==false){NextScene3Button.SetActive(true);}
				if (GameHandler.sawRabbit==false){NextScene4Button.SetActive(true);}
				
				if ((GameHandler.sawTent) && (GameHandler.sawHotLady) && (GameHandler.sawBarrel) && (GameHandler.sawRabbit)){
					NextScene5Button.SetActive(true);
				}
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
		
		public void SceneChange5(){
			if (GameHandler.helpedZombie){
                SceneManager.LoadScene("Scene3e");
			}
			else {SceneManager.LoadScene("Scene3f");}
        }
		
		
}
