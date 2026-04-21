using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button button;

    public void Start()
    {
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Game");
    }
}
