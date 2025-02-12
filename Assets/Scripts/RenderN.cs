using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderPart : MonoBehaviour
{
    public GameObject N1;
    public GameObject N2;
    public GameObject N3;

    private bool N1Bool = true;
    private bool N2Bool = true;
    private bool N3Bool = true;

    public GameObject fullN1;
    public GameObject normalN1;
    public GameObject facesN1;
    public GameObject fullN2;
    public GameObject normalN2;
    public GameObject facesN2;
    public GameObject fullN3;
    public GameObject normalN3;
    public GameObject facesN3;

    private bool full_bool = true;
    private bool normal_bool = true;
    private bool faces_bool = true;

    private void ToggleN1()
    {
        N1Bool = !N1Bool;
        N1.SetActive(N1Bool);
    }
     private void ToggleN2()
    {
        N2Bool = !N2Bool;
        N2.SetActive(N2Bool);
    }
     private void ToggleN3()
    {
        N3Bool = !N3Bool;
        N3.SetActive(N3Bool);
    }

    // private void ToggleFull()
    // {
    //     full_bool = !full_bool;
    //     full.SetActive(full_bool);
    // }
    //  private void ToggleNormal()
    // {
    //     normal_bool = !normal_bool;
    //     normal.SetActive(normal_bool);
    // }
    //  private void ToggleFaces()
    // {
    //     faces_bool = !faces_bool;
    //     faces.SetActive(faces_bool);
    // }

    void Start()
    {
        ToggleN2();
        ToggleN3(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            ForcedUpdate();
        }
    }

    public void ForcedUpdate()
    {
        if (N1Bool)
        {
            ToggleN1();
            ToggleN2();
        }
        else if (N2Bool)
        {
            ToggleN2();
            ToggleN3();
        }
        else
        {
            ToggleN3();
            ToggleN1();
        }
    }
}
