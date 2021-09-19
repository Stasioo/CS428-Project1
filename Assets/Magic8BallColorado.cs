using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Magic8BallColorado : MonoBehaviour
{
    public Transform CubeTransform;
    public GameObject TextObject;
    public AudioSource audioSrc;
    public bool playedOnce = false; // using boolean variable to play the audio clip + change different text just once
    private string[] phrases = {"Shred on bro!", "Dope!", "Without a doubt","Groovy!", "You may rely on it",
                               "As I see it, yes.", "Most likely", "Outlook good", "Yes", "Signs point to yes",
                               "Big chillin'","Head's feeling pretty dizzy.","Better not tell you now","Cannot predict now","Looks like a blizzard be coming.",
                               "Don't count on it", "Oi, that's not good.","Mmmmmh, nope!", "Looking pretty grim rn.", "This vibe is killer." };


    void Update()
    {
        int randomNum = Random.Range(0, 19);
        //Debug.Log("Y: " + CubeTransform.up.y);

        // cube is updside down, change the text and play sound ONCE
        if (CubeTransform.up.y <= -0.8f)
        {
            if (!playedOnce)
            {
                Debug.Log(phrases[randomNum]);
                TextObject.GetComponent<TextMeshPro>().text = phrases[randomNum];
                audioSrc.PlayOneShot(audioSrc.clip, 1);
                playedOnce = true;
            }
        }
        else
        {
            playedOnce = false;
        }
    }
}
