using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //　クラスの唯一のインスタンスを保持する静的変数
    public static ScoreScript instance;

    //　スコアを表示するためのTextコンポーネント
    public GameObject scoreText;
    private int totalScore = 0;
    private int hitStack = 0;               //現在のスタック数
    private const int maxStack = 100;       //最大スタック
    // Awakeメソッドでインスタンスの初期化を行う

    void Awake()
    {
        //インスタンスが存在しない場合はこのインスタンスを設定
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); //シーンをまたいでも
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //スコアを更新し、Textコンポーネントに反映するメソッド
    public void ScoreManager(int score)
    {
    
        //当たったらスタックをためる
        hitStack++;

        //100回当たるとスコアを3倍
        if(hitStack >= maxStack)
        {
            totalScore += score * 3;
        }
        else
        {
            //スコアを増やす
            totalScore += score;
        }
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score" + totalScore.ToString();
    }
    
    //トータルのスコア
    public int GetCurrentScore()
    {
        return totalScore;
    }
}
