using System;
using UnityEngine;

public class PlayerEvents : MonoBehaviour {
    // Eventos a los que los subordinados pueden "suscribirse" (Sonido, Partículas, Cámara)
    public static event Action OnPlayerJump;
    public static event Action OnPlayerDash;
    public static event Action<float> OnPlayerTakeDamage;

    public void TriggerJump() => OnPlayerJump?.Invoke();
    public void TriggerDash() => OnPlayerDash?.Invoke();
    public void TriggerDamage(float dmg) => OnPlayerTakeDamage?.Invoke(dmg);
}

