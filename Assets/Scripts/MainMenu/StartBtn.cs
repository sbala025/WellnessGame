using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{

    public void OnStartButtonClick() {
        SceneManager.LoadScene(1);
    }
}
