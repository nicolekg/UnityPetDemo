using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedButtonOnClick : MonoBehaviour
{
    public Button feedButton;

	void Start () {
		Button btn = feedButton.GetComponent<Button>();
		btn.onClick.AddListener(FeedOnClick);
	}

	void FeedOnClick(){
		Globals.hungerValue = Mathf.Min(Globals.hungerValue + 40, 100);
	}
}
