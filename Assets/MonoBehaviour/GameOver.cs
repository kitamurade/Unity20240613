using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (GameManeger.instance == null)
        {
            GameManeger.instance = FindAnyObjectByType<GameManeger>();
        }
        if (GameManeger.instance != null)
        {

            int blocks = SceneData.totalBlocks;
            GameManeger.instance.EndGame(blocks);
            Destroy(collision.gameObject);

        }
        else
        {
            Debug.Log("ゲームマネージャーがインスタンス化されていません");
        }
    }
}
