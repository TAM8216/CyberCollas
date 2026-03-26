using UnityEngine;
using UnityEngine.SceneManagement;

public class RooftopTrigger : MonoBehaviour
{
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

    void OnGUI()
    {
        if (jugadorDentro)
        {
            GUIStyle estilo = new GUIStyle(GUI.skin.label);
            estilo.fontSize = 20;
            estilo.normal.textColor = Color.black;

            GUI.Label(
                new Rect(Screen.width / 2 - 150, Screen.height - 100, 300, 30),
                "Bienvenido al rooftop",
                estilo
            );
        }
    }
}
