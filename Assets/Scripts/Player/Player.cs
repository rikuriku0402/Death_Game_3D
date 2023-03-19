using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour,IDamage
{
    [SerializeField]
    [Header("HP")]
    private int _hp;
    

    public void DamagePlayer(int damage)
    {
        _hp -= damage;
    }
}
