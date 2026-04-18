using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(CircleCollider2D))]
public class BouncyObject : MonoBehaviour {
    [Range(0, 1)] public float bounciness = 0.6f;
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        // Los subordinados pueden ajustar el material físico desde Unity, 
        // pero nosotros controlamos la lógica de impacto aquí.
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.relativeVelocity.magnitude > 5f) {
            // Ejecutar evento de animación de "impacto fuerte"
            TriggerLandingEffect(collision.relativeVelocity.magnitude);
        }
    }

    void TriggerLandingEffect(float force) {
        Debug.Log($"Objeto rebotó con fuerza: {force}");
        // Aquí el equipo de arte conectará el Squash & Stretch
    }
}

