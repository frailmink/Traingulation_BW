using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    private LineRenderer lr;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    public void SetUpLine(List<Vector2> points)
    {
        lr.positionCount = points.Count + 1;
        for (int i = 0; i < points.Count; i++)
        {
            lr.SetPosition(i, points[i]);
        }
        lr.SetPosition(points.Count, points[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
