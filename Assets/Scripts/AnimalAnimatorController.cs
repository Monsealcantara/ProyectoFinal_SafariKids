// using UnityEngine;
// using UnityEngine.UI;

// public class AnimalAnimationController : MonoBehaviour
// {
//     public Animator animator;
//     private AnimalInteractionManager manager;
//     private bool estaVisible = false;
//     private bool animacionActiva = false;

//     void Start()
//     {
//         manager = FindObjectOfType<AnimalInteractionManager>();
//         if (animator != null)
//             animator.enabled = false;
//     }

//     void Update()
//     {
//         bool activo = gameObject.activeInHierarchy;
//         if (activo != estaVisible)
//         {
//             estaVisible = activo;
//             if (estaVisible)
//             {
//                 manager.RegistrarAnimActivo(this);
//             }
//             else if (manager != null)
//             {
//                 manager.RegistrarAnimActivo(null);
//                 DetenerAnimacion();
//             }
//             manager.ActualizarBotonInteractivo(estaVisible);
//         }
//     }

//     public void ToggleAnimacion()
//     {
//         if (!estaVisible || animator == null) return;

//         if (animacionActiva)
//             DetenerAnimacion();
//         else
//             ActivarAnimacion();
//     }

//     private void ActivarAnimacion()
//     {
//         animator.enabled = true;
//         animacionActiva = true;
//     }

//     public void DetenerAnimacion()
//     {
//         animator.enabled = false;
//         animacionActiva = false;
//     }
// }

