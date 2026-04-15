using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenuToggle : MonoBehaviour
{
    public GameObject settingsPanel;

    private bool isOpen = false;
    private bool isGameScene = false;

    void Start()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "MainMenu")
            isGameScene = false;
        else
            isGameScene = true;

        settingsPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        if (isOpen)
            CloseMenu();
        else
            OpenMenu();
    }

    void OpenMenu()
    {
        settingsPanel.SetActive(true);

        if (isGameScene)
            Time.timeScale = 0f;

        isOpen = true;
    }

    void CloseMenu()
    {
        settingsPanel.SetActive(false);

        if (isGameScene)
            Time.timeScale = 1f;

        isOpen = false;
    }
}