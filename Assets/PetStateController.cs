using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStateController : MonoBehaviour
{
    private SpriteRenderer hungerRenderer;
    private Transform hungerTransform;

    private SpriteRenderer happinessRenderer;
    private Transform happinessTransform;

    // UI values
    private Color healthGreen = new Color(.5f,.88f,.5f,1);
    private Color healthYellow = new Color(.94f,.92f,.41f,1);
    private Color healthOrange = new Color(.95f, .55f, .12f, 1);
    private Color healthRed = new Color(1,0,.44f,1);

    // [SerializeField] private GameObject vibingBean;
    // [SerializeField] private GameObject neutralBean;
    // [SerializeField] private GameObject angryBean;

    // Start is called before the first frame update
    void Start()
    {
        GameObject hungerGameObj = GameObject.Find("Hunger");
        hungerRenderer = hungerGameObj.GetComponent<SpriteRenderer>();
        hungerTransform = hungerGameObj.transform;

        GameObject happinessGameObj = GameObject.Find("Happiness");
        happinessRenderer = happinessGameObj.GetComponent<SpriteRenderer>();
        happinessTransform = happinessGameObj.transform;
    }

    // Update is called once per frame
    void Update()
    {
        setHunger(Globals.hungerValue);
        setHappiness(Globals.happinessValue);
    }

    void setBar(float newVal, SpriteRenderer renderer, Transform transform) {
        Color newColor = healthGreen;
        if (newVal <= 0) {
            newVal = 0f;
            newColor = healthRed;
            // SetAngryBean();
        } else if (newVal <= 20) {
            newColor = healthRed;
            // SetAngryBean();
        } else if (newVal <= 50) {
            newColor = healthOrange;
            // SetNeutralBean();
        } else if (newVal <= 70) { 
            newColor = healthYellow;
            // SetNeutralBean();
        } else if (newVal < 100) {
            newColor = healthGreen;
            // SetVibingBean();
        } else if (newVal >= 100) {
            newVal = 100f;
            newColor = healthGreen;
            // SetVibingBean();
        }
        
        renderer.color = newColor;
        transform.localScale = new Vector3(newVal/100.0f, transform.localScale.y, 0);
        transform.localPosition = new Vector3((newVal-100)/100.0f/2, transform.localPosition.y, 0);
    }

    // 0-100
    void setHunger(float newHunger) {
        setBar(newHunger, hungerRenderer, hungerTransform);
    }

    void setHappiness(float newHappiness) {
        setBar(newHappiness, happinessRenderer, happinessTransform);
    }

    // void SetVibingBean() {
    //     vibingBean.GetComponent<Renderer>().enabled = true;
    //     neutralBean.GetComponent<Renderer>().enabled = false;
    //     angryBean.GetComponent<Renderer>().enabled = false;
    // }

    // void SetNeutralBean() {
    //     vibingBean.GetComponent<Renderer>().enabled = false;
    //     neutralBean.GetComponent<Renderer>().enabled = true;
    //     angryBean.GetComponent<Renderer>().enabled = false;
    // }

    // void SetAngryBean() {
    //     vibingBean.GetComponent<Renderer>().enabled = false;
    //     neutralBean.GetComponent<Renderer>().enabled = false;
    //     angryBean.GetComponent<Renderer>().enabled = true;
    // }
}
