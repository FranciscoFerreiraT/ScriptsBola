using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player; // Referencia al objeto del jugador
    public Rigidbody rb; // Referencia al Rigidbody del enemigo
    public float speed = 5f; // Velocidad de persecución

    void Start()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        // Dirige al enemigo hacia el jugador
        Vector3 direction = player.position - transform.position;
        direction.Normalize(); // Normaliza el vector para que su longitud sea 1, manteniendo la dirección
        Vector3 force = direction * speed;

        // Aplica la fuerza en FixedUpdate para seguir al jugador
        rb.AddForce(force);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica si el enemigo ha tocado al jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            // Aquí puedes terminar el juego o realizar cualquier acción deseada
            Debug.Log("El juego termina, el enemigo ha tocado al jugador");
            // Por ejemplo, podrías cargar una escena de "Game Over" o desactivar el jugador
        }
    }
}
