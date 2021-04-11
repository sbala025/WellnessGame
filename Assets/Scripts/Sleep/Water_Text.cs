using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Water_Text : MonoBehaviour
{

    // Update Text and Value when slider is changed!
    public void OnSliderChange(float value) {
        gameObject.GetComponent<Text>().text = value + " Hour(s)";
        SessionData.numSleepHoursInput = (int) value;
    }

}
