using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public static float timerDuration = 30f; // Duration of the timer in seconds
    public static float currentTimer = 0f; // Current timer value

    void Start()
    {
        currentTimer = timerDuration; // Set the initial timer value
    }

    void Update()
    {


        // Check if the timer has reached zero
        if (currentTimer <= 0f)
        {
            // Perform the action when the timer runs out
            TimerExpired();
        }
        else
        {
            currentTimer -= Time.deltaTime;
        }
    }

    public void AddTimeToTimer(float timeToAdd)
    {
        currentTimer += timeToAdd; // Increase the timer by the specified amount
    }

    private void TimerExpired()
    {
        SceneManager.LoadScene(2);
    }
}

