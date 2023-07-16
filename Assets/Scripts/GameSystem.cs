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

    [SerializeField] private GameObject eff1;
    [SerializeField] private GameObject eff2;
    private ParticleSystem eff1Par;
    private ParticleSystem eff2Par;



    void Start()
    {
        _creator = _creatorObj.GetComponent<ObstacleCreator>();
        eff1Par = eff1.GetComponent<ParticleSystem>();
        eff2Par = eff2.GetComponent<ParticleSystem>();
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
        eff1.SetActive(true);
        eff2.SetActive(true);
        eff1Par.Play();
        eff2Par.Play();
        gameClearText.text = "Score(Score×HP):" + score * hp;
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
