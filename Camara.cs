using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Objeto a seguir
    public Vector3 offset = new Vector3(0f, 5f, -10f); // Distancia entre la cámara y el objeto

    void LateUpdate()
    {
        // Actualiza la posición de la cámara para que siga al objetivo con el desplazamiento definido
        transform.position = target.position + offset;
    }
}
