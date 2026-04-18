# Mystery of Limbo

**Mystery of Limbo** es un proyecto de videojuego 2D del género **Metroidvania**, desarrollado en **Unity 6.0 LTS**. 

Este repositorio contiene la estructura base, lógica de scripts y configuración del núcleo del juego.

---

## 🛠 Especificaciones Técnicas
* **Motor:** Unity 6 (6000.0.0f1)
* **Lenguaje:** C#
* **Arquitectura:** Basada en prefabs y sistemas modulares.

---

## ⚖️ Reglas de Contribución (Protocolo)

Para mantener el orden y la integridad del proyecto, todos los subordinados deben seguir estas normas:

1.  **Flujo de Git:** * No se permite hacer `push` directo a la rama `main`.
    * Toda mejora o cambio debe hacerse en una rama independiente y enviarse mediante un **Pull Request (PR)**.
    * El líder del equipo (@ShadowRoot07) revisará y aprobará los PRs.

2.  **Organización de Archivos:**
    * Respetar estrictamente la jerarquía de carpetas (`Assets/Scripts`, `Assets/Prefabs`, etc.).
    * No mover archivos existentes sin previo aviso, ya que esto rompe las referencias de los metadatos de Unity.

3.  **Estándares de Código:**
    * Nombres de clases en `PascalCase`.
    * Variables privadas en `_camelCase`.
    * Todo script debe estar debidamente documentado con comentarios breves sobre su funcionalidad.

4.  **Assets Pesados:**
    * Asegurarse de tener configurado **Git LFS** antes de subir texturas, audios o modelos para evitar corromper el repositorio.

---

## 🚀 Instalación para el Equipo

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/ShadowRoot07/Mystery-of-the-limb-PC.git
    ```

2. Abrir el proyecto directamente desde el Unity Hub usando la versión 6.0 LTS.

3. Asegurarse de que el Project Settings no marque errores de compilación antes de empezar a trabajar.

**Nota para el equipo:** He adelantado la arquitectura base en C#. Al abrir el proyecto por primera vez, dejen que Unity genere los archivos .meta antes de hacer su primer commit.
