using UnityEngine;

public class ReservasTrigger : MonoBehaviour
{
    public string urlReservas = "http://iskaypav.test/reserva/crear"; // reemplaza por tu URL real
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
            Application.OpenURL(urlReservas);
        }
    }

    void OnGUI()
{
    if (jugadorDentro)
    {
        GUIStyle estilo = new GUIStyle(GUI.skin.label);
        estilo.fontSize = 20; // Cambia este número para ajustar el tamaño
        estilo.normal.textColor = Color.white; // Puedes cambiar el color también

        GUI.Label(
            new Rect(Screen.width / 2 - 150, Screen.height - 100, 300, 30),
            "Presiona E para ir a reservas",
            estilo
        );
    }
}
}
