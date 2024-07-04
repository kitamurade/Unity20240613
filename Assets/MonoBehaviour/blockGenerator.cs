using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class blockGenerator : MonoBehaviour
{
    //gameObjectの追加
    public GameObject blockPrefab;
    //スパン
    float span = 0.4f;
    int row = 4;
    int col = 6;
    int blockScaleX = 2;
    int blockScaleY = 1;
    int totalBlocks = 0;
    // Start is called before the first frame update
    void Start()
    {
        //ボタンのポジション
        int px, py;
        px = -6;
        py = 5;
        int scoreDefult = 0;
        totalBlocks = row * col;
        //ブロックの配置
        for(int i = 0;i< row; i++)
        {
            for(int j = 0;j< col; j++)
            {
                //gemeObjectの生成
                GameObject go=Instantiate(blockPrefab);
                go.transform.position = new Vector3(px + (j * (span + blockScaleX)), py+(i*(span+blockScaleY)), 0);
            }
        }
        scoreScript.instance.ScoreManeger(scoreDefult);
    }

    //ゲームクリア
    public void BlocklDestroyed()
    {
        totalBlocks--;
        SceneData.totalBlocks = totalBlocks;
        if(totalBlocks<=0)
        {
            GameManeger.instance.EndGame(totalBlocks);
        }
    }
}
