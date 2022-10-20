using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2cDialogue : MonoBehaviour {
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
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text= "";
                Char3speech.text = "You decide to investigate the barrel to see what noises are coming from it.";
        }
		        else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text= "";
                Char3speech.text = "As you lift the top you see a small decomposing girl staring at you.";
		}

       else if (primeInt ==4){
                Char1name.text = "Maggie";
                Char1speech.text = "Oh, thank goodness someone heard me! I've been stuck in this barrel for god knows how long!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
		// Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
	   }
	   
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
				Char3speech.text = "You jump backward, shocked that a literal dead body is speaking to you.";
		}
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "Ummm.. so, like, that's just makeup, right?";
                Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
				Char3speech.text = "Maggie looks at you confused and begins to shake the barrel.";
		}
       else if (primeInt ==8){
                Char1name.text = "Maggie";
                Char1speech.text = "I don't know what you're talking about but now that you're here, get me out of this darn barrel! It's stuffy and uncomfortable!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You decide to help her see if she might give you some more information on the circus.";
		}
       else if (primeInt ==10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "Yeah! No problem lemme just…. Hmmm... You're really stuck in there?";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You start digging around in the barrel to try and grab the girl to lift her out.";
		}
       else if (primeInt ==12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "OH! I think I've got you here just a second and….. Here we go!";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You lift up what you think will be the little girl but is, in fact, just her arm separate from her body.";
		}
       else if (primeInt ==14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "OH JESUS CHRIST!";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==15){
                Char1name.text = "Maggie";
                Char1speech.text = "HEY! That's Maggies give it back!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "AH! Here!";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You toss the arm back in the barrel.";
		}
       else if (primeInt ==18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "Who’s Maggie?";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==19){
                Char1name.text = "Maggie";
                Char1speech.text = "I am you dimwit!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "She says as she uses her separated arm to climb out of the barrel.";
		}
       else if (primeInt ==21){
                Char1name.text = "Maggie";
                Char1speech.text = "I should still thank you for helping me, even though I did most of the work.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "She gives you a cheeky grin.";
		}
       else if (primeInt ==23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "I was actually wondering if you knew anything about this circus.";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "She looks at you confused";
		}
       else if (primeInt ==25){
                Char1name.text = "Maggie";
                Char1speech.text = "What's there to know? It's a circus, and people come here to have fun!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==26){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "Yeah, I got that part, but like, why are people here I thought it was supposed to be abandoned.";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==27){
                Char1name.text = "Maggie";
                Char1speech.text = "Abandoned? What are you talking about, we were just performing yesterday. Huge crowds, tons of people, the works, ya know?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==28){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You look at her closely and finally realize that she really is a corpse, no props, no makeup, just rotting flesh.";
		}
       else if (primeInt ==29){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "O-okay, sure.";
				Char3name.text = "";
				Char3speech.text = "";
		}
       else if (primeInt ==30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You slowly start backing away.";
        }
       else if (primeInt == 31){
                Char1name.text = "Maggie";
                Char1speech.text = "I can point you in the direction of some of my other friends who also perform here, they're hilarious!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You spin and look away from the barrel";
        }
		else if (primeInt == 101){
                Char1name.text = "Maggie";
                Char1speech.text = "What do you mean? Are you going to help me out?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You lean toward the barrel a bit but wince at the smell coming from the barrel.";
        }
		else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "Are you kidding? You smell like a rotting corpse!";
				Char3name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 104){
                Char1name.text = "Maggie";
                Char1speech.text = "Well that's because I am one DUH!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 105){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "It seems you have offended her and she begins shaking the barrel she is stuck in";
        }
		else if (primeInt == 106){
                Char1name.text = "Maggie";
                Char1speech.text = "Wow some people these days! You see a kind sweet young girl stuck in a barrel, which was completely not her fault, and don't even bother to help her! ";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 107){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "She begins ranting so furiously that you can't seem to get a word in.";
        }
		else if (primeInt == 108){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "Well anyways, I have some questions-";
				Char3name.text = "";
				Char3speech.text = "";
        }
		
		else if (primeInt == 109){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You're cut off by a disembodied arm whacking you in the head";
        }
		
		else if (primeInt == 110){
                Char1name.text = "Maggie";
                Char1speech.text = "You think I'll answer a question after you won't even help me! Pfft as if!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		
		else if (primeInt == 111){
                Char1name.text = "Maggie";
                Char1speech.text = "I CAN GET OUT ALL BY MYSELF!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
		
		else if (primeInt == 112){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "You look down at the ground where the arm fell but by the time you pick it up to return it to the girl she has tipped the barrel over and rolled off into the circus.";
        }
       else if (primeInt == 113){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "Well that was weird.";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "Jeda";
                Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Player";
                Char2speech.text = "Oh, hell no.";
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
                Char2name.text = "You";
                Char2speech.text = "Sure, anything you want... just lay off the club.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene0");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene0");
        }
}
