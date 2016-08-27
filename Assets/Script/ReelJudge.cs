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
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            panelName[i] = hit.collider.tag;
        }

        bool top = false;
        if(panelName[0] == panelName[1] && panelName[1] ==  panelName[2])
        {
            top = true;
            Probe(panelName[0]);
        }

        bool horizontal = false;
        if (panelName[3] == panelName[4] && panelName[4] == panelName[5])
        {
            horizontal = true;
            Probe(panelName[3]);
        }

        bool bottom = false;
        if (panelName[6] == panelName[7] && panelName[7] == panelName[8])
        {
            bottom = true;
            Probe(panelName[6]);
        }

        bool left = false;
        if (panelName[0] == panelName[3] && panelName[3] == panelName[5])
        {
            left = true;
            Probe(panelName[0]);
        }

        bool virtical = false;
        if (panelName[1] == panelName[4] && panelName[4] == panelName[7])
        {
            virtical = true;
            Probe(panelName[1]);
        }

        bool right = false;
        if (panelName[2] == panelName[5] && panelName[5] == panelName[8])
        {
            right = true;
            Probe(panelName[2]);
        }

        bool slantLeft = false;
        if (panelName[0] == panelName[4] && panelName[4] == panelName[8])
        {
            slantLeft = true;
            Probe(panelName[0]);
        }

        bool slanRight = false;
        if (panelName[2] == panelName[4] && panelName[4] == panelName[6])
        {
            slanRight = true;
            Probe(panelName[2]);
        }
    }

    void Probe(string tagName)
    {
        if(tagName == "replay")
        {
            slotDesign.money += 100;
        }
        else if(tagName == "bel")
        {
            slotDesign.money += 200;
        }
        else if (tagName == "chery")
        {
            slotDesign.money += 500;
        }
        else if (tagName == "watermelon")
        {
            slotDesign.money += 1000;
        }
        else if (tagName == "seven")
        {
            slotDesign.money += 10000;
        }
        else
        {
            slotDesign.money += 0;
        }
    }
}
