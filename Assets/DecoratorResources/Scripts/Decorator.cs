using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Decorator : MonoBehaviour
{
    public GameObject Scene1, Scene2, Scene3, Conclusion, basis, bg;

    public void ToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void ToSceneTwo()
    {
        Scene1.SetActive(false);
        Scene2.SetActive(true);
    }

    public void ToSceneThree()
    {
        Scene2.SetActive(false);
        Scene3.SetActive(true);
    }

    public void Complete()
    {
        Scene3.SetActive(false);
        Conclusion.SetActive(true);
        basis.SetActive(false);
        bg.SetActive(false);
    }
}
