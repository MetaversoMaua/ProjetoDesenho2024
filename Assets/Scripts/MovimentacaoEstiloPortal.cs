using UnityEngine;

public class RotateOnProximity : MonoBehaviour
{
    public Transform player; // Referência ao jogador
    public float detectionRange = 5f; // Distância para detectar o jogador
    public float rotationSpeed = 100f; // Velocidade de rotação do objeto

    private bool isPlayerNear = false;

    void Update()
    {
        // Calcular a distância entre o objeto e o jogador
        float distance = Vector3.Distance(transform.position, player.position);

        // Verificar se o jogador está dentro da distância de detecção
        if (distance <= detectionRange)
        {
            isPlayerNear = true;
        }
        else
        {
            isPlayerNear = false;
        }

        // Se o jogador estiver perto, permitir a rotação do objeto
        if (isPlayerNear)
        {
            float rotation = rotationSpeed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.up, -rotation);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up, rotation);
            }
        }
    }
}