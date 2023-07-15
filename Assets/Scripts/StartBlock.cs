using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StartBlock : MonoBehaviour
{
    [SerializeField] private GameObject block;
    private GameSystem _gameSystem;

    private void Start()
    {
        _gameSystem = block.GetComponent<GameSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        var layer = other.gameObject.layer;
        if (layer == LayerMask.NameToLayer("Player"))
        {
            _gameSystem.blockCount++;
            if (_gameSystem.blockCount == 2) _gameSystem.GameReady();
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
