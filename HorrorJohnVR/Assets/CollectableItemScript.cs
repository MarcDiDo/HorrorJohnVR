using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItemScript : MonoBehaviour
{
    public static int itemCounter = 0;

    void Awake()
    {
        itemCounter = 0;
    }

    public void AddItemAndDestroy()
    {
        itemCounter++;

        // Find the TimerScript component in the scene and add time to the timer
        TimerScript timerScript = FindObjectOfType<TimerScript>();
        if (timerScript != null)
        {
            timerScript.AddTimeToTimer(60f);
        }
        Destroy(gameObject);
    }
}
