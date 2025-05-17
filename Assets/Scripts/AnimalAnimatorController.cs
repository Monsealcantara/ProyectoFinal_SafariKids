using UnityEngine;
using UnityEngine.UI;

public class AnimalAnimationController : MonoBehaviour
{
    public Animator animator;             // Animator del modelo animal
    public Button botonInteractivo;      // Botón interactivo común
    private bool estaVisible = false;    // Controla si el Image Target está visible
    private bool animacionActiva = false;

    void Start()
    {
        if (botonInteractivo != null)
        {
            botonInteractivo.onClick.AddListener(ToggleAnimacion);
        }

        if (animator != null)
        {
            animator.enabled = false;  // La animación inicia desactivada
        }
    }

    void Update()
    {
        estaVisible = gameObject.activeInHierarchy;

        // Opcional: habilitar o deshabilitar el botón según visibilidad
        if (botonInteractivo != null)
        {
            botonInteractivo.interactable = estaVisible;
        }

        // Si el marcador no está visible, asegurarse de detener animación
        if (!estaVisible && animacionActiva)
        {
            DetenerAnimacion();
        }
    }

    public void ToggleAnimacion()
    {
        if (!estaVisible || animator == null) return;

        if (animacionActiva)
        {
            DetenerAnimacion();
        }
        else
        {
            ActivarAnimacion();
        }
    }

    private void ActivarAnimacion()
    {
        animator.enabled = true;
        animacionActiva = true;
    }

    private void DetenerAnimacion()
    {
        animator.enabled = false;
        animacionActiva = false;
    }
}
