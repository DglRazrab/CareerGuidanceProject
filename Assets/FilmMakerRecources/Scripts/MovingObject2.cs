using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject2 : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    public GameObject form;
    public bool finish = false;
    public static int SolvedPuzzles = 0;

    private void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPosition();
        isDragging = true;
    }

    private void OnMouseUp()
    {
        isDragging = false;

        if(!finish && Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x) <= 5f
            && (this.transform.localPosition.y - form.transform.localPosition.y) <= 5f)
        {
            this.transform.position = new Vector2(form.transform.position.x, form.transform.position.y);
            finish = true;
            SolvedPuzzles++;
        }
    }

    private void Update()
    {
        if (isDragging && !finish)
        {
            Vector3 targetPos = GetMouseWorldPosition() + offset;
            transform.position = targetPos;
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
