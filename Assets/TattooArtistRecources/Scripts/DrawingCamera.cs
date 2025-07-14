using UnityEngine;
using UnityEngine.UI;
public class DrawingCamera : MonoBehaviour
{
    public Camera drawingCamera;
    public RawImage overlayImage;
    void Start()
    {
        ReloadSettings();
    }

    public void ReloadSettings()
    {
        drawingCamera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        overlayImage.texture = drawingCamera.targetTexture;
    }
}