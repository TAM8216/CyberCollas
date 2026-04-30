using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void NuevoJuego()
    {
        SceneManager.LoadScene("ingreso");
    }

    public void Continuar()
    {
        // Ejemplo simple (luego puedes mejorar con guardado real)
        SceneManager.LoadScene("rooftop");
    }

    public void Configuraciones()
    {
        SceneManager.LoadScene("config");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego...");
    }
}