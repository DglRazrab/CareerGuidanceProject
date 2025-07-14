using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class FilmMakerManager : MonoBehaviour
{
    public GameObject introduction, detectiv, classic, mystic, conclusion, CompleteB;
    public Transform det_frame1, det_frame2, det_frame3, det_frame4, det_frame5,
        clas_frame1, clas_frame2, clas_frame3, clas_frame4, clas_frame5,
        mys_frame1, mys_frame2, mys_frame3, mys_frame4;
    public VideoPlayer detectiv_vid, classic_vid, mystic_vid;
    private bool CompleteBActivated = false, anyButtonPressed = false;

    private void Start()
    {
        detectiv_vid.loopPointReached += OnDetVidFin;
        classic_vid.loopPointReached += OnClasVidFin;
        mystic_vid.loopPointReached += OnMysVidFin;
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void DetectivStart()
    {
        Cursor.visible = false;
        detectiv_vid.enabled = true;
        detectiv_vid.Play();
        if(!anyButtonPressed)
            anyButtonPressed = true;
    }

    private void OnDetVidFin(VideoPlayer vp)
    {
        Cursor.visible = true;
        detectiv_vid.enabled = false;
        introduction.SetActive(false);
        detectiv.SetActive(true);
    }

    public void ClassicStart()
    {
        Cursor.visible = false;
        classic_vid.enabled = true;
        classic_vid.Play();
        if (!anyButtonPressed)
            anyButtonPressed = true;
    }

    private void OnClasVidFin(VideoPlayer vp)
    {
        Cursor.visible = true;
        classic_vid.enabled = false;
        introduction.SetActive(false);
        classic.SetActive(true);
    }

    public void MysticStart()
    {
        Cursor.visible = false;
        mystic_vid.enabled = true;
        mystic_vid.Play();
        if (!anyButtonPressed)
            anyButtonPressed = true;
    }

    private void OnMysVidFin(VideoPlayer vp)
    {
        Cursor.visible = true;
        mystic_vid.enabled = false;
        introduction.SetActive(false);
        mystic.SetActive(true);
    }

    private void Update()
    {
        if(MovingObject.SolvedPuzzles == 5)
        {
            Invoke("DetectivSolved", 2f);
            MovingObject.SolvedPuzzles = 0;
        }

        if (MovingObject2.SolvedPuzzles == 5)
        {
            Invoke("ClassicSolved", 2f);
            MovingObject2.SolvedPuzzles = 0;
        }

        if (MovingObject3.SolvedPuzzles == 4)
        {
            Invoke("MysticSolved", 2f);
            MovingObject3.SolvedPuzzles = 0;
        }

        if (anyButtonPressed && !CompleteBActivated)
        {
            CompleteBActivated = true;
            CompleteB.SetActive(true);
        }
    }

    void DetectivSolved()
    {
        introduction.SetActive(true);
        detectiv.SetActive(false);
        det_frame1.GetComponent<MovingObject>().finish = false;
        det_frame2.GetComponent<MovingObject>().finish = false;
        det_frame3.GetComponent<MovingObject>().finish = false;
        det_frame4.GetComponent<MovingObject>().finish = false;
        det_frame5.GetComponent<MovingObject>().finish = false;
        det_frame1.localPosition = new Vector2(-20.7f, -154.6f);
        det_frame2.localPosition = new Vector2(112.5f, -146f);
        det_frame3.localPosition = new Vector2(-232f, -145f);
        det_frame4.localPosition = new Vector2(-130.2f, -155.6f);
        det_frame5.localPosition = new Vector2(258.9f, -146.7f);
    }

    void ClassicSolved()
    {
        introduction.SetActive(true);
        classic.SetActive(false);
        clas_frame1.GetComponent<MovingObject2>().finish = false;
        clas_frame2.GetComponent<MovingObject2>().finish = false;
        clas_frame3.GetComponent<MovingObject2>().finish = false;
        clas_frame4.GetComponent<MovingObject2>().finish = false;
        clas_frame5.GetComponent<MovingObject2>().finish = false;
        clas_frame1.localPosition = new Vector2(255.3f, -154.6f);
        clas_frame2.localPosition = new Vector2(112.5f, -146f);
        clas_frame3.localPosition = new Vector2(-232f, -145f);
        clas_frame4.localPosition = new Vector2(-130.2f, -155.6f);
        clas_frame5.localPosition = new Vector2(-25.8f, -150.2f);
    }

    void MysticSolved()
    {
        introduction.SetActive(true);
        mystic.SetActive(false);
        mys_frame1.GetComponent<MovingObject3>().finish = false;
        mys_frame2.GetComponent<MovingObject3>().finish = false;
        mys_frame3.GetComponent<MovingObject3>().finish = false;
        mys_frame4.GetComponent<MovingObject3>().finish = false;
        mys_frame1.localPosition = new Vector2(43f, -148f);
        mys_frame2.localPosition = new Vector2(181f, -144f);
        mys_frame3.localPosition = new Vector2(-165.8f, -140.4f);
        mys_frame4.localPosition = new Vector2(-64f, -151f);
    }

    public void Complete()
    {
        introduction.SetActive(false);
        conclusion.SetActive(true);
    }
}
