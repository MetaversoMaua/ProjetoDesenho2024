using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;                // Velocidade de movimento
    public float mouseSensitivity = 100f;   // Sensibilidade do mouse
    public Transform cameraTransform;       // Transform da câmera principal

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Captura a entrada do teclado
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float strafe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Vector3 moveDirection = transform.forward * move + transform.right * strafe;
        controller.Move(moveDirection);

        // Rotação do personagem
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX);

        // Rotação da câmera
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        cameraTransform.Rotate(Vector3.left * mouseY);
    }
}