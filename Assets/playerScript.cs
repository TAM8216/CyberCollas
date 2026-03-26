using UnityEngine;

public class playerScript : MonoBehaviour
{
    Transform cam;
    CharacterController control;

    public float speedCam;
    public float playerSpeed;
    public GameObject pausePanel;
    private bool isPaused = false;
    
    float camRotation = 0;

    private void Start()
    {
        cam = transform.GetChild(0).GetComponent<Transform>();
        control = GetComponent<CharacterController>();

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(new Vector3(0, mouseX, 0) * speedCam * Time.deltaTime);

        camRotation -= mouseY * speedCam * Time.deltaTime;
        camRotation = Mathf.Clamp(camRotation, -90, 90);
        cam.localRotation = Quaternion.Euler(new Vector3(camRotation, 0, 0));

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = (transform.right * moveX + transform.forward * moveZ) * playerSpeed * Time.deltaTime;

        control.Move(movement);

    }
    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; // Pausar juego
            pausePanel.SetActive(true); // Mostrar mensaje
        }
        else
        {
            Time.timeScale = 1f; // Reanudar juego
            pausePanel.SetActive(false); // Ocultar mensaje
        }
    }
}
