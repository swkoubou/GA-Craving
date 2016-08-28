using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gotoslot : MonoBehaviour
{
    public void slot()
    {
        SceneManager.LoadScene("SlotGame");
    }
    public void logout()
    {
        Application.Quit();
    }
    public void Girls()
    {
        SceneManager.LoadScene("bunki");
    }
}