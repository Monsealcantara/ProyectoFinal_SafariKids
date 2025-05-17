using UnityEngine;
using UnityEngine.UI;

public class AnimalAudioController : MonoBehaviour
{
    public AudioSource audioSource;          // AudioSource con el audio del animal
    public Button botonInteractivo;          // Botón interactivo general
    public bool estaVisible = false;         // Estado de visibilidad del Image Target

    void Start()
    {
        if (botonInteractivo != null)
        {
            botonInteractivo.onClick.AddListener(ReproducirAudio);
        }

        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }

    void Update()
    {
        estaVisible = gameObject.activeInHierarchy;

        if (botonInteractivo != null)
        {
            botonInteractivo.interactable = estaVisible;
        }
    }

    public void ReproducirAudio()
    {
        if (estaVisible && audioSource != null)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            else
            {
                audioSource.Stop();
            }
        }
    }
}
