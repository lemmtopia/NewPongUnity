using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector2 myVelocity;

    void Start()
    {
        // Set velocity to the left
        rb.linearVelocity = myVelocity;
    }

    void Update()
    {
        
    }
}
