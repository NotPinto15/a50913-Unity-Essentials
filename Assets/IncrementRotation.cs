using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotateChange;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (rotateChange); 
    }
}