using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    private int mode = 1;
    public int hp = 50;
    public int score = 0;
    
    public int blockCount = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(hp <= 0) GameOver();
    }

    void GameOver()
    {
        Debug.Log("GameOver");
    }

    public void GameReady()
    {
        
    }
}
