using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyBlock : MonoBehaviour
{
    [SerializeField] private GameObject block;
    private GameSystem _gameSystem;
    private bool trigger = true;

    private void Start()
    {
        _gameSystem = block.GetComponent<GameSystem>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        var layer = other.gameObject.layer;

        if (layer == LayerMask.NameToLayer("Player") && trigger)
        {
            trigger = false;
            _gameSystem.GameStart();
        }
    }
}
