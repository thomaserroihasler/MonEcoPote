using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLevel : MonoBehaviour
{
    // Update is called once per frame
    void Start()
    {
        StartCoroutine(DestroyIfClone());
    }

    IEnumerator DestroyIfClone()
    {
        yield return new WaitForSeconds(20);
        
        if (transform.name.EndsWith("(Clone)"))
        {
            Debug.Log("Parent name: " + transform.name); // Print the parent name
            Destroy(gameObject);
        }
    }
}
