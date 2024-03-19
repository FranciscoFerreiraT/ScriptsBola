using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que tu objeto jugador tenga el tag "Player"
        {
            // Aquí puedes incrementar el contador de monedas del jugador o reproducir un sonido
            Debug.Log("Moneda recogida!"); // Ejemplo de acción, reemplázalo por tu lógica específica

            // Desactiva la moneda o destrúyela si ya no la necesitas
            gameObject.SetActive(false);
            // O también puedes usar Destroy(gameObject); si prefieres eliminar el objeto por completo
        }
    }
}
