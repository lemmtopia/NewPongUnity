using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private float yPosition;
    private Vector3 myPosition;

    void Start()
    {
        myPosition = transform.position;
    }

    void Update()
    {
        // Changing my Y position
        myPosition.y = yPosition;

        // Change the Paddle position
        transform.position = myPosition;
    }
}
