using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    public GameObject Rocapuerta; // La piedra que se mover�
    public Vector3 movimiento = new Vector3(-456f, 449.8f, -320f); // El movimiento que se aplicar� a la piedra
    public float moveSpeed = 50.0f; // La velocidad a la que se mover� la piedra

    private bool platformTouched = false; // Bandera para controlar si se ha tocado la plataforma

    private void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto que ha tocado la plataforma es el jugador
        if (other.CompareTag("player"))
        {
            platformTouched = true; // Marca la plataforma como tocada
        }
    }

    private void Update()
    {
        // Si la plataforma ha sido tocada y la piedra no ha alcanzado la posici�n objetivo, mu�vela hacia all�
        if (platformTouched && Rocapuerta.transform.position != movimiento)
        {
            Rocapuerta.transform.position = Vector3.MoveTowards(Rocapuerta.transform.position, movimiento, moveSpeed * Time.deltaTime);
        }
    }
}
