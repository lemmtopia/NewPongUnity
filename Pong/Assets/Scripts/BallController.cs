using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector2 myVelocity;
    [SerializeField] private float moveSpeed = 5f;

    void Start()
    {
        // Set velocity to the left
        rb.linearVelocity = myVelocity.normalized * moveSpeed;
    }

    void Update()
    {
        
    }
}
