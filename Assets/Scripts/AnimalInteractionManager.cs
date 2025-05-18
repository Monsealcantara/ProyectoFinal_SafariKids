using UnityEngine;
using UnityEngine.UI;

public class AnimalInteractionManager : MonoBehaviour
{
    public Button botonInteractivo;

    private AnimalController animalActivo;

    void Start()
    {
        if (botonInteractivo != null)
            botonInteractivo.onClick.AddListener(ActivarAnimal);

        botonInteractivo.interactable = false;
    }

    public void SetAnimalActivo(AnimalController nuevoAnimal)
{
    if (animalActivo != null && animalActivo != nuevoAnimal)
    {
        Debug.Log($"Deteniendo animal anterior: {animalActivo.gameObject.name}");
        animalActivo.DetenerTodo();
    }

    animalActivo = nuevoAnimal;
    botonInteractivo.interactable = true;
    Debug.Log($"Animal activo: {animalActivo.gameObject.name}");
}

public void ClearAnimalActivo(AnimalController animal)
{
    if (animalActivo == animal)
    {
        Debug.Log($"Limpiando animal activo: {animalActivo.gameObject.name}");
        animalActivo.DetenerTodo();
        animalActivo = null;
        botonInteractivo.interactable = false;
    }
}


    public void ActivarAnimal()
    {
        if (animalActivo != null)
        {
            animalActivo.Activar();
        }
    }
}
