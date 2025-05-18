// using UnityEngine;
// using UnityEngine.UI;

// public class AnimalAudioController : MonoBehaviour
// {
//     public AudioSource audioSource;
//     private AnimalInteractionManager manager;
//     private bool estaVisible = false;

//     void Start()
//     {
//         manager = FindObjectOfType<AnimalInteractionManager>();
//         if (audioSource != null)
//         {
//             audioSource.Stop();
//         }
//     }

//     void Update()
//     {
//         bool activo = gameObject.activeInHierarchy;
//         if (activo != estaVisible)
//         {
//             estaVisible = activo;
//             if (estaVisible)
//             {
//                 manager.RegistrarAudioActivo(this);
//             }
//             else if (manager != null)
//             {
//                 manager.RegistrarAudioActivo(null);
//             }
//             manager.ActualizarBotonInteractivo(estaVisible);
//         }
//     }

//     public void ReproducirAudio()
//     {
//         if (audioSource != null)
//         {
//             if (!audioSource.isPlaying)
//                 audioSource.Play();
//             else
//                 audioSource.Pause();
//         }
//     }

//     public void DetenerAudio()
//     {
//         if (audioSource != null && audioSource.isPlaying)
//         {
//             audioSource.Stop();
//         }
//     }
// }
