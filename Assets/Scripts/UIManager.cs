using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject advertenciaPanel;
    public GameObject iconosPanel;
    public GameObject datosCuriososPanel;
    public GameObject configPanel;
    public GameObject ayudaPanel;

    public Button continuarButton;
    public Button botonMostrarDatos;
    public Button botonCerrarDatos;

    public Button botonAbrirConfig;
    public Button botonCerrarConfig;

    public Button botonAbrirAyuda;
    public Button botonCerrarAyuda;

    void Start()
    {
        // Estado inicial
        advertenciaPanel.SetActive(true);
        iconosPanel.SetActive(false);
        datosCuriososPanel.SetActive(false);
        configPanel.SetActive(false);
        ayudaPanel.SetActive(false);

        // Asignar listeners
        continuarButton.onClick.AddListener(MostrarIconos);

        botonMostrarDatos.onClick.AddListener(MostrarDatosCuriosos);
        // botonCerrarDatos.onClick.AddListener(CerrarDatosCuriosos);

        botonAbrirConfig.onClick.AddListener(MostrarConfig);
        botonCerrarConfig.onClick.AddListener(CerrarConfig);

        botonAbrirAyuda.onClick.AddListener(MostrarAyuda);
        botonCerrarAyuda.onClick.AddListener(CerrarAyuda);
    }

    void MostrarIconos()
    {
        advertenciaPanel.SetActive(false);
        iconosPanel.SetActive(true);
    }

    void MostrarDatosCuriosos()
    {
        datosCuriososPanel.SetActive(true);
    }

    // void CerrarDatosCuriosos()
    // {
    //     datosCuriososPanel.SetActive(false);
    // }

    void MostrarConfig()
    {
        configPanel.SetActive(true);
    }

    void CerrarConfig()
    {
        configPanel.SetActive(false);
    }

    void MostrarAyuda()
    {
        ayudaPanel.SetActive(true);
    }

    void CerrarAyuda()
    {
        ayudaPanel.SetActive(false);
    }
}


// using UnityEngine;
// using UnityEngine.UI;

// public class UIManager : MonoBehaviour
// {
//     public GameObject advertenciaPanel;
//     public GameObject iconosPanel;
//     public GameObject datosCuriososPanel;
//     public GameObject configPanel;
//     public GameObject ayudaPanel;

//     public Button continuarButton;
//     public Button botonMostrarDatos;
//     public Button botonCerrarDatos;

//     public Button botonAbrirConfig;
//     public Button botonCerrarConfig;

//     public Button botonAbrirAyuda;
//     public Button botonCerrarAyuda;

//     void Start()
//     {
//         // Estado inicial
//         advertenciaPanel.SetActive(true);
//         iconosPanel.SetActive(false);
//         datosCuriososPanel.SetActive(false);
//         configPanel.SetActive(false);
//         ayudaPanel.SetActive(false);

//         // Asignar listeners
//         continuarButton.onClick.AddListener(MostrarIconos);

//         botonMostrarDatos.onClick.AddListener(MostrarDatosCuriosos);
//         botonCerrarDatos.onClick.AddListener(CerrarDatosCuriosos);

//         botonAbrirConfig.onClick.AddListener(MostrarConfig);
//         botonCerrarConfig.onClick.AddListener(CerrarConfig);

//         // botonAbrirAyuda.onClick.AddListener(MostrarAyuda);
//         botonCerrarAyuda.onClick.AddListener(CerrarAyuda);
//     }

//     void MostrarIconos()
//     {
//         advertenciaPanel.SetActive(false);
//         iconosPanel.SetActive(true);
//     }

//     void MostrarDatosCuriosos()
//     {
//         datosCuriososPanel.SetActive(true);
//     }

//     void CerrarDatosCuriosos()
//     {
//         datosCuriososPanel.SetActive(false);
//     }

//     void MostrarConfig()
//     {
//         configPanel.SetActive(true);
//     }

//     void CerrarConfig()
//     {
//         configPanel.SetActive(false);
//     }

//     void MostrarAyuda()
//     {
//         ayudaPanel.SetActive(true);
//     }

//     void CerrarAyuda()
//     {
//         ayudaPanel.SetActive(false);
//     }
// }


// using UnityEngine;
// using UnityEngine.UI;

// public class UIManager : MonoBehaviour
// {
//     public GameObject advertenciaPanel;      // Canvas o panel de aviso
//     public GameObject iconosPanel;           // Canvas o panel de iconos
//     public GameObject datosCuriososPanel;    // Canvas o panel de datos curiosos

//     public Button continuarButton;            // Botón continuar en aviso
//     public Button botonMostrarDatos;          // Botón para mostrar datos curiosos
//     public Button botonCerrarDatos;           // Botón "X" para cerrar datos curiosos

//     void Start()
//     {
//         // Inicialmente solo el aviso visible
//         advertenciaPanel.SetActive(true);
//         iconosPanel.SetActive(false);
//         datosCuriososPanel.SetActive(false);

//         continuarButton.onClick.AddListener(MostrarIconos);
//         botonMostrarDatos.onClick.AddListener(MostrarDatosCuriosos);
//         botonCerrarDatos.onClick.AddListener(CerrarDatosCuriosos);
//     }

//     void MostrarIconos()
//     {
//         advertenciaPanel.SetActive(false);
//         iconosPanel.SetActive(true);
//         datosCuriososPanel.SetActive(false);
//     }

//     void MostrarDatosCuriosos()
//     {
//         datosCuriososPanel.SetActive(true);
//         // No ocultamos iconos para que siga visible
//     }

//     void CerrarDatosCuriosos()
//     {
//         datosCuriososPanel.SetActive(false);
//         // No hacemos nada con iconos, que siga visible
//     }
// }



// using UnityEngine;
// using UnityEngine.UI;

// public class UIManager : MonoBehaviour
// {
//     public GameObject advertenciaPanel;   // Canvas o panel de aviso
//     public GameObject iconosPanel;        // Canvas o panel de iconos
//     public GameObject otroPanel;           // Canvas o panel nuevo que quieres mostrar

//     public Button continuarButton;         // Botón continuar en aviso
//     public Button botonMostrarOtroPanel;   // Botón dentro del canvas iconos para mostrar otro canvas

//     void Start()
//     {
//         // Inicialmente mostramos solo aviso
//         advertenciaPanel.SetActive(true);
//         iconosPanel.SetActive(false);
//         otroPanel.SetActive(false);

//         // Agregamos listeners a los botones
//         continuarButton.onClick.AddListener(MostrarIconos);
//         botonMostrarOtroPanel.onClick.AddListener(MostrarOtroPanel);
//     }

//     void MostrarIconos()
//     {
//         advertenciaPanel.SetActive(false);
//         iconosPanel.SetActive(true);
//         otroPanel.SetActive(false);
//     }

//     void MostrarOtroPanel()
//     {
//         iconosPanel.SetActive(false);
//         otroPanel.SetActive(true);
//     }
// }
