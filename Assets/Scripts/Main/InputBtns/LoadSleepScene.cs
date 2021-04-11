using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSleepScene : MonoBehaviour
{
    public void OnSleepClick() {
        SceneManager.LoadScene(3);
    }
}
