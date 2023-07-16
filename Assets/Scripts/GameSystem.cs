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

    [SerializeField] private GameObject startCanvas;
    [SerializeField] private GameObject readyCanvas;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject gameClearCanvas;


    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI gameClearText;

    [SerializeField] private GameObject _creatorObj;
    private ObstacleCreator _creator;

    void Start()
    {
        _creator = _creatorObj.GetComponent<ObstacleCreator>();
    }

    
    void Update()
    {
        if(hp <= 0) GameOver();
    }

    public void GameStart()
    {
        Destroy(readyBlock);
        readyCanvas.SetActive(false);
        _creator.CoroutineStart();
    }

    public void GameClear()
    {
        // 最後に当たり判定作ってここ呼ぶ
        gameClearText.text = "Score:" + score;
        gameClearCanvas.SetActive(true);
    }

    void GameOver()
    {
        gameOverText.text = "Score:" + score;
        gameOverCanvas.SetActive(true);
        Debug.Log("GameOver");
    }

    public void GameReady()
    {
        Destroy(startBlockR);
        Destroy(startBlockL);
        readyBlock.SetActive(true);
        startCanvas.SetActive(false);
        readyCanvas.SetActive(true);
    }
}
