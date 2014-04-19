using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPoint : MonoBehaviour
{
		//宇宙ゴミ　プレハブ
		public GameObject debri;
		// 宇宙ゴミ発生感覚
		public float interval = 1f;
		// Use this for initialization
		void Start ()
		{
				//SpawnDebris() コルーチンを開始する
				StartCoroutine ("SpawnDebris");
		}

		IEnumerator SpawnDebris ()
		{
				//無限ループ
				while (true) {
						//宇宙ゴミプレハブを SpawnPointオブジェクトの位置にインスタンス化する
						Instantiate (debri, transform.position, Quaternion.identity);
						// interval 分だけ処理を停止する
						yield return new WaitForSeconds (interval);
				}
		}
		// Update is called once per frame
		void Update ()
		{
	
		}
}
