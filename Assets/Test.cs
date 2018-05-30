using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] points = { 0,10,20,30,40 };

        // 配列の要素をすべて表示する
        for (int i = 5 - 1 ; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}