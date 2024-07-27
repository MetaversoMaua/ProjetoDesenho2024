using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamera : MonoBehaviour
{
    float rotationX = 0f;
    float rotationY = 0f;
    float maxRotationX = 180f;
    float minRotationX = 0f;
    public float sensitivity = 15f;

    public Transform personagem;
    public Vector3 offset;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
 
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        rotationX = Mathf.Clamp(rotationX, minRotationX, maxRotationX);
        transform.localEulerAngles = new Vector3(rotationX-90,rotationY,0);
    }

    void LateUpdate(){
        Vector3 posDesejada = personagem.position + offset;
        transform.position = posDesejada;
    }
}