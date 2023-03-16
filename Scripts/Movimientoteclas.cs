using UnityEngine;

public class Movimientoteclas : MonoBehaviour
{

    public float speed = 5.0f;

    void Update()
    {
        // Mueve el objeto hacia adelante cuando se presiona la tecla W
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        // Mueve el objeto hacia atrás cuando se presiona la tecla S
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        // Mueve el objeto hacia la izquierda cuando se presiona la tecla A
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        // Mueve el objeto hacia la derecha cuando se presiona la tecla D
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
