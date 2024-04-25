using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay; // This should have a TextMeshProUGUI component
    public GameObject coinCountFinalDisplay; // This should have a TextMeshProUGUI component

    private TextMeshProUGUI coinCountText; // To cache the TextMeshProUGUI component for coinCountDisplay
    private TextMeshProUGUI coinCountFinalText; // To cache the TextMeshProUGUI component for coinCountFinalDisplay

    void Start()
    {
        // Get the TextMeshProUGUI component from the coinCountDisplay GameObject
        coinCountText = coinCountDisplay.GetComponent<TextMeshProUGUI>();
        if (coinCountText == null)
        {
            Debug.LogError("TextMeshProUGUI component is not found on the coinCountDisplay object.");
        }

        // Get the TextMeshProUGUI component from the coinCountFinalDisplay GameObject
        coinCountFinalText = coinCountFinalDisplay.GetComponent<TextMeshProUGUI>();
        if (coinCountFinalText == null)
        {
            Debug.LogError("TextMeshProUGUI component is not found on the coinCountFinalDisplay object.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Update the text of the TextMeshPro component for coinCountDisplay
        if (coinCountText != null)
        {
            coinCountText.text = coinCount.ToString();
        }

        // Update the text of the TextMeshPro component for coinCountFinalDisplay
        if (coinCountFinalText != null)
        {
            coinCountFinalText.text = coinCount.ToString();
        }
    }
}
