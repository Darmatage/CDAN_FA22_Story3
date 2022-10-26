using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       public Text Char3name;
       public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject ArtChar2;
        public GameObject ArtChar3;
        public GameObject ArtChar4;
        public GameObject ArtChar5;
        public GameObject ArtBG1;
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
        ArtChar1.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtChar5.SetActive(false);
        ArtBG1.SetActive(true);
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
               ArtChar1.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char3name.text = "";
                Char3speech.text = "You head towards the large tent where you heard the growl.";
                Char2name.text = "";
                Char2speech.text = "";
                Char1name.text = "";
                Char1speech.text = "";

				GameHandler.sawTent=true;
        }
        else if (primeInt == 3){
                        StartCoroutine(FadeIn(ArtChar1));
                       ArtChar1.SetActive(true);
                        DialogueDisplay.SetActive(true);
                        Char3name.text = "";
                        Char3speech.text = "When you go inside you see a strange semi-translucent tiger.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char1name.text = "";
                        Char1speech.text = "";
        }
        else if (primeInt == 4){
                       ArtChar1.SetActive(true);
                        DialogueDisplay.SetActive(true);
                        Char3name.text = "";
                        Char3speech.text = "He is wearing a collar with the name Rhubarb.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char1name.text = "";
                        Char1speech.text = "";
        }
       else if (primeInt ==5){
                Char1name.text = "YOU";
                Char1speech.text = "Ah, hello? Would you mind if I asked you some questions?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                ArtChar1.SetActive(false);
                ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "The tiger looks at you blankly for a long moment.";
        }
       else if (primeInt == 7){
                Char1name.text = "YOU";
                Char1speech.text = "…Rhubarb? That's your name right?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Rhubarb";
                Char2speech.text = "Mrow.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "The tigers “meow” is some deeply pitched; it sounds more like a whale than a cat.";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
       else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "Um, how long have you been a part of the circus, Rhubarb?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
        }
       else if (primeInt == 101){
                ArtChar1.SetActive(true);
                ArtChar2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Rhubarb chuffs back at you.";
                //nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene1Button.SetActive(true);
        }
        else if (primeInt == 102){
                 Char1name.text = "YOU";
                 Char1speech.text = "Uh huh. And how long has the circus been… run down like this?";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 103){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Rhubarb";
                 Char2speech.text = "Mrrow mrrroooooww.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 104){
                 Char1name.text = "YOU";
                 Char1speech.text = "Interesting. Can you tell me anything about the other people that work here?";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 105){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Rhubarb";
                 Char2speech.text = "Mrroow.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 106){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Rhubarb walks closer to you, putting himself within reach of you.";
        }
        else if (primeInt == 107){
                 Char1name.text = "YOU";
                 Char1speech.text = "What about the Ringmaster?";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 108){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Rhubarb lays down at your feet.";
        }
        else if (primeInt == 109){
                 Char1name.text = "YOU";
                 Char1speech.text = "Ummmmm...";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 110){
                 ArtChar1.SetActive(false);
                 ArtChar3.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Rhubarb rolls over, looking up at you with big pleading eyes.";
        }
        else if (primeInt == 111){
                 Char1name.text = "YOU";
                 Char1speech.text = "Do you want me to, to pet you?";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 112){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Rhubarb";
                 Char2speech.text = "Mrrrowwwwwhhh.";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
        else if (primeInt == 113){
                 Char1name.text = "YOU";
                 Char1speech.text = "Ummmmm...";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
       else if (primeInt == 114){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Rhubarb wiggles, showing you his soft, very petable stomach.";
         }
        else if (primeInt == 115){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Which of course is attached to very large claws, and next to a powerful jaw with humongous teeth.";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice1aFunct()
        }
        else if (primeInt == 200){
                 Char1name.text = "YOU";
                 Char1speech.text = "Um, how long have you been a part of the circus, Rhubarb?";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                 // Turn off "Next" button, turn on "Choice" buttons
         }
        else if (primeInt == 201){
                 ArtChar1.SetActive(true);
                 ArtChar2.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Rhubarb chuffs back at you.";
                 //nextButton.SetActive(false);
                 //allowSpace = false;
                 //NextScene1Button.SetActive(true);
         }
         else if (primeInt == 202){
                  Char1name.text = "YOU";
                  Char1speech.text = "Uh huh. And how long has the circus been… run down like this?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 203){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Rhubarb";
                  Char2speech.text = "Mrrow mrrroooooww.";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 204){
                  Char1name.text = "YOU";
                  Char1speech.text = "Interesting. Can you tell me anything about the other people that work here?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 205){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Rhubarb";
                  Char2speech.text = "Mrroow.";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 206){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "Rhubarb walks closer to you, putting himself within reach of you.";
         }
         else if (primeInt == 207){
                  Char1name.text = "YOU";
                  Char1speech.text = "What about the Ringmaster?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 208){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "Rhubarb lays down at your feet.";
         }
         else if (primeInt == 209){
                  Char1name.text = "YOU";
                  Char1speech.text = "Ummmmm...";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 210){
                  ArtChar1.SetActive(false);
                  ArtChar3.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "Rhubarb rolls over, looking up at you with big pleading eyes.";
         }
         else if (primeInt == 211){
                  Char1name.text = "YOU";
                  Char1speech.text = "Do you want me to, to pet you?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 212){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Rhubarb";
                  Char2speech.text = "Mrrrowwwwwhhh.";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 213){
                  Char1name.text = "YOU";
                  Char1speech.text = "Ummmmm...";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
        else if (primeInt == 214){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Rhubarb wiggles, showing you his soft, very petable stomach.";
        }
        else if (primeInt == 215){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Which of course is attached to very large claws, and next to a powerful jaw with humongous teeth.";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 Choice2a.SetActive(true); // function Choice1aFunct()
                 Choice2b.SetActive(true);
         }
         else if (primeInt == 300){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "You stay strong in the face of Rhubarb and don’t pet him.";
         }
         else if (primeInt == 301){
                  Char1name.text = "YOU";
                  Char1speech.text = "Is there anything you can tell me about what happened here?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 302){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "Unhappy with your lack of compliance, Rhubarb gets up.";
         }
         else if (primeInt == 303){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Rhubarb";
                  Char2speech.text = "Stupid human, I’m a tiger. What answer do you expect from me?";
                  Char3name.text = "";
                  Char3speech.text = "";
         }
         else if (primeInt == 304){
            StartCoroutine(FadeOut(ArtChar3));
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "With that he stalks off, growling, before you are able to shake off the stupor of hearing the tiger speak.";
         }
         else if (primeInt == 305){
           ArtChar3.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "You decide to go back to the first tent.";
                  nextButton.SetActive(false);
                  allowSpace = false;
                  NextScene1Button.SetActive(true);
          }
         else if (primeInt == 400){
                  ArtChar3.SetActive(false);
                  ArtChar5.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "His tummy is indeed very soft, and luckily none of his very pointy bits get anywhere near your delicate human flesh.";
         }
         else if (primeInt == 401){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "He starts purring, a loud, horrible sound that reminds you of a stalling car.";
         }
         else if (primeInt == 402){
           StartCoroutine(FadeOut(ArtChar5));
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "Eventually, he has his fill and wanders off.";
         }
         else if (primeInt == 403){
           ArtChar5.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "You didn’t learn anything from Rhubarb, however you get the feeling he likes you.";
         }
         else if (primeInt == 404){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "You decide to return to the main area of the circus to further your investigation.";
                  nextButton.SetActive(false);
                  allowSpace = false;
                  NextScene2Button.SetActive(true);
         }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Damn, a cat. I hate cats.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Kitty!!!!!!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2aFunct(){
                Char1name.text = "";
                Char3speech.text = "You decide to continue questioning Rhubarb.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char1speech.text = "";
                primeInt = 299;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "You give in to the cuteness and pet Rhubarb.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 399;
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene0");
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
