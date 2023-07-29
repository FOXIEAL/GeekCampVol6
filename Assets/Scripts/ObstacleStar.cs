using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObstacleStar : MonoBehaviour
{
    public Vector3 speed = new(0, 0, -0.05f);
    private GameSystem _gameSystem;
    private SE _se;
    private TextMeshProUGUI scoreText;
    private bool trigger = true;
    

    private void Start()
    {
        GameObject obj = GameObject.Find("GameSystem"); 
        _gameSystem = obj.GetComponent<GameSystem>();
        GameObject textobj = GameObject.Find("Score"); 
        scoreText = textobj.GetComponent<TextMeshProUGUI>();
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
            _gameSystem.score += 10;
            scoreText.text = "Score:" + _gameSystem.score;
            _se.OnStarEnter();
            Debug.Log(_gameSystem.score);
            Destroy(gameObject);
        }
    }
}
