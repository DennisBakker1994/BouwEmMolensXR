using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonMenu : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audioSource; 
    public void Quit()
    {
        Application.Quit();
    }

    public void ButtonClickSound()
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
