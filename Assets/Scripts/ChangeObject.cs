using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeObject : MonoBehaviour
{
    public GameObject N1;
    public GameObject N2;
    public GameObject N3;

    private bool N1_bool = true;
    private bool N2_bool = false;
    private bool N3_bool = false;


    private void ToggleN1()
    {
        N1_bool = !N1_bool;
        N1.SetActive(N1_bool);
    }
     private void ToggleN2()
    {
        N2_bool = !N2_bool;
        N2.SetActive(N2_bool);
    }
     private void ToggleN3()
    {
        N3_bool = !N3_bool;
        N3.SetActive(N3_bool);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            ForcedUpdate();
        }
    }

    public void ForcedUpdate()
    {
        if (N2_bool)
        {
            ToggleN1();
            ToggleN2();
        }
        else if (N1_bool)
        {
            ToggleN1();
            ToggleN3();
        }
        else
        {
            ToggleN3();
            ToggleN2();
        }
    }
}
