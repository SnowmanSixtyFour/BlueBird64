using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private Button
        startButton, quitButton,
        blueBirdSequel;

    public void Start()
    {
        // Button Click Events
        startButton.onClick.AddListener(StartClicked);
        quitButton.onClick.AddListener(QuitClicked);

        blueBirdSequel.onClick.AddListener(() =>
        {
            Application.OpenURL("https://snowman64.itch.io/bluebird64-x2");
        });
    }

    public void StartClicked()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitClicked()
    {
        // Quit Game
        Application.Quit();
    }
}
