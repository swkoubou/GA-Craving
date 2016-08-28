using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class paa : MonoBehaviour
{
    public int count;
    public Text moneyText;
    public float waitTime;

    void Start()
    {
        count = -1;
        waitTime = 0f;
    }

    void Update()
    {
        moneyText.text = "Money : " + SlotDesign.money + "yen";
        waitTime -= Time.deltaTime;
    }

    public void OnClick()
    {
        if (waitTime <= 0)
        {
            waitTime = 2f;
            count = 0;
            SlotDesign.money -= 1000;
        }
    }

    public void OnPaper(){
        if (waitTime <= 0)
        {
            waitTime = 2f;
            count = 1;
            SlotDesign.money -= 1000;
        }
    }

    public void OnRock()
    {
        if (waitTime <= 0)
        {
            waitTime = 2f;
            count = 2;
            SlotDesign.money -= 1000;
        }
    }
}
