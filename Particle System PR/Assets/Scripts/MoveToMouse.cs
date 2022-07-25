using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToMouse : MonoBehaviour
{
    [SerializeField]private float _speed = 8.0f;
    [SerializeField]private float _distanceFromCamera = 5.0f;

    void Update()
    {
        Vector3 MousePosition = Input.mousePosition;
        MousePosition.z = _distanceFromCamera;

        Vector3 MouseScreenToWorld = Camera.main.ScreenToWorldPoint(MousePosition);

        Vector3 Position = Vector3.Lerp(transform.position, MouseScreenToWorld, 1.0f - Mathf.Exp(-_speed * Time.deltaTime));

        transform.position = Position;
    }
}
