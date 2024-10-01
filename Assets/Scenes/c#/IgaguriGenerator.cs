using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject igaguriPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject igaguri=Instantiate(igaguriPrefab);
            Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDirection = ray.direction;
            igaguri.GetComponent<IgaguriController>().Shoot(worldDirection.normalized * 2000);
        }
    }
}
