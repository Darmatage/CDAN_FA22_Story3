using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3fDialogue : MonoBehaviour {
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
        public GameObject ArtChar1d;
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
        ArtChar1d.SetActive(false);
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
          ArtBG1.SetActive(true);
          ArtBG2.SetActive(false);
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
                Char3speech.text = "Your mind is reeling with everything you’ve learned so far, and a slowly increasing sense of dread churns in your stomach. ";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Unintentionally, you find yourself in front of the main tent. ";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "The biggest one, sitting right in the middle of it all.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You realize that you haven’t looked in here yet, and walk towards it in hopes of gaining some more clues. ";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "However, that dread within you only grows stronger the closer you get.";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You shake off the feeling, pushing back the striped curtain and walking inside.";
        }
       else if (primeInt ==8){
         ArtBG1.SetActive(false);
         ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You’re greeted with darkness, until the lights slowly flicker on, one by one. ";
        }
       else if (primeInt ==9){
         ArtChar1a.SetActive(true);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "In the center of the ring, is the Ringmaster themselves.";
        }
       else if (primeInt ==10){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(true);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "You’re very nosy, I’ll give you that.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==11){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Uh, Ringmaster?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==12){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "They turn around to face you, but that enthusiastic smile that greeted you in the beginning is no longer there.";
        }
       else if (primeInt ==13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Instead, replaced by an almost apathetic expression.";
        }
       else if (primeInt ==14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "In their hands is a whip, the very ends of it faintly stained with dark crimson.";
        }
       else if (primeInt ==15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Don’t think I haven’t been keeping an eye on you, outsider.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "I know everything that happens in my circus.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==17){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "They take a step closer.";
        }
       else if (primeInt ==18){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "You may still be mortal, but I’ll make sure that ends very soon.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==19){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Without warning, they crack their whip and lash it towards you.";
        }
       else if (primeInt ==20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You barely manage to dodge, looking down to see a thin cut on your shoulder.";
        }
       else if (primeInt ==21){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "I’ve worked for too long for some wandering idiot to ruin my plans now!";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 22){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Everyone will know what you’ve done when I get out of here!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
       }
//CONVERGENCE

      else if (primeInt ==30){
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "With the last of your strength, you grab their ankle and pull as hard as you can.";
       }
      else if (primeInt ==31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "This somehow manages to make the Ringmaster fall, as you climb to your feet and untangle the whip from your throat.";
       }
      else if (primeInt ==32){
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(true);
        ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You quickly pull it towards you, grabbing the handle.";
       }
      else if (primeInt ==33){
        ArtChar1a.SetActive(false);
        ArtChar1b.SetActive(false);
        ArtChar1c.SetActive(false);
        ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You stare down at the Ringmaster, grip tightening on the whip.";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);
       }


// ENCOUNTER AFTER CHOICE #1A
       else if (primeInt == 100){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You’re gasping for air all of a sudden, as your hands reach up and claw at the whip tightening around your throat.";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Your body is pulled harshly to the ground, as the Ringmaster pulls you closer.";
        }
       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Their boot presses down on your chest, making you gasp.";
        }
       else if (primeInt == 103){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(true);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "No one will know you’re gone.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 104){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "And you’ll just be another freak on my show.";
                Char3name.text = "";
                Char3speech.text = "";
            primeInt = 29;
        }

//ENCOUNTER AFTER CHOICE #1B

       else if (primeInt == 200){
         ArtChar1a.SetActive(true);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You frantically search the area around you, looking for anything you could use as a weapon.";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Partially hidden in the sand, you spot a rusty pair of fire eating torches.";
        }
       else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You make a run for them, but the whip wraps around your ankle and causes you to fall face first.";
        }
       else if (primeInt == 203){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Tasting sand, you extend your arm in desperation and manage to grab one of the torches.";
        }
       else if (primeInt == 204){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Eat this!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 205){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "-BONK-";
        }
       else if (primeInt == 206){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar1d.SetActive(false);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "Ringmaster";
                 Char2speech.text = "AGH!";
                 Char3name.text = "";
                 Char3speech.text = "";
        }
       else if (primeInt == 207){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "The sound of the torch hitting the Ringmaster’s head is satisfying, and gives you enough time to unravel the whip from your ankle.";
        }
       else if (primeInt == 208){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You hastily grab the other one, running towards the Ringmaster with a cry.";
        }
       else if (primeInt == 209){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Although they’re slightly dazed, they see you running and act quickly.";
        }
       else if (primeInt == 210){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "Do you think I’m a fool?!";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 211){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "They lash their whip out again, which rips the torch out of your hands.";
        }
       else if (primeInt == 212){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "With a haughty laugh, they swing their whip at your wrist and pull you face first into the sand again.";
        }
       else if (primeInt == 213){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "The whip harshly pulls your wrist and rolls you onto your back, as you spit the sand out of your mouth.";
        }
       else if (primeInt == 214){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Through a grainy vision, you can faintly make out the Ringmaster looming over you.";
        }
       else if (primeInt == 215){
         ArtChar1a.SetActive(true);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "This is…";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 216){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(true);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "…just pathetic.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 217){
         ArtChar1a.SetActive(true);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "I almost feel bad for you.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 218){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "You would’ve made an interesting taxidermied specimen.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 219){
         ArtChar1a.SetActive(true);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(false);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "Their grin is sinister, as they press their boot against your chest.";
        }
       else if (primeInt == 220){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You cough, struggling to breathe.";
        }
       else if (primeInt == 221){
         ArtChar1a.SetActive(false);
         ArtChar1b.SetActive(false);
         ArtChar1c.SetActive(true);
         ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Ringmaster";
                Char2speech.text = "You will not be missed.";
                Char3name.text = "";
                Char3speech.text = "";
            primeInt = 29;
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(false);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "You scramble to your feet and bolt for the exit, but another crack pierces the air.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
          ArtChar1a.SetActive(true);
          ArtChar1b.SetActive(false);
          ArtChar1c.SetActive(true);
          ArtChar1d.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "This is a super epic boss battle, and you’re no coward.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4c");
        }
}
