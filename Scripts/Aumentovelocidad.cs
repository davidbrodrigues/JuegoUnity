using UnityEngine;

public class Aumentovelocidad : MonoBehaviour
{
    public float velocidad = 30.0f; // Velocidad de movimiento del jugador
    public float velocidadAumentada = 60.0f; // Velocidad de movimiento aumentada del jugador
    public KeyCode teclaAumento = KeyCode.LeftControl; // Tecla para aumentar la velocidad

    private float velocidadActual; // Velocidad actual del jugador

    void Start()
    {
        velocidadActual = velocidad;
    }

    void Update()
    {
        // Si la tecla de aumento de velocidad está presionada, establece la velocidad actual a la velocidad aumentada
        if (Input.GetKey(teclaAumento))
        {
            velocidadActual = velocidadAumentada;
        }
        else // Si la tecla de aumento de velocidad no está presionada, establece la velocidad actual a la velocidad normal
        {
            velocidadActual = velocidad;
        }

        // Mueve al jugador en la dirección deseada multiplicando por la velocidad actual
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, 0.0f, vertical) * velocidadActual * Time.deltaTime;
    }
}
