using Firebase.Database;
using UnityEngine;

public class UpdateObjectData : MonoBehaviour
{
    private DatabaseReference reference;

    void Start()
    {
        reference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    void Update()
    {
        // Opción: Puedes elegir enviar datos en intervalos o en eventos específicos en lugar de cada frame.
        SendPositionToFirebase();
    }

    void SendPositionToFirebase()
    {
        ObjectPosition currentPosition = new ObjectPosition
        {
            x = transform.position.x,
            y = transform.position.y,
            z = transform.position.z
        };

        string json = JsonUtility.ToJson(currentPosition);

        // Asegúrate de que la ruta refleje correctamente el objeto que estás actualizando en Firebase.
        reference.Child("GameObjects").Child("object1").Child("position").SetRawJsonValueAsync(json);
    }
}

[System.Serializable]
public class ObjectPosition
{
    public float x;
    public float y;
    public float z;
}
