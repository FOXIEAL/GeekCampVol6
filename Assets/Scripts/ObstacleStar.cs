using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObstacleStar : MonoBehaviour
{
    public Vector3 speed = new(0, 0, -0.2f);
    private GameSystem _gameSystem;
    private TextMeshProUGUI scoreText;
    

    private void Start()
    {
        GameObject obj = GameObject.Find("GameSystem"); 
        _gameSystem = obj.GetComponent<GameSystem>();
        GameObject textobj = GameObject.Find("Score"); 
        scoreText = textobj.GetComponent<TextMeshProUGUI>();
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
            _gameSystem.score += 10;
            scoreText.text = "Score:" + _gameSystem.score;
            Debug.Log(_gameSystem.score);
            Destroy(gameObject);
        }
    }
}
