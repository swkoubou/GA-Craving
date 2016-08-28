using UnityEngine;
using System.Collections;

public class ReelJudge : MonoBehaviour {
    public GameObject[] reel;      //RayCast用のパネル取得
    public SlotDesign slotDesign;


    void Start () {
	    
	}
	
	
	void Update () {
        
	}

    public void Judge()
    {
        string[] panelName = new string[reel.Length];
        
        for (int i = 0; i < reel.Length; i++)
        {
            Ray ray = Camera.main.ScreenPointToRay(reel[i].transform.position);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, ray.direction);
            panelName[i] = hit.collider.tag;
            //hit.transform.position = reel[i].transform.position;
        }

        //bool top = false;
        if(panelName[0] == panelName[1] && panelName[1] ==  panelName[2])
        {
            //top = true;
            Probe(panelName[0]);
            slotDesign.Bliliant(0);
        }

        //bool horizontal = false;
        if (panelName[3] == panelName[4] && panelName[4] == panelName[5])
        {
            //horizontal = true;
            Probe(panelName[3]);
            slotDesign.Bliliant(1);
        }

        //bool bottom = false;
        if (panelName[6] == panelName[7] && panelName[7] == panelName[8])
        {
            //bottom = true;
            Probe(panelName[6]);
            slotDesign.Bliliant(2);
        }

        //bool slantLeft = false;
        if (panelName[0] == panelName[4] && panelName[4] == panelName[8])
        {
            //slantLeft = true;
            Probe(panelName[0]);
            slotDesign.Bliliant(3);
        }

        //bool slanRight = false;
        if (panelName[2] == panelName[4] && panelName[4] == panelName[6])
        {
            //slanRight = true;
            Probe(panelName[2]);
            slotDesign.Bliliant(4);
        }
    }

    void Probe(string tagName)
    {
        if(tagName == "replay")
        {
            SlotDesign.money += 100;
        }
        else if(tagName == "bel")
        {
            SlotDesign.money += 200;
        }
        else if (tagName == "chery")
        {
            SlotDesign.money += 500;
        }
        else if (tagName == "watermelon")
        {
            SlotDesign.money += 1000;
        }
        else if (tagName == "seven")
        {
            SlotDesign.money += 10000;
        }
        else
        {
            SlotDesign.money += 0;
        }
    }
}
