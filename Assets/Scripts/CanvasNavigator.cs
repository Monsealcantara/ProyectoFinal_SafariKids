using UnityEngine;
using UnityEngine.UI;

public class CanvasNavigator : MonoBehaviour
{
    public GameObject[] animalCanvases;   // Array de todos los canvases de animales
    private int currentCanvasIndex = 0;    // Índice del canvas actual

    public Button[] botonesX;             // Array de botones "X" para cerrar cada canvas

    void Start()
    {
        // Mostrar solo el primer canvas al inicio
        MostrarCanvas(currentCanvasIndex);

        // Asignar el evento a los botones "X" para cerrar cada canvas
        for (int i = 0; i < botonesX.Length; i++)
        {
            int index = i;  // Necesitamos capturar el índice de cada botón para asignarlo correctamente
            botonesX[i].onClick.AddListener(() => CerrarCanvas(index));
        }
    }

    // Método para cambiar al siguiente canvas
    public void SiguienteCanvas()
    {
        if (currentCanvasIndex < animalCanvases.Length - 1)
        {
            currentCanvasIndex++;
        }
        else
        {
            currentCanvasIndex = 0;  // Si llegamos al final, volvemos al primero
        }
        MostrarCanvas(currentCanvasIndex);
    }

    // Método para cambiar al canvas anterior
    public void AnteriorCanvas()
    {
        if (currentCanvasIndex > 0)
        {
            currentCanvasIndex--;
        }
        else
        {
            currentCanvasIndex = animalCanvases.Length - 1;  // Si estamos al principio, vamos al último
        }
        MostrarCanvas(currentCanvasIndex);
    }

    // Método que se encarga de mostrar el canvas correspondiente
    private void MostrarCanvas(int index)
    {
        // Ocultar todos los canvases
        foreach (GameObject canvas in animalCanvases)
        {
            canvas.SetActive(false);
        }

        // Mostrar solo el canvas en el índice actual
        animalCanvases[index].SetActive(true);
    }

    // Método que cierra el canvas correspondiente
    private void CerrarCanvas(int index)
    {
        animalCanvases[index].SetActive(false);  // Oculta el canvas actual
    }
}


// using UnityEngine;

// public class CanvasNavigator : MonoBehaviour
// {
//     public GameObject[] animalCanvases;   // Array de todos los canvases de animales
//     private int currentCanvasIndex = 0;    // Índice del canvas actual

//     void Start()
//     {
//         // Mostrar solo el primer canvas al inicio
//         MostrarCanvas(currentCanvasIndex);
//     }

//     // Método para cambiar al siguiente canvas
//     public void SiguienteCanvas()
//     {
//         if (currentCanvasIndex < animalCanvases.Length - 1)
//         {
//             currentCanvasIndex++;
//         }
//         else
//         {
//             currentCanvasIndex = 0;  // Si llegamos al final, volvemos al primero
//         }
//         MostrarCanvas(currentCanvasIndex);
//     }

//     // Método para cambiar al canvas anterior
//     public void AnteriorCanvas()
//     {
//         if (currentCanvasIndex > 0)
//         {
//             currentCanvasIndex--;
//         }
//         else
//         {
//             currentCanvasIndex = animalCanvases.Length - 1;  // Si estamos al principio, vamos al último
//         }
//         MostrarCanvas(currentCanvasIndex);
//     }

//     // Método que se encarga de mostrar el canvas correspondiente
//     private void MostrarCanvas(int index)
//     {
//         // Ocultar todos los canvases
//         foreach (GameObject canvas in animalCanvases)
//         {
//             canvas.SetActive(false);
//         }

//         // Mostrar solo el canvas en el índice actual
//         animalCanvases[index].SetActive(true);
//     }
// }
