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

        StartCoroutine(CameraTransition());

    }

    // Update is called once per frame

    private IEnumerator CameraTransition()

    {

        //カメラのオブジェクトを切る

        MainCamera.enabled = false;

        //エフェクトのオブジェクトをつける

        EffectCamera.enabled = true;

        EffectCamera.transform.position = strPosition;

        float elasedTime = 0f;

        //繰り返す

        while (elasedTime < transitionDuraion)

        {

            EffectCamera.transform.position = Vector3.Lerp(strPosition, endPosition, elasedTime / transitionDuraion);

            //加算

            elasedTime += Time.deltaTime;

            yield return null;

        }

        //カメラのオブジェクトをつける

        MainCamera.enabled = true;

        //エフェクトのオブジェクトを切る

        EffectCamera.enabled = false;
        GameTimer.IsTimer(true);
    }

}

