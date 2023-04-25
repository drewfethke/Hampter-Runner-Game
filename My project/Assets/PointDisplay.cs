/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointDisplay : MonoBehaviour
{
    private Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<Text>();
    }

    private void Update()
    {
        // Call your own function here to get the player's current score
        int points = GetPlayerScore();
        textComponent.text = "Points: " + points.ToString();
    }

    private int GetPlayerScore()
    {
        // Replace this with your own logic to get the player's score
        // For example, you could use a static variable, a GameManager, or another script
        return (int)PointController.points;
    }
}*/