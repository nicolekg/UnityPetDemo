using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Globals : MonoBehaviour
{
    // consts

    // state
    public static float hungerValue = 100f;
    public static float happinessValue = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("globals");
        // SceneManager.LoadScene("MainScene");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("loop");
        // this doesn't work for some reason
        // if (hungerValue < .01f || happinessValue < .01f) {
        //     Debug.Log("lose");
        //     SceneManager.LoadScene("LoseScene");
        // } 
    }
}
