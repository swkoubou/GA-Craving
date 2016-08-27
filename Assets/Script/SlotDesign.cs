using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlotDesign : MonoBehaviour {
    public Text moneyText;
    public int money;
	
	void Start () {
        money = 0;
	}
	
	
	void Update () {
        moneyText.text = "Money : " + money + "yen";
	}
}
