using UnityEngine;
using System.Collections;

public class RSP : MonoBehaviour
{
    public Sprite rock;                                     //グー
    public Sprite scissors;                                 //チョキ
    public Sprite paper;                                    //パー
    public Sprite win;                                     //勝ち
    public Sprite lose;                                    //負け
    public Sprite aiko;                                    //あいこ
    public GameObject myhand;//画面上に出る自分の手
    public GameObject enemyhand;//画面上に出る相手の手
    public GameObject result;//画面上に出る結果
    private GameObject appearHand;    //画面上に出ている手
    public paa paa;
    public TransDress transDress;


    public void Start()
    {
        //paa.count = 3;
    }


    //手札のランダム選出
    Sprite GetNextHand()
    {
        Sprite hand = null;
        int random = Random.Range(0, 3);
        switch (random)
        {
            case 0:
                hand = rock;
                break;

            case 1:
                hand = scissors;
                break;

            case 2:
                hand = paper;
                break;
        }
        return hand;
    }
    //相手のランダム選出したものを画面に表示
    void MoveHand()
    {
        enemyhand.GetComponent<SpriteRenderer>().sprite = GetNextHand();
    }
    //自分の出す手を選ぶ
    void Update()
    {
        if(result.GetComponent<SpriteRenderer>().sprite != null)
        {
            if(Input.GetMouseButtonDown(0)){
                result.GetComponent<SpriteRenderer>().sprite = null;

            }
        }

        string enemyHand;//= enemyhand.GetComponent<SpriteRenderer>().sprite.name; //現在の手の名前を取得
         //グー
        if (paa.count==2)
        {
            MoveHand();
            enemyHand = enemyhand.GetComponent<SpriteRenderer>().sprite.name;
            if (enemyHand == "Rock")
            {
                Drow();
            }
            else if (enemyHand == "Scissors")
            {
                Win();
            }
            else if (enemyHand == "Paper")
            {
                Lose();
            }
            myhand.GetComponent<SpriteRenderer>().sprite = rock;
        }
        //チョキ.
        else if (paa.count==0)
        {
            MoveHand();
            enemyHand = enemyhand.GetComponent<SpriteRenderer>().sprite.name;
            if (enemyHand == "Rock")
            {
                Lose();
            }
            else if (enemyHand == "Scissors")
            {
                Drow();
            }
            else if (enemyHand == "Paper")
            {
                Win();
            }
            myhand.GetComponent<SpriteRenderer>().sprite = scissors;
        }
        //パー.
        else if (paa.count==1)
        {
            MoveHand();
            enemyHand = enemyhand.GetComponent<SpriteRenderer>().sprite.name;
            if (enemyHand == "Rock")
            {
                Win();
            }
            else if (enemyHand == "Scissors")
            {
                Lose();
            }
            else if (enemyHand == "Paper")
            {
                Drow();
            }
            myhand.GetComponent<SpriteRenderer>().sprite = paper;
        }
        paa.count = -1;
    }
    //結果表示
    void Win()
    {
        result.GetComponent<SpriteRenderer>().sprite = win;
        transDress.DressBreak();
    }

    void Drow()
    {
        result.GetComponent<SpriteRenderer>().sprite = aiko;
    }

    void Lose()
    {
        result.GetComponent<SpriteRenderer>().sprite = lose;
    }
}
