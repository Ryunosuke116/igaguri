using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField, Header("メイン")]
    public Camera MainCamera;

    [SerializeField, Header("エフェクト")]
    public Camera EffectCamera;

    //繰り返す時間
    public float transitionDuraion = 2f;

    //最初の位置
    public Vector3 strPosition = new Vector3(1, 2, -450);

    //終わりの位置
    public Vector3 endPosition = new Vector3(2, 5, -463);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private IEnumerator CameraTransition()
    {
        //カメラのオブジェクトを切る
        MainCamera.enabled = false;

        //エフェクトオブジェクをつける
        EffectCamera.enabled = true;

        float elasedTime = 0f;

        //繰り返す
        while(elasedTime< transitionDuraion)
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
