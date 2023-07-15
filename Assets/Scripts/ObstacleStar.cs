using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleStar : MonoBehaviour
{
    public Vector3 speed = new(0, 0, -0.2f);
    private GameSystem _gameSystem;

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
            _gameSystem.score += 1;
            Debug.Log(_gameSystem.score);
            Destroy(gameObject);
        }
    }
}
