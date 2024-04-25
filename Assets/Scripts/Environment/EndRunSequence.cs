using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{

    public GameObject liveCoins;
    public GameObject liveDistance;
    public GameObject endScreen;
    public GameObject fadeOut;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndSequence());
    }

    // Update is called once per frame
  
    IEnumerator EndSequence() 
    {
        yield return new WaitForSeconds(0.5f);
        liveCoins.SetActive(false);
        liveDistance.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(0);

    }

}
