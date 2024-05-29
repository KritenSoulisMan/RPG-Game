using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button multiplayerButton;
    public Button settingsButton;
    public Button exitGameButton;
    public Button backMenu;

    public Canvas mainMenu;
    public Canvas settings;
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        multiplayerButton.onClick.AddListener(Multiplayer);
        settingsButton.onClick.AddListener(Settings);
        exitGameButton.onClick.AddListener(ExitGame);
        // Убедимся, что канвас настроек выключен при старте
        settings.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Multiplayer()
    {
        Debug.Log("Load game functionality not implemented yet.");
    }

    public void Settings()
    {
        // Отключаем основной канвас и включаем канвас настроек
        mainMenu.gameObject.SetActive(false);
        settings.gameObject.SetActive(true);
    }

    public void Main_menu()
    {
        mainMenu.gameObject.SetActive(true);
        settings.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
