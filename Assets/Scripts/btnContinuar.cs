using UnityEngine;
using UnityEngine.UI;

public class btnContinuar : MonoBehaviour
{
    public GameObject advertenciaPanel;  // Panel del aviso de uso
    public GameObject iconosPanel;       // Panel con los íconos y nombre del animal
    public Button continuarButton;       // Botón "Continuar"

    void Start()
    {
        // Mostrar solo el panel de advertencia al iniciar
        advertenciaPanel.SetActive(true);
        iconosPanel.SetActive(false);

        // Añadir el listener al botón "Continuar"
        continuarButton.onClick.AddListener(OcultarAdvertenciaMostrarIconos);
    }

    void OcultarAdvertenciaMostrarIconos()
    {
        advertenciaPanel.SetActive(false);  // Ocultar aviso
        iconosPanel.SetActive(true);         // Mostrar íconos
    }
}
