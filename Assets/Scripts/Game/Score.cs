using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public BirdMovement bird;
    public TextMeshProUGUI text;

    // Update Text
    public void Awake()
    {
        // Get Bird Script
        bird = GameObject.Find("Player").GetComponent<BirdMovement>();
    }
    public void Update()
    {
        // Update Score Text
        text.text = ("Score: " + bird.score);
    }
}
