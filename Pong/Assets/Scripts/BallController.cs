using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed = 5f;

    private Vector2 startVelocity;

    void Start()
    {
        // Set a random velocity (if it is (0, 0) , default to (1, 1))
        int xRandom = Random.Range(-1, 1);
        int yRandom = Random.Range(-1, 1);
        startVelocity.x = (xRandom != 0) ? (float)xRandom : 1f;
        startVelocity.y = (yRandom != 0) ? (float)yRandom : 1f;

        // Set velocity to the left
        rb.linearVelocity = startVelocity.normalized * moveSpeed;
    }

    void Update()
    {
        
    }
}
