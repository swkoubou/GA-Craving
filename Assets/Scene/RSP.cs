using UnityEngine;
using System.Collections;

public class RSP : MonoBehaviour
{
    public Sprite rock;                                     //グー
    public Sprite scissors;                                 //チョキ
    public Sprite paper;                                    //パー
    public Sprite win;
    public Sprite lose;
    public GameObject myhand;//インスタンスの元となるオブジェクト
    public GameObject enemyhand;
    public GameObject result;
    private GameObject appearHand;    //画面上に出ている手
    private bool isHiddenOn = false;


    void Start()
    {

    }


    void Update()
    {
        string enemyHand = appearHand.GetComponent<SpriteRenderer>().sprite.name; //現在の手の名前を取得

        //グー.
        if (Input.GetKeyDown(KeyCode.A))
        {
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
            MoveHand();
        }
        //チョキ.
        else if (Input.GetKeyDown(KeyCode.S))
        {
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
            MoveHand();
        }
        //パー.
        else if (Input.GetKeyDown(KeyCode.D))
        {
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
            MoveHand();
        }
    }

    //手前の手を消し、1つずつずらし、最後尾に手を追加する
    void MoveHand()
    {
        enemyhand.GetComponent<SpriteRenderer>().sprite = GetNextHand();
    }
    //ランダムでじゃんけんの手を決める
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
    void Win()
    {
        result.GetComponent<SpriteRenderer>().sprite = win;
    }

    void Drow()
    {

    }

    void Lose()
    {
        result.GetComponent<SpriteRenderer>().sprite = lose;
    }
}
