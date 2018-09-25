using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列を初期化する
		int[] array = {1, 23, 50, 27, 34};

		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < array.Length; i++) {
			// 順番に表示
			Debug.Log (array [i]);
		}
		for (int i = array.Length - 1; i >= 0; i--) {
			// 逆順に表示
			Debug.Log (array [i]);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}

