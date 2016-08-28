using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class paa : MonoBehaviour
{
    public int count;
    public Text moneyText;

    void Start()
    {
        count = -1;
    }

    void Update()
    {
        moneyText.text = "Money : " + SlotDesign.money + "yen";
    }

    public void OnClick()
    {
        count = 0;
        SlotDesign.money -= 1000;
    }

    public void OnPaper(){
        count = 1;
        SlotDesign.money -= 1000;
    }

    public void OnRock()
    {
        count = 2;
        SlotDesign.money -= 1000;
    }
}
