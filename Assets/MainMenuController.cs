using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private void Start()
{
    Time.timeScale = 1f;

    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;
}
    public void NuevoJuego()
    {
        SceneManager.LoadScene("ingreso");
    }

    public void Continuar()
    {
        // Ejemplo simple (luego puedes mejorar con guardado real)
        SceneManager.LoadScene("city");
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