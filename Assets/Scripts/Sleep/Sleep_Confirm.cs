using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sleep_Confirm : MonoBehaviour
{
    public Slider slider;

    public void OnConfirmClick() {
        SessionData.numSleepHoursInput = (int) slider.value;
        SceneManager.LoadScene(1);
    }
}
