using UnityEngine;

public class CameraManager : MonoBehaviour
{
    /*
    public static CameraManager instance;
    public GameObject currentRoom;
    public float changeCameraSpeed;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCamera();
    }

    void UpdateCamera()
    {
        if (currentRoom == null)
        {
            return;
        }
        Vector3 targetPosition = GetCameraTagetPosition();

        transform.position = Vector3.MoveTowards(transform.position, targetPosition.TimeDel);
    }

    Vector3 GetCameraTagetPosition()
    {
        if (currentRoom == null)
        {
            return Vector3.zero;
        }
        Vector3 targetPosition = currentRoom.GetRoomCentre();
        targetPosition.z = transform.position.z;
        return targetPosition;
    }*/
    /*
    public Transform player;           
    public Vector3 cameraOffset;             
    public float smoothSpeed = 0.3f;
    private Vector3 velocity = Vector3.zero;

    
    public Camera cameraUsing;
    GameManager manager;

    private void Start()
    {
        cameraUsing = manager.camera1;
        cameraUsing.transform.position = cameraOffset;
        cameraOffset = transform.localPosition-player.transform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = player.transform.position+cameraOffset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothSpeed);

    }*/

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

