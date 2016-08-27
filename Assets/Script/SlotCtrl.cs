using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlotCtrl : MonoBehaviour
{
    public GameObject[] reelSlot = new GameObject[3]; //リールの大本を取得


    void Start()
    {
        
    }

    void Update()
    {
        ReelSlot();
        UnlimitedReel();
    }

    //スロットを回す
    void ReelSlot()
    {
        //reelSlotの数だけ回す
        for (int i = 0; i < reelSlot.Length; i++)
        {
            float reelSpeed = 0f; //リールを回すスピード
            if (i == 0)
            {
                reelSpeed = 400f;
            }
            else if (i == 1)
            {
                reelSpeed = 800f;
            }
            else if (i == 2)
            {
                reelSpeed = 1200f;
            }

            //reelSlotが持つ子オブジェクトの数だけ回す
            for (int j = 0; j < 10; j++)
            {
                GameObject child = reelSlot[i].transform.FindChild("Image" + j).gameObject; //子オブジェクト取得
                Vector2 childPos = child.transform.position; //位置情報を取り出す
                childPos.y -= Time.deltaTime * reelSpeed; //下に移動するように座標をいじる
                child.transform.position = childPos; //弄った座標を適用
            }
        }
    }

    void UnlimitedReel()
    {
        for (int i = 0; i < reelSlot.Length; i++)
        {
            GameObject originChild = reelSlot[i].transform.FindChild("originImage").gameObject;

            for (int j = 0; j < 10; j++)
            {
                GameObject child = reelSlot[i].transform.FindChild("Image" + j).gameObject; //子オブジェクト取得
                if (child.transform.position.y <= -200f)
                {
                    GameObject clone = Instantiate(child, originChild.transform.position, child.transform.rotation) as GameObject;
                    clone.transform.parent = reelSlot[i].transform;
                    clone.name = child.name;
                    Destroy(child);
                }
            }
        }
    }
}