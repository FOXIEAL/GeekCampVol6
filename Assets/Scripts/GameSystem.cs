using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    private int mode = 1;
    public int hp = 50;
    public int score = 0;

    [SerializeField] private GameObject startBlockR;
    [SerializeField] private GameObject startBlockL;
    [SerializeField] private GameObject readyBlock;
    public int blockCount = 0;

    [SerializeField] private Canvas startCanvas;
    [SerializeField] private Canvas readyCanvas;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(hp <= 0) GameOver();
    }

    public void GameStart()
    {
        // ObstacleCreator の Start() を改名して実行する
    }

    void GameOver()
    {
        Debug.Log("GameOver");
    }

    public void GameReady()
    {
        Destroy(startBlockR);
        Destroy(startBlockL);
        readyBlock.SetActive(true);
        startCanvas.enabled = false;
        readyCanvas.enabled = true;
    }
}
