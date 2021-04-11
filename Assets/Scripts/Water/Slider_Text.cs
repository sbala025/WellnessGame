using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Slider_Text : MonoBehaviour
{
    // Update Text and Value when slider is changed!
    public void OnSliderChange(float value) {
        gameObject.GetComponent<Text>().text = value + " Cups";
    }

}
