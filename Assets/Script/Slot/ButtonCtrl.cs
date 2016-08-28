using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonCtrl : MonoBehaviour
{
    public bool isStartButton;
    public bool isLeftButton;
    public bool isCenterButton;
    public bool isRightButton;
    public AudioSource SEBox;
    public AudioClip lever;
    public AudioClip pushButton;
    public AudioClip hit;


    void Start()
    {
        isStartButton = false;
        isLeftButton = false;
        isCenterButton = false;
        isRightButton = false;
    }


    void Update()
    {
        ////メインカメラ上のマウスカーソルのある位置からRayを飛ばす
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
        //if (hit.collider)
        //{
        //    Debug.Log(hit.collider.tag);
        //}
    }


    public void OnStartButton()
    {
        if (!isStartButton)
        {
            isStartButton = true;
            SEBox.PlayOneShot(lever, 3f);
        }
    }

    public void OnReturnButton()
    {
        SceneManager.LoadScene("title");
    }

    public void OnLeftButton()
    {
        if (isStartButton)
        {
            isLeftButton = true;
            SEBox.PlayOneShot(pushButton, 3f);
        }
    }

    public void OnCenterButton()
    {
        if (isStartButton)
        {
            isCenterButton = true;
            SEBox.PlayOneShot(pushButton, 3f);
        }
    }

    public void OnRightButton()
    {
        if (isStartButton)
        {
            isRightButton = true;
            SEBox.PlayOneShot(pushButton, 3f);
        }
    }

    public bool IsAllButtonOn()
    {
        return isLeftButton && isCenterButton && isRightButton;
    }

    public void AllButtonFalse()
    {
        isStartButton = false;
        isLeftButton = false;
        isCenterButton = false;
        isRightButton = false;
    }
}