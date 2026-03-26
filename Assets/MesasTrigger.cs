using UnityEngine;

public class MesasTrigger : MonoBehaviour
{
    public string urlReservas = "http://iskaypav.test/comensal/reservar"; // reemplaza por tu URL real
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
        estilo.normal.textColor = Color.black; // Puedes cambiar el color también

        GUI.Label(
            new Rect(Screen.width / 4 - 150, Screen.height - 100, 300, 30),
            "Presiona E para reservar mesa",
            estilo
        );
    }
}

}
