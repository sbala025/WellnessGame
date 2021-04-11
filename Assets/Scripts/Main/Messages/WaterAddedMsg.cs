using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterAddedMsg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numCups = SessionData.numCupsWaterInput;

        if (numCups < 1) {
            gameObject.SetActive(false);
        }
        else {
            gameObject.SetActive(true);
            gameObject.GetComponent<Text>().text = "+ " + numCups + " Cups Drank";
            StartCoroutine(HideMessage());
        }
    }

    IEnumerator HideMessage() {
        yield return new WaitForSecondsRealtime(5f);
        gameObject.SetActive(false);
    }
}
