using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextScript : MonoBehaviour
{

    TextMeshProUGUI label;
    // Start is called before the first frame update
    void Awake()
    {
        label = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        label.text = "Items collected: " + CollectableItemScript.itemCounter.ToString() + "/6 ";
    }
}
