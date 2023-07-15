using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    [SerializeField] private Canvas gameOverCanvas;
    [SerializeField] private Canvas gameClearCanvas;


    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI gameClearText;


    void Start()
    {
        
    }

    
    void Update()
    {
        if(hp <= 0) GameOver();
    }

    public void GameStart()
    {
        Destroy(readyBlock);
        readyCanvas.enabled = false;
        // ObstacleCreator の Start() を改名して実行する
    }

    void GameClear()
    {
        // 最後に当たり判定作ってここ呼ぶ
        gameClearText.text = "Score:" + score;
        gameClearCanvas.enabled = true;
        Debug.Log("GameOver");
    }

    void GameOver()
    {
        gameOverText.text = "Score:" + score;
        gameOverCanvas.enabled = true;
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
