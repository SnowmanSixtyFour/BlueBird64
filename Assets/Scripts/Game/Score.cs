using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Bird bird;
    public TextMeshProUGUI text;

    // Update Text
    public void Awake()
    {
        // Get Bird Script
        bird = GameObject.Find("Player").GetComponent<Bird>();
    }
    public void Update()
    {
        // Update Score Text
        text.text = ("Score: " + bird.score);
    }
}
