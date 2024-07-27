using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float vel = 0.01f;
    Rigidbody corpo;
    bool podePular;
    public float forcaPulo = 25;

    public Transform cameraPos;

    void Start(){
        corpo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rotaciona();
        movimentar();
    }

    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Chao"))
    //     {
    //         podePular = true;
    //     }
    // }

    // void OnCollisionExit(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Chao"))
    //     {
    //         podePular = false;
    //     }
    // }

    void movimentar(){
        float moveX = 0;
        float moveZ = 0;

        if (Input.GetKey(KeyCode.W)) moveZ += 1;
        if (Input.GetKey(KeyCode.S)) moveZ -= 1;
        if (Input.GetKey(KeyCode.D)) moveX += 1;
        if (Input.GetKey(KeyCode.A)) moveX -= 1;
       
        Vector3 movimento = new Vector3(moveX, 0, moveZ).normalized;
        float direcao = cameraPos.transform.eulerAngles.y;
        Vector3 movimentoRotacionado = Quaternion.Euler(0, direcao, 0) * movimento;

        transform.position += movimentoRotacionado * vel;

        // if (Input.GetKey(KeyCode.Space) && podePular) corpo.AddForce(Vector3.up * forcaPulo);
    }

    void rotaciona(){
        Quaternion rotacao = Quaternion.Euler(0, cameraPos.rotation.eulerAngles.y, 0);
        transform.rotation = rotacao;
    }
}