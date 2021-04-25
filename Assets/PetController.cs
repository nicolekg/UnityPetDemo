using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PetController : MonoBehaviour
{
    public float hungerDecay = .003f;
    public float happinessDecay = .005f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Globals.hungerValue = Globals.hungerValue - hungerDecay;
        Globals.happinessValue = Globals.happinessValue - happinessDecay;

        if (Globals.hungerValue < .01f || Globals.happinessValue < .01f) {
            Debug.Log("lose");
            SceneManager.LoadScene("LoseScene");
        } 
    }
}
