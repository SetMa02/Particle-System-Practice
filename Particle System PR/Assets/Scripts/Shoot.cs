using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private GameObject _effect;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _mainCamera.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f))
            {
                var effect = Instantiate(_effect, hit.point, Quaternion.identity);
                effect.transform.rotation = Quaternion.FromToRotation(effect.transform.forward, hit.normal) *
                                            effect.transform.rotation;
            }
            
        }
    }
}
