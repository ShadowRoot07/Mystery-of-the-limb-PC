using UnityEngine;

public class BasicPatrolAI : MonoBehaviour {
    public float speed = 2f;
    public Transform wallCheck;
    public LayerMask groundLayer;
    
    private bool movingRight = true;

    void Update() {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // Raycast para detectar paredes o finales de plataforma
        RaycastHit2D groundInfo = Physics2D.Raycast(wallCheck.position, Vector2.down, 2f, groundLayer);
        RaycastHit2D wallInfo = Physics2D.Raycast(wallCheck.position, movingRight ? Vector2.right : Vector2.left, 0.5f, groundLayer);

        if (groundInfo.collider == false || wallInfo.collider == true) {
            Flip();
        }
    }

    void Flip() {
        movingRight = !movingRight;
        transform.eulerAngles = movingRight ? new Vector3(0, 0, 0) : new Vector3(0, 180, 0);
    }
}

