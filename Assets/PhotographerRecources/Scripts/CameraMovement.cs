using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // �������� ����������� ������
    public float padding = 100f; // ���������� �� ���� ������, ��� ������� ���������� �����������

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 moveDirection = Vector3.zero;

        // ���������, ������ �� ������ ���� ������
        if (mousePosition.x <= padding)
        {
            moveDirection += Vector3.left;
        }
        else if (mousePosition.x >= Screen.width - padding)
        {
            moveDirection += Vector3.right;
        }

        if (mousePosition.y <= padding)
        {
            moveDirection += Vector3.down;
        }
        else if (mousePosition.y >= Screen.height - padding)
        {
            moveDirection += Vector3.up;
        }

        // ����������� ����������� ��������, ����� �������� ���������� ���������� ��� �������� �� ���������
        moveDirection.Normalize();

        // ���������� ������
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
