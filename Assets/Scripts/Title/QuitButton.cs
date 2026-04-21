using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public Button button;

    public void Start()
    {
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        // Quit Game
        Application.Quit();
    }
}
