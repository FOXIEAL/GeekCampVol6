using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObstacleCube : MonoBehaviour
{
    public Vector3 speed = new(0, 0, -0.1f);
    private GameSystem _gameSystem;
    private SE _se;
    private TextMeshProUGUI hptext;

    private void Start()
    {
        GameObject obj = GameObject.Find("GameSystem"); 
        GameObject seobj = GameObject.Find("SE");
        GameObject textobj = GameObject.Find("HP");
        _gameSystem = obj.GetComponent<GameSystem>();
        _se = seobj.GetComponent<SE>();
        hptext = textobj.GetComponent<TextMeshProUGUI>();
    }

    void FixedUpdate()
    {
        transform.position += speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        var layer = other.gameObject.layer;
        if (layer == LayerMask.NameToLayer("Player"))
        {
            _gameSystem.hp -= 1;
            hptext.text = " HP:" + _gameSystem.hp;
            _se.OnCubeEnter();
            Debug.Log(_gameSystem.hp);
            Destroy(gameObject);
        }
    }
}
