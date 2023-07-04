using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float w = 180f / (80 * Mathf.PI);
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log(w);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, 0, w);
        transform.Translate(0, 0.1f, 0);
    }
}
