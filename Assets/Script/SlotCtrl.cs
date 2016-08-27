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
            GameObject originChild = reelSlot[i].transform.FindChild("originImage").gameObject; //インスタンスの元となる場所

            for (int j = 9; j >= 0; j--)
            {
                GameObject child = reelSlot[i].transform.FindChild("Image" + j).gameObject; //子オブジェクト取得
                if (child.transform.position.y <= -200f)
                {
                    GameObject clone = Instantiate(child, originChild.transform.position, Quaternion.identity) as GameObject; //インスタンス生成
                    //clone.transform.parent = reelSlot[i].transform;
                    clone.transform.SetParent(reelSlot[i].transform); //親子を関連付ける
                    clone.name = child.name; //名前を消えるものと同じにする
                    clone.GetComponent<BoxCollider2D>().enabled = true; //Colliderをオンにする
                    Destroy(child); //用済みなので消す

                    //等間隔に配置されるよう、1つ下のリールの位置情報を取得して、y軸を弄る
                    Vector2 offset;
                    if (j == 9)
                    {
                        offset = reelSlot[i].transform.FindChild("Image" + 0).gameObject.transform.position;
                    }
                    else
                    {
                        offset = reelSlot[i].transform.FindChild("Image" + (j + 1)).gameObject.transform.position;
                    }
                    offset.y += 100;
                    clone.transform.position = offset;
                }
            }
        }
    }

    public void UnlimitedReel2(GameObject col)
    {
        GameObject parent = col.transform.parent.gameObject;
        GameObject originImage = parent.transform.FindChild("originImage").gameObject;
        GameObject clone = Instantiate(col, originImage.transform.position, Quaternion.identity) as GameObject; //インスタンス生成
        clone.transform.SetParent(parent.transform); //親子を関連付ける
        clone.name = col.name; //名前を消えるものと同じにする
        clone.GetComponent<BoxCollider2D>().enabled = true; //Colliderをオンにする
        Destroy(col); //用済みなので消す

        //string beforeReel = col.name.Substring(3, 4);
        //Debug.Log(beforeReel);
    }
}