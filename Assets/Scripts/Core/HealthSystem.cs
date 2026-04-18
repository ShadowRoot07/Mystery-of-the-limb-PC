using UnityEngine;

public class HealthSystem : MonoBehaviour {
    public float maxHealth = 100f;
    public float currentHealth;
    public ElementType weakness; // Debilidad del enemigo

    void Start() => currentHealth = maxHealth;

    public void TakeDamage(float amount, ElementType type) {
        float finalDamage = amount;

        // Si el ataque es del elemento al que es débil, daño x1.5
        if (type == weakness) {
            finalDamage *= 1.5f;
            Debug.Log($"{gameObject.name} sufrió daño crítico elemental!");
        }

        currentHealth -= finalDamage;
        
        if (currentHealth <= 0) Die();
    }

    void Die() {
        Debug.Log($"{gameObject.name} derrotado.");
        // Los subordinados pondrán aquí la animación de explosión o partículas
        Destroy(gameObject);
    }
}

