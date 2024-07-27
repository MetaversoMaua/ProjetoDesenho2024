using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Transform obj;
    private Vector3 pos;

    void Start()
    {
        pos = obj.position;
    }

    // Update is called once per frame1.276
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)){
            obj.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
            obj.transform.position = new Vector3(pos.x, pos.y - 0.02f, pos.z + 0.01f);
        }
        if (Input.GetKeyDown(KeyCode.T)){
            obj.transform.rotation = Quaternion.Euler(-90f, -90f, 0f);
            obj.transform.position = new Vector3(pos.x, pos.y - 0.014f, pos.z + 0.01f);
        }
        if (Input.GetKeyDown(KeyCode.F)){
            obj.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            obj.transform.position = pos;
        }
    }
}
