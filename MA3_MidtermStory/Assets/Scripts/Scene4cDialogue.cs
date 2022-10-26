using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4cDialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name; // player
        public Text Char1speech;
        public Text Char2name; // ringmaster
        public Text Char2speech;
        public Text Char3name; // narrator
        public Text Char3speech;
        public Text Char4name; // beatrice
        public Text Char4speech;
        public Text Char5name; // karl
        public Text Char5speech;
        public Text Char6name; // maggie
        public Text Char6speech;
        public Text Char7name; // rhubarb
        public Text Char7speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar3a;
        public GameObject ArtChar3b;
        public GameObject ArtChar4a;
        public GameObject ArtChar5a;
        public GameObject ArtChar5b;
        public GameObject ArtChar5c;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject Choice1d;
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
        ArtChar2a.SetActive(false);
        ArtChar2b.SetActive(false);
        ArtChar3a.SetActive(false);
        ArtChar3b.SetActive(false);
        ArtChar4a.SetActive(false);
        ArtChar5a.SetActive(false);
        ArtChar5b.SetActive(false);
        ArtChar5c.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice1d.SetActive(false);
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
          ArtChar1c.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "With the whip in your hand, your gaze flickers between the Ringmaster and the whip.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==3){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "YOU";
                Char1speech.text = "I won’t let you hurt anyone ever again.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 5){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You raise the whip over your head, staring down at the Ringmaster; who looks utterly furious at your mercy.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "But just as you’re about to slam it down, you hesitate.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Could you really take another life? ";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Even if it was someone like them, it didn’t feel right.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "In that moment of hesitation, the Ringmaster sees their opportunity.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Like a snake, their arm reaches out and grabs the end of the whip, retching it out of your hand.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "But they don’t intend to use it.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Instead, they toss it the other direction and basically tackle you to the ground. \nThere’s a passionate hatred in their eyes.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Weak! Pathetic! Miserable! Pitiful!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "They wail, pulling a dagger out of nowhere and raising it over their head.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt ==14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Righteous little hero, aren’t you?";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 15){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }

//CONVERGENCE #1

       else if (primeInt ==30){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(false);
         ArtChar4a.SetActive(false);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "The Ringmaster plunges the dagger into your chest.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "If only there had been someone to save you...";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
               nextButton.SetActive(false);
               allowSpace = false;
               NextScene1Button.SetActive(true);
       }

// ENCOUNTER AFTER CHOICE #1A
       else if (primeInt == 100){
                Char1name.text = "YOU";
                Char1speech.text = "You were supposed to protect them!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 101){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Having heard enough, the Ringmaster brings the dagger down.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "But you manage to stop it before it pierces your chest, gripping the blade with your hands.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You can feel the blood run down from your palms, but you don’t care.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 104){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "You’re such…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 105){
                Char1name.text = "YOU";
                Char1speech.text = "…a selfish…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 106){
                Char1name.text = "YOU";
                Char1speech.text = "…unforgivable…";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 107){
                Char1name.text = "YOU";
                Char1speech.text = "…piece of shit!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 108){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You push the dagger back just slightly, but the awful stinging in your hands is starting to get to you.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
              primeInt = 29;
        }

//ENCOUNTER AFTER CHOICE #1B

       else if (primeInt == 200){
                Char1name.text = "YOU";
                Char1speech.text = "Just let me go!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 201){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "No can do. \nYou’ve seen too much.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 202){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I won’t tell a soul, I swear!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 203){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You can see that there’s no changing their mind, as they swing the dagger down towards you.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 204){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Instinctively, you put your hands up in defense.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 205){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Just before the blade reaches your chest, you grab the blade of the dagger with one hand and squeeze.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 206){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Crap.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 207){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "There’s blood dripping down your arm now.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 208){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "What do you gain from killing me?!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 209){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Your eternal silence.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
       else if (primeInt == 210){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "And satisfaction.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
              primeInt = 29;
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I’m trying to save the people you hurt, you monster!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Please! \nI’ll do anything!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){
          ArtChar5a.SetActive(false);
          ArtChar5b.SetActive(true);
          ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You gently pet Rhubarb’s head one last time, scratching behind his ear.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
                primeInt = 299;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1dFunct(){
          ArtChar5a.SetActive(true);
          ArtChar5b.SetActive(false);
          ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You know you’ll probably start crying if you decide to pet him one last time.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
                primeInt = 399;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("End_Lose");
        }
}
