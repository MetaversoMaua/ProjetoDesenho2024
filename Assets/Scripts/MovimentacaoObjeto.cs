using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjeto : MonoBehaviour
{
    public float velocidade = 100000000000000000f; 
        void Update()
    {
        // Leitura da entrada do teclado
        float horizontal = Input.GetAxis("Horizontal"); // A/D ou setas esquerda/direita
        float vertical = Input.GetAxis("Vertical"); // W/S ou setas cima/baixo

        // Calcular a direção do movimento
        Vector3 movimento = new Vector3(horizontal, 0, vertical);

        // Aplicar o movimento ao objeto com velocidade e deltaTime
        transform.Translate(movimento * velocidade * Time.deltaTime);
    }
}