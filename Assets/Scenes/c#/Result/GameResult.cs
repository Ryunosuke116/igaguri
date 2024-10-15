using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameResult : MonoBehaviour
{
    //テキスト生成
    public GameObject scoreText;
    public GameObject resultText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "SCORE:" + ScoreData.score;
        //GAMECLEAR or GAMEOVER
      
    }
    //スタート画面への遷移
    public void OnReturnBottonPressed()
    {
        GameController.instance.ReturnStart();
    }
}
