using UnityEngine;

public class Camerapp : MonoBehaviour
{

    public Transform player; //El objeto a seguir
    public Vector3 offset = new Vector3(0.0f, 2.0f, 0.0f); //Distancia de la cámara desde el jugador
    public float rotateSpeed = 5000.0f; //Velocidad de rotación de la cámara
    public float maxRotation = 4500.0f; //Máxima rotación que se puede hacer
    public float mouseRotateSpeed = 700.0f; //Velocidad de rotación con el ratón

    private float currentRotation = 0.0f; //Rotación actual de la cámara

    void LateUpdate()
    {
        transform.position = player.position + offset; //Establece la posición de la cámara

        // Gira la cámara con el ratón
        float mouseX = Input.GetAxis("Mouse X");
        currentRotation += mouseX * mouseRotateSpeed * Time.deltaTime;

        // Limita la rotación de la cámara a un máximo de 45 grados
        currentRotation = Mathf.Clamp(currentRotation, -maxRotation, maxRotation);

        // Establece la rotación de la cámara
        transform.rotation = Quaternion.Euler(0.0f, currentRotation, 0.0f) * player.rotation;
    }
}
