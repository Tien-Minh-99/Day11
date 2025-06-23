using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonClaim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void claim()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("ban da bam vao button claim");
        }
    }
}
