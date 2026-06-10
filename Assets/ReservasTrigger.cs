using UnityEngine;

public class ReservasTrigger : MonoBehaviour
{
    private bool jugadorDentro = false;
    private bool mostrarMensaje = false;

    private float tiempoMensaje = 6f;
    private float contador = 0f;

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
            mostrarMensaje = true;
            contador = tiempoMensaje;
        }

        if (mostrarMensaje)
        {
            contador -= Time.deltaTime;

            if (contador <= 0)
            {
                mostrarMensaje = false;
            }
        }
    }

    void OnGUI()
    {
        GUIStyle estilo = new GUIStyle(GUI.skin.label);
        estilo.fontSize = 20;
        estilo.normal.textColor = Color.white;
        estilo.alignment = TextAnchor.MiddleCenter;

        if (jugadorDentro && !mostrarMensaje)
        {
            GUI.Label(
                new Rect(Screen.width / 2 - 150, Screen.height - 100, 300, 30),
                "Presiona E para interactuar",
                estilo
            );
        }

        if (mostrarMensaje)
        {
            GUI.Box(
                new Rect(Screen.width / 2 - 250, Screen.height / 2 - 80, 500, 160),
                ""
            );

            GUI.Label(
                new Rect(Screen.width / 2 - 230, Screen.height / 2 - 60, 460, 120),
                "Bienvenido a CyberCollas.\n\nUn juego de sátira inspirado en un futuro distópico de La Paz y El Alto.",
                estilo
            );
        }
    }
}