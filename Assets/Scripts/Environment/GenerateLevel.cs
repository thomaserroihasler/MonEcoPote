using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sections; // Renamed for clarity
    public float zpos = 150.0f; // Initial position for the first section
    public bool creatingSection = false; // Follows C# naming conventions
    public int secNum;

    // Update is called once per frame
    void Update()
    {
        // Check if a section is not currently being created
        if (!creatingSection)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, sections.Length); // Ensures the index is within bounds
        Instantiate(sections[secNum], new Vector3(0, 0, zpos), Quaternion.identity);
        zpos += 39.75f; // Move the position for the next section
        yield return new WaitForSeconds(6); // Wait before allowing another section to be generated
        creatingSection = false;
    }
}
 