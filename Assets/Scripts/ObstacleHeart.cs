using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObstacleHeart : MonoBehaviour
{
    public Vector3 speed = new(0, 0, -0.05f);
    private GameSystem _gameSystem;
    private SE _se;
    private TextMeshProUGUI hptext;
    private bool trigger = true;

    private void Start()
    {
        GameObject obj = GameObject.Find("GameSystem"); 
        _gameSystem = obj.GetComponent<GameSystem>();
        GameObject textobj = GameObject.Find("HP"); 
        hptext = textobj.GetComponent<TextMeshProUGUI>();
        GameObject seobj = GameObject.Find("SE");
        _se = seobj.GetComponent<SE>();
    }

    void FixedUpdate()
    {
        transform.position += speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        var layer = other.gameObject.layer;
        if (layer == LayerMask.NameToLayer("Player") && trigger)
        {
            trigger = false;
            if(_gameSystem.hp + 5 > 50) _gameSystem.hp = 50;
            else _gameSystem.hp += 5;
            hptext.text = " HP:" + _gameSystem.hp;
            _se.OnHeartEnter();
            Debug.Log(_gameSystem.hp);
            Destroy(gameObject);
        }
    }
}
