using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextTextPh : MonoBehaviour
{
    public GameObject text1, text2, openEyes, closedEyes;
    bool isPressed = false;

    private void Update()
    {
        if (Input.anyKeyDown && !isPressed)
        {
            isPressed = true;
            text1.SetActive(false);
            text2.SetActive(true);
            closedEyes.SetActive(false);
            openEyes.SetActive(true);
        }
    }
}
