using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TattooArtistSceneManager : MonoBehaviour
{
    public GameObject DrawingCamera, Tattoo1, Tattoo2, Tattoo3, Conclusion, BrushObj;
    public RawImage overlayImage2, overlayImage3;

    public void ToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void ToNextTattoo1()
    {
        Destroy(DrawingCamera.GetComponent<DrawingCamera>().overlayImage);
        DrawingCamera.GetComponent<DrawingCamera>().overlayImage = overlayImage2;
        DrawingCamera.GetComponent<DrawingCamera>().ReloadSettings();
        Tattoo1.SetActive(false);
        Tattoo2.SetActive(true);

    }

    public void ToNextTattoo2()
    {
        Destroy(DrawingCamera.GetComponent<DrawingCamera>().overlayImage);
        DrawingCamera.GetComponent<DrawingCamera>().overlayImage = overlayImage3;
        DrawingCamera.GetComponent<DrawingCamera>().ReloadSettings();
        Tattoo2.SetActive(false);
        Tattoo3.SetActive(true);
    }

    public void Complete()
    {
        Destroy(DrawingCamera);
        Destroy(BrushObj);
        Tattoo3.SetActive(false);
        Conclusion.SetActive(true);
    }
}
