using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisToggler : MonoBehaviour
{
    private AxisRenderer axisRenderer;
    public GameObject x_axis;
    public GameObject y_axis;
    public GameObject z_axis;
    
    void OnLineRendererCreated(GameObject[] axisLines)
    {
        x_axis = axisLines[0];
        y_axis = axisLines[1];
        z_axis = axisLines[2];
    }

    void OnXAxisToggle()
    {
        if (this.isActiveAndEnabled){
            x_axis.SetActive(!x_axis.activeSelf);
        }
    }
    
    void OnYAxisToggle()
    {
        if (this.isActiveAndEnabled){
            y_axis.SetActive(!y_axis.activeSelf);
        }
    }
    
    void OnZAxisToggle()
    {
        if (this.isActiveAndEnabled){
            z_axis.SetActive(!z_axis.activeSelf);
        }
    }

    private void Awake()
    {
        axisRenderer = GetComponent<AxisRenderer>();
        axisRenderer.LineRendererCreatedEvent.AddListener(OnLineRendererCreated);
        UIController.instance.ToggleXAxisEvent.AddListener(OnXAxisToggle);
        UIController.instance.ToggleYAxisEvent.AddListener(OnYAxisToggle);
        UIController.instance.ToggleZAxisEvent.AddListener(OnZAxisToggle);
    }
}
