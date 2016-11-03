using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlotDesign : MonoBehaviour
{
    public ButtonCtrl buttonCtrl;
    public Text moneyText;
    static public int money = 0;
    public Image[] Whiterod;
    private float waitTime;
    

    void Start()
    {
        waitTime = 2f;
    }


    void Update()
    {
        //公式チートコード
        if(Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.Return))
        {
            money = 100000;
        }

        moneyText.text = "Money : " + money + "yen";
        if (buttonCtrl.isStartButton)
        {
            for (int i = 0; i < Whiterod.Length; i++)
            {
                Whiterod[i].GetComponent<Image>().color = new Color(255, 255, 255, 255);
            }
        }

    }

    public void Bliliant(int array)
    {
        Whiterod[array].GetComponent<Image>().color = new Color(255, 255, 0, 255);
        //iTween.FadeTo(Whiterod[array].gameObject, iTween.Hash("red", 255f, "green", 255f, "blue", 0f));
        buttonCtrl.SEBox.PlayOneShot(buttonCtrl.hit, 3f);
    }
}
