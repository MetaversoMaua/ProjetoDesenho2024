using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrtogonalView : MonoBehaviour
{
    public Transform target; // Target object to focus on
    public float distance = 100.0f; // Distance from the target
    private Vector3 position;
    void Update()
    {
        position = new Vector3(target.position.x-target.GetComponent<Renderer>().bounds.size.x/2, target.position.y +target.GetComponent<Renderer>().bounds.size.y/2, target.position.z +target.GetComponent<Renderer>().bounds.size.z/2);
        if (Input.GetKeyDown(KeyCode.F))
        {
            SetFrontView();
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            SetTopDownView();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            SetSideView();
        }
    }

    void SetFrontView()
    {
        transform.rotation = Quaternion.Euler(0, 0f, 0f);
        transform.position = position + new Vector3(0, 0, -distance);
    }

    void SetTopDownView()
    {
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        transform.position = position + new Vector3(-0.5f, distance, 0.8f);
    }

    void SetSideView()
    {
        transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        transform.position = position + new Vector3(-distance, 1, 1);
    }
}
