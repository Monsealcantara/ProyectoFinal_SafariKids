using UnityEngine;
using UnityEngine.UI;  // Para acceder a los botones de la UI

public class AudioControl : MonoBehaviour
{
    public AudioSource audioSource;  // El AudioSource de la cámara
    public Button botonSilenciar;   // El botón para silenciar o desactivar el audio

    private bool audioSilenciado = false;  // Estado del audio (silenciado o no)

    private Color colorOriginal;    // Guardar el color original del botón

    void Start()
    {
        // Verifica que el AudioSource esté asignado
        if (audioSource == null)
        {
            audioSource = Camera.main.GetComponent<AudioSource>(); // Intentar obtenerlo desde la cámara si no se asignó
        }

        // Verifica que el botón esté asignado
        if (botonSilenciar != null)
        {
            botonSilenciar.onClick.AddListener(ToggleSilenciarAudio);
            colorOriginal = botonSilenciar.GetComponent<Image>().color;  // Guardamos el color original del botón
        }
    }

    // Silenciar o activar el audio
    void ToggleSilenciarAudio()
    {
        audioSilenciado = !audioSilenciado;  // Cambiar el estado de silenciar
        audioSource.mute = audioSilenciado;  // Cambiar el estado de silencio

        // Cambiar el color del botón según el estado
        CambiarColorBoton(audioSilenciado);
    }

    // Método para cambiar el color del botón
    void CambiarColorBoton(bool audioActivo)
    {
        Color colorNuevo = audioActivo ? Color.white : colorOriginal;  // Establecer el color según el estado

        // Cambiar el color del botón
        botonSilenciar.GetComponent<Image>().color = colorNuevo;
    }
}
