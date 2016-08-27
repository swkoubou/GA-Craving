using UnityEngine;
using System.Collections;

public class TransDress : MonoBehaviour
{
    public GameObject[] dress;
    int count;

    void Start()
    {
        count = 0;
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (dress[count].name == "ハート")
            {
                dress[count].GetComponent<SpriteRenderer>().enabled = true;
                count++;
            }
            else if (dress[count].name == "全裸")
            {
                dress[count + 1].GetComponent<SpriteRenderer>().enabled = true;
            }

            
            if (count < dress.Length - 1)
            {
                Transparent(dress[count]);
                count++;
            }
        }
    }

    void Transparent(GameObject obj)
    {
        iTween.FadeTo(obj, iTween.Hash("alpha", 0f, "time", 2f));

    }
}
