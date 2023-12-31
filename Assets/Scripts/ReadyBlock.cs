using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyBlock : MonoBehaviour
{
    [SerializeField] private GameObject block;
    private GameSystem _gameSystem;
    [SerializeField] private GameObject se;
    private SE _se;
    private bool trigger = true;

    private void Start()
    {
        _gameSystem = block.GetComponent<GameSystem>();
        _se = se.GetComponent<SE>();
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        var layer = other.gameObject.layer;

        if (layer == LayerMask.NameToLayer("Player") && trigger)
        {
            trigger = false;
            _se.OnReadyEnter();
            _gameSystem.GameStart();
        }
    }
}
