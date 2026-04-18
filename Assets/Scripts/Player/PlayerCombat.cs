using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private int comboStep = 0;
    private float lastAttackTime;
    public float comboResetTime = 0.5f;

    void Update() {
        if (Time.time - lastAttackTime > comboResetTime) comboStep = 0;
        if (Input.GetKeyDown(KeyCode.Z)) ExecuteAttack();
    }

    void ExecuteAttack() {
        comboStep++;
        lastAttackTime = Time.time;

        switch (comboStep) {
            case 1: Debug.Log("Ataque Rápido (Fuego)"); break;
            case 2: Debug.Log("Ataque Medio (Fuego)"); break;
            case 3: 
                Debug.Log("Ataque Fuerte (Fuego)"); 
                comboStep = 0; // Reinicia combo
                break;
        }
        // Aquí los subordinados conectarán las animaciones
    }
}

