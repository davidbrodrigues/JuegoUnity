using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public Transform jugador; // Transform del jugador
    public float velocidad = 28.0f; // Velocidad de movimiento del enemigo
    public Vector3 posicionInicial = new Vector3(950, 9.8f, 0); // Posición inicial del jugador
    public float distanciaMaxima = 70000.0f; // Distancia máxima a la que el enemigo comenzará a perseguir al jugador

    private Rigidbody rb; // Rigidbody del enemigo

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Calcula la distancia entre el enemigo y el jugador
        float distancia = Vector3.Distance(transform.position, jugador.position);

        // Si la distancia es menor que la distancia máxima, persigue al jugador
        if (distancia <= distanciaMaxima)
        {
            // Calcula la dirección hacia la que debe moverse el enemigo para perseguir al jugador
            Vector3 direccion = (jugador.position - transform.position).normalized;
            rb.MovePosition(transform.position + direccion * velocidad * Time.fixedDeltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Comprueba si el objeto que ha colisionado es el jugador
        if (collision.gameObject.CompareTag("player"))
        {
            // Vuelve al jugador a la posición inicial
            jugador.position = posicionInicial;
        }
    }
}