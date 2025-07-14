using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость перемещения камеры
    public float padding = 100f; // Расстояние от края экрана, при котором начинается перемещение

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 moveDirection = Vector3.zero;

        // Проверяем, достиг ли курсор края экрана
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

        // Нормализуем направление движения, чтобы скорость оставалась постоянной при движении по диагонали
        moveDirection.Normalize();

        // Перемещаем камеру
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
