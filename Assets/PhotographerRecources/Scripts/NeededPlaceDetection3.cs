using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NeededPlaceDetection3 : MonoBehaviour
{
    private bool EnterClicked = false;
    private bool isCaptured = false;
    public Animator EnterText3_anim;
    public GameObject MovingCamera, MainCamera, Conclusion, BG3, WhiteImage;

    private void Update()
    {
        if (isCaptured)
        {
            if (!EnterClicked)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    EnterClicked = true;
                    WhiteImage.GetComponent<Transform>().position =
                        new Vector2(MainCamera.GetComponent<Transform>().position.x,
                        MainCamera.GetComponent<Transform>().position.y);
                    WhiteImage.GetComponent<Animator>().SetTrigger("IsTriggered");
                    EnterText3_anim.SetTrigger("IsTriggered");
                    EnterText3_anim = null;
                    MovingCamera.GetComponent<CameraMovement>().moveSpeed = 0f;
                    Invoke("EndOfGame", 3f);
                }
            }
        }
    }

    private void OnBecameVisible()
    {
        if (EnterText3_anim != null)
            EnterText3_anim.SetTrigger("IsTriggered");
        if (!isCaptured)
        {
            isCaptured = true;
        }
    }

    private void OnBecameInvisible()
    {
        if(EnterText3_anim != null)
            EnterText3_anim.SetTrigger("IsTriggered");
        isCaptured = false;
    }

    private void EndOfGame()
    {
        Conclusion.SetActive(true);
        BG3.SetActive(false);
        MovingCamera.GetComponent<Transform>().position = new Vector2(0f, 0f);
    }
}
