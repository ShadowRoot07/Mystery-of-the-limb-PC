using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item {
    public string name;
    public Sprite icon; // Los subordinados pondrán la textura aquí
    public bool isEquippable;
    public ElementType associatedElement;
}

public class InventorySystem : MonoBehaviour {
    public int slotCount = 9; // Estilo hotbar de Minecraft
    public List<Item> items = new List<Item>();

    public bool AddItem(Item newItem) {
        if (items.Count < slotCount) {
            items.Add(newItem);
            Debug.Log($"Objeto {newItem.name} recolectado.");
            return true;
        }
        return false;
    }

    public void UseItem(int index) {
        if (index < items.Count) {
            // Lógica estilo MM Zero: Al usarlo, se activa una mejora permanente o temporal
            Debug.Log($"Usando {items[index].name}");
        }
    }
}

