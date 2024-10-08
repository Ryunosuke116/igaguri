using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    private float m_fTimer;

    public Text m_txtTimer;

    public bool m_bActive = false;
   [SerializeField, Header("�c�莞��")]
    GameObject time;


    void Start()
    {
        Time.timeScale = 1f;
        //�t���[������
        Application.targetFrameRate = 60;

       // m_txtTimer = GameObject.Find("timer").GetComponent<Text>();
    }
    private void Update()
    {
        m_fTimer += Time.deltaTime;

        m_txtTimer.text = "�c�莞��"+ string.Format("{0:D2}:{1:D2}:{2:D2}",
          (int)m_fTimer / 60,
          (int)m_fTimer % 60,
          (int)(m_fTimer * 100) % 60
          );
    }
}
