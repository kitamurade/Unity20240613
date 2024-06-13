using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    public int score = 10;
    //なにかとぶつかったときビルドインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        //スコアをブロックスクリプトに追加
        if(scoreScript.instance!=null)
        {
            scoreScript.instance.ScoreManeger(score);
        }
        else
        {
            Debug.LogError("インスタンスがありません");
        }
        //ゲームオブジェクトを排除
        Destroy(gameObject);
    }
}
