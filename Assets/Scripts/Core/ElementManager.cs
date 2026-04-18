using System.Collections.Generic;
using UnityEngine;

public enum ElementType { Fire, Air, Earth, Water, Dark, Light }

public class ElementManager : MonoBehaviour
{
    public List<ElementType> activeElements = new List<ElementType>();
    private const int MAX_ADDITIONAL_ELEMENTS = 2;

    void Awake() {
        // El fuego es obligatorio por diseño
        activeElements.Add(ElementType.Fire);
    }

    public bool EquipElement(ElementType newElement) {
        if (newElement == ElementType.Fire) return true;
        
        if (activeElements.Count <= MAX_ADDITIONAL_ELEMENTS && !activeElements.Contains(newElement)) {
            activeElements.Add(newElement);
            return true;
        }
        return false;
    }

    public bool HasElement(ElementType type) => activeElements.Contains(type);
}

