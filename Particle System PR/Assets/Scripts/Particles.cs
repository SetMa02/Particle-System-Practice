using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    private ParticleSystemRenderer _psr;
    private float _inputX;
    private void Start()
    {
        _psr = GetComponent<ParticleSystemRenderer>();
    }

    private void Update()
    {
        _inputX = Input.GetAxis("Horizontal");
        if (_inputX > 0)
        {
            _psr.flip = new Vector3(1, 0, 0);
        }
        else if (_inputX < 0)
        {
            _psr.flip = new Vector3(0, 0, 0);
        }
    }
}
