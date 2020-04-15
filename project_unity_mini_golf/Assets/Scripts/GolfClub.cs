﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.Mobile;

public class GolfClub : MonoBehaviour
{
    public float hitPower;
    public Rigidbody2D ballRb2D;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ProcessDrag(TouchUserInput tui)
    {
        if(tui.InputState == TouchUserInput.State.Up)
        {
            Vector2 hitVector = tui.InputPos - tui.InputPosLastDown;
            ballRb2D.AddForce(hitPower * hitVector);

        }
       
    }
}