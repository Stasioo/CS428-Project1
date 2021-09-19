using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Magic8BallScript : MonoBehaviour
{
    public Transform CubeTransform;
    public GameObject TextObject;
    public AudioSource audioSrc;
    public bool playedOnce = false; // using boolean variable to play the audio clip + change different text just once
    public string[] phrases = {"It is Certain", "It is decidedly so", "Without a doubt","Yes definitely", "You may rely on it",
                               "As I see it, yes.", "Most likely", "Outlook good", "Yes", "Signs point to yes",
                               "Reply hazy, try again","Ask again later","Better not tell you now","Cannot predict now","Concentrate and ask again",
                               "Don't count on it", "My reply is no","My sources say no", "Outlook not so good", "Very doubtful" };


    void Update()
    {
        int randomNum = Random.Range(0,19);
        //Debug.Log("Y: " + CubeTransform.up.y);

        // cube is updside down, change the text and play sound ONCE
        if(CubeTransform.up.y <= -0.8f)
        {
            if (!playedOnce)
            {
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
