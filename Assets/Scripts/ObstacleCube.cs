using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCube : MonoBehaviour
{
    public Vector3 speed = new(0, 0, -0.1f);
    void FixedUpdate()
    {
        transform.position += speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        var layer = other.gameObject.layer;
        if (layer == LayerMask.NameToLayer("Player"))
        {
            Debug.Log("nnnnnnnnnnn");
            Destroy(gameObject);
        }
    }
}
