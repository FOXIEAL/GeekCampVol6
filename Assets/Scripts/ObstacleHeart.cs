using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObstacleHeart : MonoBehaviour
{
    public Vector3 speed = new(0, 0, -0.1f);
    private GameSystem _gameSystem;
    [SerializeField] private TextMeshProUGUI hptext;

    private void Start()
    {
        GameObject obj = GameObject.Find("GameSystem"); 
        _gameSystem = obj.GetComponent<GameSystem>();
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
            _gameSystem.hp += 1;
            hptext.text = " HP:" + _gameSystem.hp;
            Debug.Log(_gameSystem.hp);
            Destroy(gameObject);
        }
    }
}
