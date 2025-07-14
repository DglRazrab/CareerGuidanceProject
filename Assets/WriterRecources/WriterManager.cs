using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WriterManager : MonoBehaviour
{
    public GameObject MainPlayground, Conclusion;

    public void ToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Complete()
    {
        Conclusion.SetActive(true);
        MainPlayground.SetActive(false);
    }
}
