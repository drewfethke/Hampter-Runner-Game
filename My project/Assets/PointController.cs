/*using UnityEngine;

public class PointController : MonoBehaviour
{
    public float startingPointsPerSecond = 100f;
    public float pointsIncreasePerSecond = 10f;

    private float pointsPerSecond;
    private float points;

    private void Start()
    {
        pointsPerSecond = startingPointsPerSecond;
    }

    private void Update()
    {
        float pointsToAdd = pointsPerSecond * Time.deltaTime;
        points += pointsToAdd;
        // Call your own function here to update the player's score UI or perform other actions based on the points
        pointsPerSecond += pointsIncreasePerSecond * Time.deltaTime;
    }
}*/