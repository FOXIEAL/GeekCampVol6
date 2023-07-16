using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBlock : MonoBehaviour
{
    public Vector3 speed = new(0, 0, -0.1f);
    private GameSystem _gameSystem;
    private bool trigger = true;

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
        if (layer == LayerMask.NameToLayer("Player") && trigger)
        {
            trigger = false;
            _gameSystem.GameClear();
        }
    }
}
