using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetButtonOnClick : MonoBehaviour
{
    public Button petButton;

	void Start () {
		Button btn = petButton.GetComponent<Button>();
		btn.onClick.AddListener(PetOnClick);
	}

	void PetOnClick(){
		Globals.happinessValue = Mathf.Min(Globals.happinessValue + 20, 100);
	}
}
