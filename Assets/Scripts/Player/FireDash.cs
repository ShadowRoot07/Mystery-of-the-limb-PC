using UnityEngine;
using System.Collections;

public class FireDash : MonoBehaviour {
    public float dashForce = 20f;
    public float dashDuration = 0.2f;
    public float fireDamage = 10f;
    public float areaRadius = 1.5f;
    public LayerMask enemyLayer;

    private Rigidbody2D rb;
    private bool isDashing = false;

    void Start() => rb = GetComponent<Rigidbody2D>();

    public void ExecuteDash(float direction) {
        if (!isDashing) StartCoroutine(DashCoroutine(direction));
    }

    IEnumerator DashCoroutine(float direction) {
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0; // Gravedad cero durante el dash
        rb.linearVelocity = new Vector2(direction * dashForce, 0);

        // Lógica de daño en área mientras dashea
        float elapsed = 0;
        while (elapsed < dashDuration) {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(transform.position, areaRadius, enemyLayer);
            foreach (var enemy in hitEnemies) {
                // Aquí llamamos al sistema de salud que crearemos abajo
                enemy.GetComponent<HealthSystem>()?.TakeDamage(fireDamage, ElementType.Fire);
            }
            elapsed += Time.deltaTime;
            yield return null;
        }

        rb.gravityScale = originalGravity;
        isDashing = false;
    }
}

