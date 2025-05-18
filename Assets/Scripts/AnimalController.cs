using UnityEngine;

public class AnimalController : MonoBehaviour
{
    public AudioSource audioSource;     // Asignar solo si el animal tiene audio
    public Animator animator;           // Asignar solo si el animal tiene animación

    private bool estaVisible = false;

    private AnimalInteractionManager manager;

    void Start()
    {
        manager = FindObjectOfType<AnimalInteractionManager>();

        if (audioSource != null)
            audioSource.Stop();

        if (animator != null)
            animator.enabled = false;
    }

   void Update()
{
    bool activo = gameObject.activeInHierarchy;

    if (activo != estaVisible)
    {
        estaVisible = activo;
        Debug.Log($"{gameObject.name} visibilidad: {estaVisible}");

        if (estaVisible)
        {
            manager.SetAnimalActivo(this);
        }
        else if (manager != null)
        {
            manager.ClearAnimalActivo(this);
            DetenerTodo();
        }
    }
}


    public void Activar()
    {
        if (audioSource != null)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
            else
                audioSource.Pause();
        }
        else if (animator != null)
        {
            animator.enabled = !animator.enabled;
        }
    }

    public void DetenerTodo()
    {
        if (audioSource != null && audioSource.isPlaying)
            audioSource.Stop();

        if (animator != null && animator.enabled)
            animator.enabled = false;
    }
}
