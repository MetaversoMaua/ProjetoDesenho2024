using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerspective : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.T) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.F)) && !cam.orthographic) cam.orthographic = true;
        else if (Input.GetKeyDown(KeyCode.C)) cam.orthographic = !cam.orthographic;
    }
}
