using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeededPlaceDetection2 : MonoBehaviour
{
    private bool EnterClicked = false;
    private bool isCaptured = false;
    public Animator EnterText2_anim;
    public GameObject MovingCamera, MainCamera;
    public GameObject BG2, BG3, neededPlace2, neededPlace3, WhiteImage;

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
                    EnterText2_anim.SetTrigger("IsTriggered");
                    EnterText2_anim = null;
                    MovingCamera.GetComponent<CameraMovement>().moveSpeed = 0f;
                    Invoke("ToNextPicture", 3f);
                }
            }
        }
    }

    private void OnBecameVisible()
    {
        if (EnterText2_anim != null)
            EnterText2_anim.SetTrigger("IsTriggered");
        if (!isCaptured)
        {
            isCaptured = true;
        }
    }

    private void OnBecameInvisible()
    {
        if(EnterText2_anim != null)
            EnterText2_anim.SetTrigger("IsTriggered");
        isCaptured = false;
    }

    private void ToNextPicture()
    {
        neededPlace2.SetActive(false);
        neededPlace3.SetActive(true);
        BG2.SetActive(false);
        BG3.SetActive(true);
        MovingCamera.GetComponent<CameraMovement>().moveSpeed = 5f;
    }
}
