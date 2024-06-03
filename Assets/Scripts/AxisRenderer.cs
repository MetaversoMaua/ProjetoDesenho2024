using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AxisRenderer : MonoBehaviour
{
    public float lineLength = 150.0f; // Length of the axis lines
    public UnityEvent onLineRendererCreated = new UnityEvent();
    void Awake()
    {
        CreateAxisLine("XAxis", Color.red, Vector3.right);
        CreateAxisLine("YAxis", Color.green, Vector3.up);
        CreateAxisLine("ZAxis", Color.blue, Vector3.forward);
        onLineRendererCreated.Invoke();
    }

    void CreateAxisLine(string name, Color color, Vector3 direction)
    {
        GameObject axisLine = new GameObject(name);
        axisLine.transform.parent = transform;
        axisLine.transform.localPosition = new Vector3(-this.GetComponent<Renderer>().bounds.size.x / 200, this.GetComponent<Renderer>().bounds.size.y / 200, this.GetComponent<Renderer>().bounds.size.z / 200);
        LineRenderer lineRenderer = axisLine.AddComponent<LineRenderer>();
        
        lineRenderer.useWorldSpace = false;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.startColor = color;
        lineRenderer.endColor = color;
        lineRenderer.startWidth = 1.0f;
        lineRenderer.endWidth = 1.0f;
        lineRenderer.positionCount = 2;
        
        lineRenderer.SetPosition(0, - direction * lineLength / 2);
        lineRenderer.SetPosition(1, direction * lineLength / 2);
    }
}
