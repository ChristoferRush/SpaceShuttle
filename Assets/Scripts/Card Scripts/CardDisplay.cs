using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

    public Card card;
    public Text nameText;
    public Text costText;
    public Text firePowerText;
    public Text defenceText;
    public Text descriptionText;

	// Use this for initialization
	void Start () {
        nameText.text = card.name.ToString();
        costText.text = card.cost.ToString();
        firePowerText.text = card.firePower.ToString();
        defenceText.text = card.defence.ToString();
        descriptionText.text = card.description.ToString();
         
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
