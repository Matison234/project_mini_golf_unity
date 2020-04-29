using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

public class TrajectoryPrediction : MonoBehaviour
{
    [SerializeField] private Vector2Variable hitValue;

    [SerializeField] private float predictionTime = 2.0f;

    [SerializeField] private LineRenderer lineRenderer;

    [SerializeField] Transform target;

    private Rigidbody2D targetRb2D;

    private List<Vector3> trajectoryPoints = new List<Vector3>();
    private void Start()
    {
        targetRb2D = target.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = target.position;

        DisplayTrajectory();
    }

    private void DisplayTrajectory()
    {
        int maxIterations = Mathf.RoundToInt(predictionTime / Time.fixedDeltaTime);
        Vector2 pos = Vector2.zero;
        Vector2 vel = target.GetComponent<Rigidbody2D>().velocity + hitValue.Value / targetRb2D.mass;
        float drag = targetRb2D.drag;
        for(int i = 0; i < maxIterations; i++)
        {
            vel += Physics2D.gravity * Time.fixedDeltaTime;
            vel *= Mathf.Clamp01(1.0f - (drag * Time.fixedDeltaTime));
            pos += vel * Time.fixedDeltaTime;

            trajectoryPoints.Add(pos);
        }

        lineRenderer.positionCount = trajectoryPoints.Count;
        lineRenderer.SetPositions(trajectoryPoints.ToArray());

        trajectoryPoints.Clear();

    }
}
