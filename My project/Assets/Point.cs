/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Point : MonoBehaviour
{
    private int pointsPerSecond = 100;
    private float pointIncreaseInterval = 10f;
    private float pointIncreaseAmount = 25f;
    private float timeSinceLastPointIncrease = 0f;

    private void Update()
    {
        timeSinceLastPointIncrease += Time.deltaTime;
        if (timeSinceLastPointIncrease >= pointIncreaseInterval)
        {
            pointsPerSecond += (int)pointIncreaseAmount;
            timeSinceLastPointIncrease = 0f;
        }
        GameController.instance.AddPoints(pointsPerSecond * Time.deltaTime);
    }
}*/

