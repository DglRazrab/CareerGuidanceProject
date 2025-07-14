using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private Animator anim;
    public GameObject BG;
    public GameObject GirlCanvas;

    private void Start()
    {
        anim = BG.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            Destroy(GameObject.Find("ClickAnyButtonText"));
            anim.SetTrigger("IsTriggered");
            Invoke("OnEndAnim", 0.5f);
            if (GirlCanvas.GetComponent<StopAnim>().isPaused)
            {
                GirlCanvas.GetComponent<StopAnim>().anim.speed = 1f;
            }
        }
    }

    public void OnEndAnim()
    {
        GameObject.Destroy(GameObject.Find("BG1"));
        GirlCanvas.GetComponent<Animator>().SetTrigger("IsTriggered");
    }
}
