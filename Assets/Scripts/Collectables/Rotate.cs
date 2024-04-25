using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotate_speed = 1;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotate_speed,0,Space.World);
    }
}
