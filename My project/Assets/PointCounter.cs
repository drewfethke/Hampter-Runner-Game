using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public int points = 0;
    public Text countText;

    void Update()
    {
        // Update the text component with the current points
        countText.text = "Count: " + points.ToString();
    }

    public void AddPoints(int amount)
    {
        // Add the specified amount of points to the counter
        points += amount;
    }
}