using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public Text text;
    void OnTriggerEnter() {
        Debug.Log("Teleporter Triggers works");
        text.text = "You escaped";
        text.enabled = true;

        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }
}
