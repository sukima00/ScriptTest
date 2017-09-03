using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 要素数5の配列を初期化する
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // 配列の各要素の値を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        } 

        // 配列の各要素の値を逆順に表示
        for (int h = 4; h >= 0; h--)
        {
            Debug.Log(array[h]);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
