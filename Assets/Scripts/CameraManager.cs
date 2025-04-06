using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform player;              
    public Vector3 minBounds;             // lim min
    public Vector3 maxBounds;             // lim max
    public float smoothSpeed = 0.3f;    //suavizado de la cámara
    private Vector3 velocity = Vector3.zero;

    private void LateUpdate()
    {
        // Obtenemos la posición deseada de la cámara (solo en X y Z, la Y será constante)
        Vector3 desiredPosition = new Vector3(player.position.x, transform.position.y-3, player.position.z-5);

        // Limitar la posición deseada a los límites establecidos en los ejes X y Z
        float clampedX = Mathf.Clamp(desiredPosition.x, minBounds.x, maxBounds.x);
        float clampedZ = Mathf.Clamp(desiredPosition.z, minBounds.z, maxBounds.z);

        // Nueva posición de la cámara (Y se mantiene igual)
        Vector3 clampedPosition = new Vector3(clampedX, transform.position.y, clampedZ);

        // Movimiento suave hacia la posición deseada
        transform.position = Vector3.SmoothDamp(transform.position, clampedPosition, ref velocity, smoothSpeed);
    }
}

