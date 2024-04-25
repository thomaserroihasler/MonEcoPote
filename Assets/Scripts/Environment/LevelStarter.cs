using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject Countdown3;
    public GameObject Countdown2;
    public GameObject Countdown1;
    public GameObject CountdownGO;
    public GameObject FadeIn;
    public AudioSource readyFX;
    public AudioSource goFX;
    void Start()
    {
        StartCoroutine( CountSequence());
    }


   IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.2f);
        Countdown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1.0f);  // Corrected from 1.f to 1.0f
        Countdown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1.0f);  // Corrected from 1.f to 1.0f
        Countdown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1.0f);  // Corrected from 1.f to 1.0f
        CountdownGO.SetActive(true);
        goFX.Play();
        PlayerMove.canMove = true;
    }


}
