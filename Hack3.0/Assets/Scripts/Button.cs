using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public Image image;
    public GameObject Start;

    public void StartHack()
    {
        image.gameObject.SetActive(false);
        Start.gameObject.SetActive(false);
    }

    public void Level1()
    {
        SceneManager.LoadScene(2);
    }

    public void Reg()
    {
        SceneManager.LoadScene(1);
    }

    public void Auth()
    {
        SceneManager.LoadScene(3);
    }
}
