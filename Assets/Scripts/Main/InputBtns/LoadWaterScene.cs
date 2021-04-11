using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadWaterScene : MonoBehaviour
{
    public void OnWaterClick() {
        SceneManager.LoadScene(2);
    }
}
