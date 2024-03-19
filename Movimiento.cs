using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // Referencia al componente Rigidbody del objeto jugador
    public float force = 500f; // Fuerza que se aplicará para mover al jugador

    void Start()
    {
        // Asigna automáticamente el componente Rigidbody
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    void FixedUpdate()
    {
        // Obtén la entrada del jugador
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Crea un vector de dirección basado en estas entradas
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Aplica una fuerza al Rigidbody para mover el jugador
        rb.AddForce(movement * force * Time.deltaTime);
    }
}
