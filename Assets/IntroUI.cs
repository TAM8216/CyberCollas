using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections; // <-- Esta es la línea que faltaba

public class IntroUI : MonoBehaviour
{
    public GameObject imageObject;
    public TextMeshProUGUI textObject;
    public float displayTime = 3f;

    void Start()
    {
        StartCoroutine(HideUI());
    }

    IEnumerator HideUI()
    {
        yield return new WaitForSeconds(displayTime);
        imageObject.SetActive(false);
        textObject.gameObject.SetActive(false);
    }
}

