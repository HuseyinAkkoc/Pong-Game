using UnityEngine;
using System;

public class MMAudioManager : MonoBehaviour
{

    public AudioSource buttonClickSound;
    public void PlayButtonClickSound()
    {
        if (buttonClickSound)
        {
            if (!buttonClickSound.isPlaying)
            {
                buttonClickSound.Play();
            }
            else
            {
                buttonClickSound.Stop();
                buttonClickSound.Play();
            }
        }
    }



}
