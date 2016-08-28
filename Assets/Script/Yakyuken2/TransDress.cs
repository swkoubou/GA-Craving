using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TransDress : MonoBehaviour
{
    public GameObject[] dress;
    int count;
    public SpriteRenderer congratulation;
    private float waitTime = 5f;

    void Start()
    {
        count = 0;
        congratulation.enabled = false;
        Debug.Log(dress.Length);
    }


    void Update()
    {
        if (congratulation.enabled)
        {
            waitTime -= Time.deltaTime;
            if(waitTime <= 0)
            {
                SceneManager.LoadScene("title");
            }
            return;
        }
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
            else if(dress[count].name == "gitl_leg")
            {
                count++;
            }
        }


        if (count < dress.Length - 2)
        {
            Transparent(dress[count]);
            count++;
        }
        else
        {
            congratulation.enabled = true;
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
