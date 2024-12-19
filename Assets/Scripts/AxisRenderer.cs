using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AxisRenderer : MonoBehaviour
{
    public float lineLength = 150.0f; // Length of the axis lines
    public float lineWidth = 1.0f; // Width of the axis lines
    public UnityEvent<GameObject[]> LineRendererCreatedEvent = new UnityEvent<GameObject[]>();
    private GameObject x_axis;
    private GameObject y_axis;
    private GameObject z_axis;

    void Start()
    {
        x_axis = CreateAxisLine("XAxis", Color.red, Vector3.right);
        y_axis = CreateAxisLine("YAxis", Color.green, Vector3.up);
        z_axis = CreateAxisLine("ZAxis", Color.blue, Vector3.forward);
        LineRendererCreatedEvent.Invoke(new GameObject[] { x_axis, y_axis, z_axis });
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            ToggleAxis(x_axis);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            ToggleAxis(y_axis);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ToggleAxis(z_axis);
        }
    }

    void ToggleAxis(GameObject axis)
    {
        axis.SetActive(!axis.activeSelf);
    }
    
    public void ToggleXAxis()
    {
        ToggleAxis(x_axis);
    }
    
    public void ToggleYAxis()
    {
        ToggleAxis(y_axis);
    }
    
    public void ToggleZAxis()
    {
        ToggleAxis(z_axis);
    }

    GameObject CreateAxisLine(string name, Color color, Vector3 direction)
    {
        GameObject axisLine = new GameObject(name);
        axisLine.transform.parent = transform;
        axisLine.transform.localPosition = new Vector3(-this.GetComponent<Renderer>().bounds.size.x / 200, this.GetComponent<Renderer>().bounds.size.y / 200, this.GetComponent<Renderer>().bounds.size.z / 200);
        LineRenderer lineRenderer = axisLine.AddComponent<LineRenderer>();

        lineRenderer.useWorldSpace = false;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.startColor = color;
        lineRenderer.endColor = color;
        lineRenderer.startWidth = lineWidth;
        lineRenderer.endWidth = lineWidth;
        lineRenderer.positionCount = 2;

        lineRenderer.SetPosition(0, -direction * lineLength / 2);
        lineRenderer.SetPosition(1, direction * lineLength / 2);
        axisLine.transform.SetParent(this.transform.parent);
        return axisLine;
    }
}
