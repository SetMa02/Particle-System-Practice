using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
     [SerializeField] private GameObject _effect;

     private void OnCollisionEnter2D(Collision2D col)
     {
          Physics2D.IgnoreCollision(col.collider, col.otherCollider);

          Instantiate(_effect, col.GetContact(0).point, Quaternion.identity);
     }
}
