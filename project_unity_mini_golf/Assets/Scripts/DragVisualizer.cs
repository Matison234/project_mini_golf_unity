using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.Mobile;

public class DragVisualizer : MonoBehaviour
{
    // Start is called before the first frame update

    public LineRenderer linerenderer;
    private Vector3[] points = new Vector3[2];
    void Start()
    {
        points[0] = new Vector3();
        points[1] = new Vector3();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ProcessDrag(TouchUserInput tui)
    {
        if(tui.InputState == TouchUserInput.State.Down)
        {
            
            points[0].x = tui.InputWorldPosLastDown.x;
            points[0].y = tui.InputWorldPosLastDown.y;
            points[1].x = tui.InputWorldPos.x;
            points[1].y = tui.InputWorldPos.y;

            linerenderer.SetPositions(points);
            linerenderer.enabled = true;
        }
        else if(tui.InputState == TouchUserInput.State.Drag)
        {
            points[0].x = tui.InputWorldPosLastDown.x;
            points[0].y = tui.InputWorldPosLastDown.y;
            points[1].x = tui.InputWorldPos.x;
            points[1].y = tui.InputWorldPos.y;

            linerenderer.SetPositions(points);
        }
        else if(tui.InputState == TouchUserInput.State.None)
        {
            linerenderer.enabled = false;
        }
    }
}
