using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public GameObject N1;
    public GameObject N2;
    public GameObject N3;
    
    public UnityEvent SelectN1Event = new UnityEvent();
    public UnityEvent SelectN2Event = new UnityEvent();
    public UnityEvent SelectN3Event = new UnityEvent();
    
    public UnityEvent ToggleXAxisEvent = new UnityEvent();
    public UnityEvent ToggleYAxisEvent = new UnityEvent();
    public UnityEvent ToggleZAxisEvent = new UnityEvent();
    
    private void Awake()
    {
        instance = this;
    }
    
    public void OnN1ButtonClick()
    {
        SelectN1Event.Invoke();
        N1.SetActive(true);
        N2.SetActive(false);
        N3.SetActive(false);
    }
    
    public void OnN2ButtonClick()
    {
        SelectN2Event.Invoke();
        N1.SetActive(false);
        N2.SetActive(true);
        N3.SetActive(false);
    }
    
    public void OnN3ButtonClick()
    {
        SelectN3Event.Invoke();
        N3.SetActive(true);
        N1.SetActive(false);
        N2.SetActive(false);
    }
    
    public void OnXAxisToggleButtonClick()
    {
        ToggleXAxisEvent.Invoke();
    }
    public void OnYAxisToggleButtonClick()
    {
        ToggleYAxisEvent.Invoke();
    }
    public void OnZAxisToggleButtonClick()
    {
        ToggleZAxisEvent.Invoke();
    }
}
