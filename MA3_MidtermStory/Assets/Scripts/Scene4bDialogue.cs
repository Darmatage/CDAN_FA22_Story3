using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour {
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
        public AudioSource SFXClip1;
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
                Char3speech.text = "And just as they’re about to plunge the dagger into your chest, an ear-deafening roar echoes in the distance.";
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
                Char3speech.text = "A massive, furry body pounces on the Ringmaster, pinning them to the ground.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==32){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You also see a disembodied arm fly over you, and a ‘bonk’ sound as the Ringmaster groans from the impact.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==33){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(true);
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
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "Karl";
                Char5speech.text = "Woah! Hey, you okay?";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==34){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(true);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(true);
         ArtChar4a.SetActive(true);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Three familiar faces hover above you, concern written across each of them.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==35){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(false);
         ArtChar4a.SetActive(true);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You feel Maggie help you up, all collectively ignoring the carnage in the background.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==36){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(false);
         ArtChar4a.SetActive(false);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(true);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Yep, that was definitely Rhubarb mauling the Ringmaster.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==37){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(false);
         ArtChar4a.SetActive(true);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "Maggie";
                Char6speech.text = "We heard cracks and lots of horrible noises coming from here!";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==38){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "Maggie";
                Char6speech.text = "We were all so worried, but we’re glad you’re alive!";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==39){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(true);
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
                Char3speech.text = "";
                Char4name.text = "Beatrice";
                Char4speech.text = "Look at your injuries, sweetheart.";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==40){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(true);
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
                Char3speech.text = "";
                Char4name.text = "Beatrice";
                Char4speech.text = "Let me take care of that for you.";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==41){
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
                Char1name.text = "YOU";
                Char1speech.text = "Thanks… I’m really glad you guys got to me in time.";
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
       else if (primeInt ==42){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(false);
         ArtChar4a.SetActive(false);
         ArtChar5a.SetActive(true);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "A loud crunch fills the air, and everyone’s heads turn towards Rhubarb.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==43){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(false);
         ArtChar4a.SetActive(false);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(true);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "The tiger is currently gnawing on a bone, but leaves the crime scene as he notices your gaze.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==44){
         SFXClip1.Play();
                Char1name.text = "";
                Char1speech.text = "";
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
                Char7name.text = "Rhubarb";
                Char7speech.text = "-Purr-";
       }
       else if (primeInt ==45){
         SFXClip1.Stop();
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "He gently butts his head against your side, and you elect to ignore the blood stains on his fur as you give him a good ol’ head scritch.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==46){
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
                Char1name.text = "YOU";
                Char1speech.text = "I’m just glad I was able to help. \nI hope that every one of you can rest peacefully now.";
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
       else if (primeInt ==47){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(false);
         ArtChar4a.SetActive(true);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "Maggie";
                Char6speech.text = "Thank goodness! It’s been ages since I last slept for real!";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==48){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(true);
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
                Char3speech.text = "";
                Char4name.text = "Beatrice";
                Char4speech.text = "You’ve been a tremendous help. Thank you, dear.";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==49){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(true);
         ArtChar4a.SetActive(false);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "Karl";
                Char5speech.text = "Yeah, we’re all grateful! We didn’t know you for very long, but you’re amazing.";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==50){
         SFXClip1.Play();
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(false);
         ArtChar4a.SetActive(false);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(true);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
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
                Char7name.text = "Rhubarb";
                Char7speech.text = "-More purrs-";
       }
       else if (primeInt ==51){
         SFXClip1.Stop();
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You nod, watching as each of them turn to walk out of the tent.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==52){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(true);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(true);
         ArtChar4a.SetActive(true);
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "First Beatrice and Maggie, and then Karl.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt ==53){
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
         ArtChar5c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "From beside you, you hear a low whine.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
       }
       else if (primeInt == 54){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar2a.SetActive(false);
         ArtChar2b.SetActive(false);
         ArtChar3a.SetActive(false);
         ArtChar3b.SetActive(false);
         ArtChar4a.SetActive(false);
         ArtChar5a.SetActive(true);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You turn to see Rhubarb staring at you with wide eyes.";
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
                Choice1c.SetActive(true); // function Choice1aFunct()
                Choice1d.SetActive(true); // function Choice1bFunct()
       }

//CONVERGENCE #2

      else if (primeInt ==60){
        ArtChar5a.SetActive(false);
        ArtChar5b.SetActive(false);
        ArtChar5c.SetActive(false);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "";
               Char3speech.text = "You glance back at the body of the Ringmaster, a bit of sympathy in your expression.";
               Char4name.text = "";
               Char4speech.text = "";
               Char5name.text = "";
               Char5speech.text = "";
               Char6name.text = "";
               Char6speech.text = "";
               Char7name.text = "";
               Char7speech.text = "";
       }
       else if (primeInt ==61){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Perhaps there could have been a better way to end things.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
        else if (primeInt ==62){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "Oh well.";
                 Char4name.text = "";
                 Char4speech.text = "";
                 Char5name.text = "";
                 Char5speech.text = "";
                 Char6name.text = "";
                 Char6speech.text = "";
                 Char7name.text = "";
                 Char7speech.text = "";
         }
         else if (primeInt ==63){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "You are the last one out of the tent, and you blink as you realize you’re standing in an empty field.";
                  Char4name.text = "";
                  Char4speech.text = "";
                  Char5name.text = "";
                  Char5speech.text = "";
                  Char6name.text = "";
                  Char6speech.text = "";
                  Char7name.text = "";
                  Char7speech.text = "";
          }
          else if (primeInt ==64){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "You look around, but no signs of the circus are seen anywhere.";
                   Char4name.text = "";
                   Char4speech.text = "";
                   Char5name.text = "";
                   Char5speech.text = "";
                   Char6name.text = "";
                   Char6speech.text = "";
                   Char7name.text = "";
                   Char7speech.text = "";
           }
      else if (primeInt == 65){
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "";
               Char2speech.text = "";
               Char3name.text = "";
               Char3speech.text = "With nowhere else to go, you sigh and head back the way you came.";
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

//ENCOUNTER AFTER CHOICE #1C

       else if (primeInt == 300){
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I’ll miss you.";
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
        else if (primeInt == 301){
          ArtChar5a.SetActive(true);
          ArtChar5b.SetActive(false);
          ArtChar5c.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
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
                 Char7name.text = "Rhubarb";
                 Char7speech.text = "-Mew-";
         }
         else if (primeInt == 302){
           ArtChar5a.SetActive(false);
           ArtChar5b.SetActive(false);
           ArtChar5c.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
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
                  Char7name.text = "Rhubarb";
                  Char7speech.text = "-whine-";
          }
          else if (primeInt == 303){
                   Char1name.text = "";
                   Char1speech.text = "";
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
                   Char7speech.text = "You gently nudge the big cat towards the exit.";
           }
       else if (primeInt == 304){
         ArtChar5a.SetActive(false);
         ArtChar5b.SetActive(true);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
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
                Char7speech.text = "He licks your cheek before reluctantly turning and sauntering away.";
              primeInt = 59;
        }

//ENCOUNTER AFTER CHOICE #1D

       else if (primeInt == 400){
         ArtChar5a.SetActive(true);
         ArtChar5b.SetActive(false);
         ArtChar5c.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "So you just shake your head, gently nudging Rhubarb in the direction of the exit.";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char7name.text = "";
                Char7speech.text = "";
        }
        else if (primeInt == 401){
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "But he doesn’t budge. \nJust stares.";
                 Char4name.text = "";
                 Char4speech.text = "";
                 Char5name.text = "";
                 Char5speech.text = "";
                 Char6name.text = "";
                 Char6speech.text = "";
                 Char7name.text = "";
                 Char7speech.text = "";
         }
         else if (primeInt == 402){
           ArtChar5a.SetActive(false);
           ArtChar5b.SetActive(false);
           ArtChar5c.SetActive(false);
                  Char1name.text = "YOU";
                  Char1speech.text = "You have to go.";
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
          else if (primeInt == 403){
                   Char1name.text = "YOU";
                   Char1speech.text = "There’s nothing left for you here.";
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
           else if (primeInt == 404){
             ArtChar5a.SetActive(true);
             ArtChar5b.SetActive(false);
             ArtChar5c.SetActive(false);
                    Char1name.text = "";
                    Char1speech.text = "";
                    Char2name.text = "";
                    Char2speech.text = "";
                    Char3name.text = "";
                    Char3speech.text = "He seems to understand, as he stands and butts his head against your chest.";
                    Char4name.text = "";
                    Char4speech.text = "";
                    Char5name.text = "";
                    Char5speech.text = "";
                    Char6name.text = "";
                    Char6speech.text = "";
                    Char7name.text = "";
                    Char7speech.text = "";
            }
            else if (primeInt == 405){
                     Char1name.text = "";
                     Char1speech.text = "";
                     Char2name.text = "";
                     Char2speech.text = "";
                     Char3name.text = "";
                     Char3speech.text = "His paw lifts up, resting on top of your head.";
                     Char4name.text = "";
                     Char4speech.text = "";
                     Char5name.text = "";
                     Char5speech.text = "";
                     Char6name.text = "";
                     Char6speech.text = "";
                     Char7name.text = "";
                     Char7speech.text = "";
             }
             else if (primeInt == 406){
               ArtChar5a.SetActive(false);
               ArtChar5b.SetActive(true);
               ArtChar5c.SetActive(false);
                      Char1name.text = "";
                      Char1speech.text = "";
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
                      Char7name.text = "Rhubarb";
                      Char7speech.text = "You did good, kid.";
              }
              else if (primeInt == 407){
                ArtChar5a.SetActive(true);
                ArtChar5b.SetActive(false);
                ArtChar5c.SetActive(false);
                       Char1name.text = "";
                       Char1speech.text = "";
                       Char2name.text = "";
                       Char2speech.text = "";
                       Char3name.text = "";
                       Char3speech.text = "With a huff, he turns and walks towards the exit.";
                       Char4name.text = "";
                       Char4speech.text = "";
                       Char5name.text = "";
                       Char5speech.text = "";
                       Char6name.text = "";
                       Char6speech.text = "";
                       Char7name.text = "";
                       Char7speech.text = "";
               }
               else if (primeInt == 408){
                 ArtChar5a.SetActive(false);
                 ArtChar5b.SetActive(false);
                 ArtChar5c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "So…that happened.";
                        Char4name.text = "";
                        Char4speech.text = "";
                        Char5name.text = "";
                        Char5speech.text = "";
                        Char6name.text = "";
                        Char6speech.text = "";
                        Char7name.text = "";
                        Char7speech.text = "";
                }
       else if (primeInt == 409){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                Char5name.text = "";
                Char5speech.text = "";
                Char6name.text = "";
                Char6speech.text = "";
                Char3speech.text = "You decide not to dwell on it…you’ve seen worse.";
                Char7name.text = "";
                Char7speech.text = "";
              primeInt = 59;
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
               SceneManager.LoadScene("End_Win2");
        }
}
