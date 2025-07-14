using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StopAnim : MonoBehaviour
{
    public Animator anim;
    public bool isPaused = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PauseAnimation()
    {
        isPaused = true;
        anim.speed = 0f;
    }

    public void ToNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
