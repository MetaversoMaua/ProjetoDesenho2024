using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceRenderer : MonoBehaviour
{
    public GameObject full;
    public GameObject normal;
    public GameObject faces;

    private bool full_bool = true;
    private bool normal_bool = true;
    private bool faces_bool = true;


    private void ToggleFull()
    {
        full_bool = !full_bool;
        full.SetActive(full_bool);
    }
     private void ToggleNormal()
    {
        normal_bool = !normal_bool;
        normal.SetActive(normal_bool);
    }
     private void ToggleFaces()
    {
        faces_bool = !faces_bool;
        faces.SetActive(faces_bool);
    }

    void Start()
    {
        ToggleFull();
        ToggleFaces(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (normal_bool)
            {
                ToggleFull();
                ToggleNormal();
            }
            else if (full_bool)
            {
                ToggleFull();
                ToggleFaces();
            }
            else
            {
                ToggleFaces();
                ToggleNormal();
            }
        }
    }
}
