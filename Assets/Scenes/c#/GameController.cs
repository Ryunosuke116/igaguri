using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public void GameHome()
    {
        SceneManager.LoadScene("Start");
    }

    //ゲーム終了
    public static void EndGame()
    {
        //獲得したスコアとリザルト画面へ遷移
        ScoreData.score = ScoreScript.instance.GetCurrentScore();
        SceneManager.LoadScene("GameResult");
    }
    //スタート画面に戻る
    public void ReturnStart()
    {
        SceneManager.LoadScene("Start");
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameStart()
    {
        SceneManager.LoadScene("GameScreen");
    }
}
