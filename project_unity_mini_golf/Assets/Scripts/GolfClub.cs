using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.Mobile;
using UnityAtoms.BaseAtoms;

public class GolfClub : MonoBehaviour
{
    public FloatReference hitPower;
    public Rigidbody2D ballRb2D;
    public Vector2Variable hitValue;

    private Vector2 hitVector;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ProcessDrag(TouchUserInput tui)
    {
        if(tui.InputState == TouchUserInput.State.Drag)
        {
            hitVector = tui.InputPos - tui.InputPosLastDown;
            hitValue.Value = hitPower * hitVector;
        }
        else if(tui.InputState == TouchUserInput.State.Up)
        {
            
            ballRb2D.AddForce(hitValue.Value, ForceMode2D.Impulse);
            hitValue.Value = Vector2.zero;

        }
       
    }
}
