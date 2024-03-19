using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSlides : MonoBehaviour
{
    public GameObject[] slides;

    public int tutSlide;

    public void ChangeIntPlus()
    {

        if (tutSlide == slides.Length -1)
        {
            tutSlide = 0;

            SetAllToFalse();
            slides[tutSlide].SetActive(true);
            Debug.Log(tutSlide);

        }
        else
        {
            tutSlide++;

            SetAllToFalse();
            slides[tutSlide].SetActive(true);
            Debug.Log(tutSlide);
        }
    }

    public void ChangeIntMinus()
    {

        if (tutSlide == 0)
        {
            tutSlide = slides.Length -1;

            SetAllToFalse();
            slides[tutSlide].SetActive(true);

        }
        else
        {
            tutSlide--;

            SetAllToFalse();
            slides[tutSlide].SetActive(true);
        }
    }

    void SetAllToFalse()
    {
        foreach (GameObject go in slides)
        {
            go.SetActive(false);
        }
    }
}
