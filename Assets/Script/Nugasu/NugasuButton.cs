using UnityEngine;
using System.Collections;

public class NugasuButton : MonoBehaviour
{
    /********************************************************************************
     *現在動作確認のために ボタンが押されたら服が透明になるようにしている
     * 最終的には、ユーザーがジャンケンに勝ったときに "HukuAlpha()" を実行するように変更する
    ********************************************************************************/

    int count; //服が脱げた回数をカウント

    void Start()
    {
        count = 0;
    }

    public void OnClick()
    {
        HukuAlpha();
    }

    void HukuAlpha() //服が順番に透明になる //今は一瞬でに透明になっているが、徐々に透明にするならばここをいじる
    {
        if(count == 1)
            Nugasu_Tshirt.tshirt_a = 0;
        if (count == 2)
            Nugasu_Skirt.skirt_a = 0;
        if (count == 3)
            Nugasu_Bra.bra_a = 0; ;
        if (count == 4)
            Nugasu_Pants.pants_a = 0;

        count++;
    }

}