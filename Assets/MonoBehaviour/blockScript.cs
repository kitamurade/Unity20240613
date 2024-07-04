using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    public int score = 10;
    private blockGenerator generator;

    private void Start()
    {
        generator = FindObjectOfType<blockGenerator>();
    }
    //なにかとぶつかったときビルドインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        //スコアをスコアスクリプトに追加
        if (scoreScript.instance != null) 
        {
            scoreScript.instance.ScoreManeger(score);
        }
        else
        {
            Debug.LogError("ScoreScript instance is not set.");
        }
        //トータルブロックの削除メソッド
        generator.BlocklDestroyed();
        //ゲームオブジェクトを排除
        Destroy(gameObject);
    }
}
