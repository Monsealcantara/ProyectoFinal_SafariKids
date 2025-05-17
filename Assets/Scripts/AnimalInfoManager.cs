using UnityEngine;
using UnityEngine.UI;

public class AnimalInfoManagerSimple : MonoBehaviour
{
    public GameObject canvasDatosCuriosos;  // Canvas de datos curiosos del animal
    public Button datosCuriososButton;      // Botón que mostrará los datos curiosos
    public Button botonCerrar;               // Botón "X" para cerrar el canvas

    void Start()
    {
        canvasDatosCuriosos.SetActive(false);

        datosCuriososButton.onClick.AddListener(MostrarDatosCuriosos);
        if (botonCerrar != null)
        {
            botonCerrar.onClick.AddListener(CerrarDatosCuriosos);
        }
    }

    void Update()
    {
        datosCuriososButton.gameObject.SetActive(gameObject.activeInHierarchy);

        if (!gameObject.activeInHierarchy && canvasDatosCuriosos.activeSelf)
        {
            canvasDatosCuriosos.SetActive(false);
        }
    }

    void MostrarDatosCuriosos()
    {
        canvasDatosCuriosos.SetActive(true);
    }

    void CerrarDatosCuriosos()
    {
        canvasDatosCuriosos.SetActive(false);
    }
}
