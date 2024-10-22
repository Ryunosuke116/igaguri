using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    private float m_fTimer;
    private bool isStartTimer;      
    public Text m_txtTimer;

    public bool m_bActive = false;
   [SerializeField, Header("残り時間")]
    GameObject time;

    //ゲームオブジェクト
    public GameObject timer;

    void Start()
    {
        Time.timeScale = 1f;
        //フレーム買う
        Application.targetFrameRate = 60;
        isStartTimer = false;

       // m_txtTimer = GameObject.Find("timer").GetComponent<Text>();
    }
    private void Update()
    {
        if(isStartTimer)
        {
            m_fTimer += Time.deltaTime;
        }
            int EndTime = (int)m_fTimer % 60;

        m_txtTimer.text = "残り時間"+ string.Format("{0:D2}:{1:D2}:{2:D2}",
          (int)m_fTimer / 60,
          (int)m_fTimer % 60,
          (int)(m_fTimer * 100) % 60
          );



        EndTimer(EndTime);
    }

    public void EndTimer(int timer)
    {
        Debug.Log(timer);
        if (timer >= 10)
        {
            GameController.EndGame();
        }
      
    }
}
