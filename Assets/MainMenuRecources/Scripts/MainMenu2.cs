using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{
    private Animator anim;
    public GameObject[] Buttons = new GameObject[0];
    public GameObject BackB, HelpB, HelpImg;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("IsTriggered");
    }

    public void DecoratorStart()
    {
        SceneManager.LoadScene(2);
    }

    public void PhotographerStart()
    {
        SceneManager.LoadScene(3);
    }

    public void TattooArtistStart()
    {
        SceneManager.LoadScene(4);
    }

    public void WebDesignerStart()
    {
        SceneManager.LoadScene(5);
    }

    public void FilmmakerStart()
    {
        SceneManager.LoadScene(6);
    }

    public void WriterStart()
    {
        SceneManager.LoadScene(7);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Help()
    {
        HelpB.SetActive(false);
        foreach(GameObject el in Buttons)
        {
            el.SetActive(false);
        }

        BackB.SetActive(true);
        HelpImg.SetActive(true);
    }

    public void Back()
    {
        HelpB.SetActive(true);
        foreach (GameObject el in Buttons)
        {
            el.SetActive(true);
        }

        BackB.SetActive(false);
        HelpImg.SetActive(false);
    }
}
