using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay; // This should have a TextMeshProUGUI component
    public GameObject finalDisDisplay; // This should also have a TextMeshProUGUI component

    public int disRun;
    public bool addingDis = false;
    private TextMeshProUGUI disText; // To cache the TextMeshProUGUI component for disDisplay
    private TextMeshProUGUI finalDisText; // To cache the TextMeshProUGUI component for finalDisDisplay
    public float disDelay = 0.35f;

    void Start()
    {
        // Get the TextMeshProUGUI component from the disDisplay GameObject
        disText = disDisplay.GetComponent<TextMeshProUGUI>();
        if (disText == null)
        {
            Debug.LogError("TextMeshProUGUI component is not found on the disDisplay object.");
        }

        // Get the TextMeshProUGUI component from the finalDisDisplay GameObject
        finalDisText = finalDisDisplay.GetComponent<TextMeshProUGUI>();
        if (finalDisText == null)
        {
            Debug.LogError("TextMeshProUGUI component is not found on the finalDisDisplay object.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!addingDis)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }

    IEnumerator AddingDis()
    {
        disRun += 1; // Increment distance run
        if (disText != null)
        {
            disText.text = disRun.ToString(); // Update the text of the TextMeshPro component
        }
        if (finalDisText != null)
        {
            finalDisText.text = disRun.ToString(); // Update the text of the final distance display
        }
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
    }
}
