using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConfirmBtn : MonoBehaviour
{
    public Slider slider;

    public void OnConfirmClick() {
        SessionData.numCupsWaterInput = (int) slider.value;
        SceneManager.LoadScene(1);
    }
}
