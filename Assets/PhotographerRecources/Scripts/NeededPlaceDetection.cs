using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeededPlaceDetection : MonoBehaviour
{
    private bool EnterClicked = false;
    private bool isCaptured = false;
    public Animator EnterText1_anim;
    public GameObject MovingCamera, MainCamera;
    public GameObject BG1, BG2, neededPlace1, neededPlace2, WhiteImage;

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
                    EnterText1_anim.SetTrigger("IsTriggered");
                    EnterText1_anim = null;
                    MovingCamera.GetComponent<CameraMovement>().moveSpeed = 0f;
                    Invoke("ToNextPicture", 3f);
                }
            }
        }
    }

    private void OnBecameVisible()
    {
        if (EnterText1_anim != null)
            EnterText1_anim.SetTrigger("IsTriggered");
        if (!isCaptured)
        {
            isCaptured = true;
        }
    }

    private void OnBecameInvisible()
    {
        if(EnterText1_anim != null)
            EnterText1_anim.SetTrigger("IsTriggered");
        isCaptured = false;
    }

    private void ToNextPicture()
    {
        neededPlace1.SetActive(false);
        neededPlace2.SetActive(true);
        BG1.SetActive(false);
        BG2.SetActive(true);
        MovingCamera.GetComponent<CameraMovement>().moveSpeed = 5f;
    }
}
