using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform player;              
    public Vector3 minBounds;             // lim min
    public Vector3 maxBounds;             // lim max
    public float smoothSpeed = 0.3f;    //suavizado de la c�mara
    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        // Obtenemos la posici�n deseada de la c�mara (solo en X y Z, la Y ser� constante)
        Vector3 desiredPosition = new Vector3(player.position.x, transform.position.y-3, player.position.z-5);

        // Limitar la posici�n deseada a los l�mites establecidos en los ejes X y Z
        float clampedX = Mathf.Clamp(desiredPosition.x, minBounds.x, maxBounds.x);
        float clampedZ = Mathf.Clamp(desiredPosition.z, minBounds.z, maxBounds.z);

        // Nueva posici�n de la c�mara (Y se mantiene igual)
        Vector3 clampedPosition = new Vector3(clampedX, transform.position.y, clampedZ);

        // Movimiento suave hacia la posici�n deseada
        transform.position = Vector3.SmoothDamp(transform.position, clampedPosition, ref velocity, smoothSpeed);
    }
}

