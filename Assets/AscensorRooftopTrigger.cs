using UnityEngine;
using UnityEngine.SceneManagement;

public class AscensorRooftopTrigger : MonoBehaviour
{
    public string nombreEscenaDestino = "ingreso"; // Cambia por el nombre exacto
    private bool jugadorDentro = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorDentro = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorDentro = false;
        }
    }

    void Update()
    {
        if (jugadorDentro && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(nombreEscenaDestino);
        }
    }

    void OnGUI()
    {
        if (jugadorDentro)
        {
            GUIStyle estilo = new GUIStyle(GUI.skin.label);
            estilo.fontSize = 20;
            estilo.normal.textColor = Color.black;

            GUI.Label(
                new Rect(Screen.width / 4 - 150, Screen.height - 100, 300, 30),
                "Presiona E para ir al ingreso",
                estilo
            );
        }
    }
}