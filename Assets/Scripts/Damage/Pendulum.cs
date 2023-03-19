using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [SerializeField]
    [Header("プレイヤーに与えるダメージ量")]
    private int _damage;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamage damage))
        {
            damage.DamagePlayer(_damage);
        }
    }
}
