
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpeedUpScript : MonoBehaviour
{
    public float initialSpeed = 10f; // Initial speed of the player
    public float speedIncreaseRate = 0.05f; // Speed increase rate (5% every 5 seconds)
    public float speedIncreaseInterval = 5f; // Speed increase interval (5 seconds)

    private float currentSpeed; // Current speed of the player
    private float timeSinceLastSpeedIncrease; // Time since the last speed increase

    void Start()
    {
        currentSpeed = initialSpeed; // Set the initial speed of the player
        timeSinceLastSpeedIncrease = 0f; // Reset the time since the last speed increase
    }

    void Update()
    {
        timeSinceLastSpeedIncrease += Time.deltaTime; // Increment the time since the last speed increase

        if (timeSinceLastSpeedIncrease >= speedIncreaseInterval) // Check if it's time to increase the speed
        {
            currentSpeed += currentSpeed * speedIncreaseRate; // Increase the current speed by the speed increase rate
            timeSinceLastSpeedIncrease = 0f; // Reset the time since the last speed increase
        }

        transform.position += Vector3.forward * currentSpeed * Time.deltaTime; // Move the player forward based on the current speed
    }
}