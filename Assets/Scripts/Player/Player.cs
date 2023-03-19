using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour,IDamage
{
    [SerializeField]
    [Header("HP")]
    private int _hp;
    
    [SerializeField]
    [Header("HPSlider")]
    private Slider _hpSlider;
    
    [SerializeField]
    [Header("ゲームオーバーラグドール")]
    private GameObject _gameOverRagdool;
    
    [SerializeField]
    [Header("ものとモデル")]
    private GameObject _human;

    private void Start()
    {
        _hpSlider.maxValue = _hp;
        _hpSlider.value = _hp;
    }

    public void DamagePlayer(int damage)
    {
        _hp -= damage;
        _hpSlider.value = _hp;
        HpCheck();
    }
    
    private void HpCheck()
    {
        if (_hp <= 0)
        {
            Debug.Log("GameOver");
            _gameOverRagdool.SetActive(true);
            _human.gameObject.SetActive(false);
        }
    }
}
