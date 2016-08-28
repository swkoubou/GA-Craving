using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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

    }

    public void DressBreak()
    {
        if (dress[0].transform.root.name == "mywife")
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
        }
        else if (dress[0].transform.root.name == "Girl1")
        {
            if (dress[count].name == "girl1_body_oko")
            {
                dress[count].GetComponent<SpriteRenderer>().enabled = true;
                count++;
            }
        }


        if (count < dress.Length - 1)
        {
            Transparent(dress[count]);
            count++;
        }
    }

    void Transparent(GameObject obj)
    {
        iTween.FadeTo(obj, iTween.Hash("alpha", 0f, "time", 1.5f));

    }

    public void OnReturnButton()
    {
        SceneManager.LoadScene("title");
    }
}
