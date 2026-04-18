using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 8f;
    public float jumpForce = 12f;
    
    private Rigidbody2D rb;
    private ElementManager elementManager;
    
    private int jumpCount = 0;
    private int maxJumps = 1;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        elementManager = GetComponent<ElementManager>();
    }

    void Update() {
        HandleMovement();
        HandleJump();
    }

    void HandleMovement() {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }

    void HandleJump() {
        // Lógica de Aire: +1 salto si está equipado
        maxJumps = elementManager.HasElement(ElementType.Air) ? 2 : 1;
        float heightBonus = elementManager.HasElement(ElementType.Air) ? 1.1f : 1.0f;

        if (Input.GetButtonDown("Jump") && jumpCount < maxJumps) {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce * heightBonus);
            jumpCount++;
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ground")) jumpCount = 0;
    }
}

