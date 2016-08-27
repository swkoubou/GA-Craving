using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlotCtrl : MonoBehaviour
{
    public GameObject[] rootReel;   //リールの大本を取得
    public ButtonCtrl buttonCtrl;   //ボタン操作script
    public ReelJudge reelJudge;


    void Start()
    {
        
    }

    void Update()
    {
        //スタートボタンを押していないなら何もしない
        if (!buttonCtrl.isStartButton)
        {
            return;
        }
        //Left, Center, Rightを全て押したら
        else if(buttonCtrl.IsAllButtonOn())
        {
            reelJudge.Judge(); //当たり目判定
            buttonCtrl.AllButtonFalse(); //全てのボタンをfalseにする
        }
        
        ReelSlot();
        UnlimitedReel();
    }

    //スロットを回す
    void ReelSlot()
    {
        //reelSlotの数だけ回す
        for (int i = 0; i < rootReel.Length; i++)
        {
            //ボタンを押したリールを止める
            if (i == 0 && buttonCtrl.isLeftButton)
            {
                continue;
            }
            else if (i == 1 && buttonCtrl.isCenterButton)
            {
                continue;
            }
            else if (i == 2 && buttonCtrl.isRightButton)
            {
                continue;
            }

            //リールを回すスピード
            float reelSpeed = 0f; 
            if (i == 0)
            {
                reelSpeed = 6f;
            }
            else if (i == 1)
            {
                reelSpeed = 12f;
            }
            else if (i == 2)
            {
                reelSpeed = 36f;
            }

            //reelSlotが持つ子オブジェクトの数だけ回す
            for (int j = 0; j < 10; j++)
            {
                GameObject child = rootReel[i].transform.FindChild("Image" + j).gameObject; //子オブジェクト取得
                Vector2 childPos = child.transform.position; //位置情報を取り出す
                childPos.y -= Time.deltaTime * reelSpeed; //下に移動するように座標をいじる
                child.transform.position = childPos; //弄った座標を適用
            }
        }
    }

    void UnlimitedReel()
    {
        for (int i = 0; i < rootReel.Length; i++)
        {
            GameObject originChild = rootReel[i].transform.FindChild("originImage").gameObject; //インスタンスの元となる場所

            for (int j = 9; j >= 0; j--)
            {
                GameObject child = rootReel[i].transform.FindChild("Image" + j).gameObject; //子オブジェクト取得
                if (child.transform.position.y <= -10f)
                {
                    GameObject clone = Instantiate(child, originChild.transform.position, Quaternion.identity) as GameObject; //インスタンス生成
                    //clone.transform.parent = reelSlot[i].transform;
                    clone.transform.SetParent(rootReel[i].transform); //親子を関連付ける
                    clone.name = child.name; //名前を消えるものと同じにする
                    Destroy(child); //用済みなので消す

                    //等間隔に配置されるよう、1つ下のリールの位置情報を取得して、y軸を弄る
                    Vector2 offset;
                    if (j == 9)
                    {
                        offset = rootReel[i].transform.FindChild("Image" + 0).gameObject.transform.position;
                    }
                    else
                    {
                        offset = rootReel[i].transform.FindChild("Image" + (j + 1)).gameObject.transform.position;
                    }
                    offset.y += 2.2f;
                    clone.transform.position = offset;
                }
            }
        }
    }
}