using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;	//player
        public Text Char1speech;
        public Text Char2name;	//ringmaster
        public Text Char2speech;
       public Text Char3name;	//narrator
       public Text Char3speech;
	   public Text Char4name;	//Damien
       public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a; //ringmaster
		public GameObject ArtChar1b;
		public GameObject ArtChar1c;
		public GameObject ArtChar1d;
		//public GameObject ArtChar1e;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
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
        ArtChar1a.SetActive(false);
		    ArtChar1b.SetActive(false);
    		ArtChar1c.SetActive(false);
		    ArtChar1d.SetActive(false);
		//ArtChar1e.SetActive(false);
        ArtBG1.SetActive(false);
        ArtBG2.SetActive(false);
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

                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "After a few hours of surfing the internet, \nyou come across a strange site.";
				Char4name.text = "";
                Char4speech.text = "";
        }
	    else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "It lists the location of a nearby abandoned circus, often visited by rowdy teens who spout ghost stories about the place.";
        }
	    else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "Having nothing better to do, you decide to drive out to this place and see if the rumors are true.";
        }
       else if (primeInt == 5){
         StartCoroutine(FadeIn(ArtBG1));
              ArtBG1.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "At least the circus is actually here.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Wow...being neglected for a century really took its toll on this place.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "You enter through a tall gate, its sign half-torn.";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "You can barely make out the letters on the sign: The Phantom Circus.";
        }
       else if (primeInt == 9){
         ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "A dilapidated tent stands in the distance, \nbarely held up by the ropes latching it to the ground.";
        }
       else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "Many smaller tents are scattered around, as well as stalls.";
        }
       else if (primeInt == 11){
         ArtChar1a.SetActive(true);
 		    ArtChar1b.SetActive(false);
     		ArtChar1c.SetActive(false);
 		    ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Well, well, look what the clown dragged in!";
				Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "Out of nowhere, a loud voice greets you.";
        }
       else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "A figure makes themselves known from behind one of the stalls, sporting a hat too big for their head and dressed in fancy clothing.";
        }
       else if (primeInt == 14){
         ArtChar1a.SetActive(false);
 		    ArtChar1b.SetActive(false);
     		ArtChar1c.SetActive(true);
 		    ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "They flash a big smile, taking your hand in one of theirs and shaking it – too much.";
        }

       else if (primeInt == 15){
         ArtChar1a.SetActive(false);
 		    ArtChar1b.SetActive(false);
     		ArtChar1c.SetActive(false);
 		    ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Ah, hello!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "You’re caught off guard by the eccentric nature of this person, and left with questions.";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct(): Who are you?
                Choice1b.SetActive(true); // function Choice1bFunct(): Are you cosplaying or something?
        }

// CONVERGENCE AFTER CHOICES #1

        else if (primeInt == 25){
			ArtChar1a.SetActive(false);
      ArtChar1b.SetActive(false);
      ArtChar1c.SetActive(true);
      ArtChar1d.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "They seem to ignore that response, instead moving on with that same enthusiasm from before.";
        }
        else if (primeInt == 26){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Anywho, you’re at the Faire Mystico! A fine place for anyone looking for a getaway from the monotonous reality we are all subject to!";
				Char3name.text = "";
                Char3speech.text = "";
		}
        else if (primeInt == 27){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "They swing on their heel, now beside you as they wrap an arm around your shoulder and gesture to… what used to be the circus.";
        }
        else if (primeInt == 28){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Don’t be shy, my carnies and I are just ecstatic to show you just what we can do! I’m sure you’ll love each and every act!";
				Char3name.text = "";
                Char3speech.text = "";
		}
        else if (primeInt == 29){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "You’re unsure whether or not to mention the fact that the circus is literally abandoned, but decide to keep your mouth shut.";
        }
        else if (primeInt == 30){
          ArtChar1a.SetActive(false);
  		    ArtChar1b.SetActive(false);
      		ArtChar1c.SetActive(false);
  		    ArtChar1d.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "Okay…so, I had some questions about this place–";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }

		else if (primeInt == 31){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "???";
                Char4speech.text = "AAAAAAAAAAAAH-!";
        }

        else if (primeInt == 32){
          ArtChar1a.SetActive(false);
  		    ArtChar1b.SetActive(true);
      		ArtChar1c.SetActive(false);
  		    ArtChar1d.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "The one-sided conversation is cut short by a…scream?";
				Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 33){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "Whatever it is, it’s deep, and sounds like it came from the forest just beyond the circus tent.";
        }
        else if (primeInt == 34){
          ArtChar1a.SetActive(false);
  		    ArtChar1b.SetActive(false);
      		ArtChar1c.SetActive(false);
  		    ArtChar1d.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "Out of the corner of your eye, you see the Ringmaster’s pleasant grin drop for a few seconds, replaced by a scowl.";
        }
        else if (primeInt == 35){
          ArtChar1a.SetActive(false);
  		    ArtChar1b.SetActive(false);
      		ArtChar1c.SetActive(true);
  		    ArtChar1d.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "They quickly bring their act together and swing around again in front of you.";
        }
        else if (primeInt == 36){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "Ah, destiny calls! Don’t move a muscle, I’ll be right back to give you a grand old tour!";
				 Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 37){
          ArtChar1a.SetActive(false);
  		    ArtChar1b.SetActive(false);
      		ArtChar1c.SetActive(false);
  		    ArtChar1d.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "And just like that, they’re gone.";
        }
        else if (primeInt == 38){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "For a few minutes you do stay put, but after five minutes go by, and then ten, you decide to stop sitting around.";
        }
        else if (primeInt == 39){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "As you head deeper into the area, several curious things seem to happen all at once.";
        }
        else if (primeInt == 40){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "A strange noise comes from one of the larger tents, akin to a tiger’s growl.";
        }
        else if (primeInt == 41){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "An unnaturally tall woman heading inside one of the abandoned dressing rooms in the distance.";
        }
        else if (primeInt == 42){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "A considerably large barrel off to the side of the main tent, and muffled noises coming from within it.";
        }
        else if (primeInt == 43){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "And a small bunny, just staring at you from a few feet away.";
        }
        else if (primeInt == 44){
                 Char1name.text = "YOU";
                 Char1speech.text = "Huh.";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
                 nextButton.SetActive(false);
                 allowSpace = false;
                 NextScene1Button.SetActive(true);
                 NextScene2Button.SetActive(true);
                 NextScene3Button.SetActive(true);
                 NextScene4Button.SetActive(true);
        }


// ENCOUNTER AFTER CHOICE #1a
   else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "Um...nice to meet you, er–";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 101){
		   		ArtChar1a.SetActive(false);
				ArtChar1b.SetActive(true);
				ArtChar1c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Just call me The Ringmaster!";
				Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 102){
                 Char1name.text = "YOU";
                 Char1speech.text = "...right. What about...your actual name?";
                 Char2name.text = "";
                 Char2speech.text = "";
 				Char3name.text = "";
                 Char3speech.text = "";
         }
         else if (primeInt == 103){
            ArtChar1a.SetActive(false);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Ringmaster";
                  Char2speech.text = "Haha, I just told you!";
          Char3name.text = "";
                  Char3speech.text = "";
          }
		else if (primeInt == 104){
      ArtChar1a.SetActive(false);
      ArtChar1b.SetActive(false);
      ArtChar1c.SetActive(false);
      ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "This is a weird, mysterious act you're putting on.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				primeInt = 24;
        }


// ENCOUNTER AFTER CHOICE #1b
       else if (primeInt == 200){
         ArtChar1a.SetActive(false);
 		    ArtChar1b.SetActive(false);
     		ArtChar1c.SetActive(false);
 		    ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "So, uh, are you cosplaying or something?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "YOU";
                Char1speech.text = "I wasn’t really expecting anyone else here, especially this late at night…";
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
                 Char2name.text = "";
                 Char2speech.text = "";
 				Char3name.text = "";
                 Char3speech.text = "The Ringmaster gives you a quizzical look, their only response a slight shrug of their shoulders.";
         }
       else if (primeInt == 203){
         ArtChar1a.SetActive(false);
 		    ArtChar1b.SetActive(true);
     		ArtChar1c.SetActive(false);
 		    ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "‘Cosplaying?’ What a peculiar term.";
				Char3name.text = "";
                Char3speech.text = "";
                //nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene2Button.SetActive(true);
        }
        else if (primeInt == 204){
          ArtChar1a.SetActive(false);
  		    ArtChar1b.SetActive(false);
      		ArtChar1c.SetActive(false);
  		    ArtChar1d.SetActive(false);
			ArtChar1a.SetActive(false);
			ArtChar1b.SetActive(true);
			ArtChar1c.SetActive(false);
                 Char1name.text = "YOU";
                 Char1speech.text = "Not really answering my question, you know.";
                 Char2name.text = "";
                 Char2speech.text = "";
				 Char3name.text = "";
                Char3speech.text = "";
				primeInt = 24;
        }


     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
          ArtChar1a.SetActive(false);
  		    ArtChar1b.SetActive(false);
      		ArtChar1c.SetActive(false);
  		    ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Please let go of my hand...thanks.";
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
          ArtChar1a.SetActive(false);
  		    ArtChar1b.SetActive(false);
      		ArtChar1c.SetActive(false);
  		    ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Nice hat.";
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
