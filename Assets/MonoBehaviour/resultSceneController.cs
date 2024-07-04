using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class resultSceneController : MonoBehaviour
{
    //�e��I�u�W�F�N�g�̐���
    public GameObject ScoreTextObject;
    public GameObject gameResultObject;
    //�e�L�X�g
    private Text scoreText;
    private Text gameResult;
    
    // Start is called before the first frame update
    void Start()
    {
        //�e�팋�ʂ��I�u�W�F�N�g�ɓn��
        scoreText=ScoreTextObject.GetComponent<Text>();
        gameResult=gameResultObject.GetComponent<Text>();

        scoreText.text = "SCORE:" + SceneData.score;

        //gameover
        if(SceneData.totalBlocks == 0)
        {
            gameResult.text = "GAME CLEAR";
            gameResult.color = Color.yellow;
        }
        else
        {
            gameResult.text = "GAME OVER";
            gameResult.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
