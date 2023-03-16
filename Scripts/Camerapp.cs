using UnityEngine;

public class Camerapp : MonoBehaviour
{

    public Transform player; //El objeto a seguir
    public Vector3 offset = new Vector3(0.0f, 2.0f, 0.0f); //Distancia de la c�mara desde el jugador
    public float rotateSpeed = 5000.0f; //Velocidad de rotaci�n de la c�mara
    public float maxRotation = 4500.0f; //M�xima rotaci�n que se puede hacer
    public float mouseRotateSpeed = 700.0f; //Velocidad de rotaci�n con el rat�n

    private float currentRotation = 0.0f; //Rotaci�n actual de la c�mara

    void LateUpdate()
    {
        transform.position = player.position + offset; //Establece la posici�n de la c�mara

        // Gira la c�mara con el rat�n
        float mouseX = Input.GetAxis("Mouse X");
        currentRotation += mouseX * mouseRotateSpeed * Time.deltaTime;

        // Limita la rotaci�n de la c�mara a un m�ximo de 45 grados
        currentRotation = Mathf.Clamp(currentRotation, -maxRotation, maxRotation);

        // Establece la rotaci�n de la c�mara
        transform.rotation = Quaternion.Euler(0.0f, currentRotation, 0.0f) * player.rotation;
    }
}
