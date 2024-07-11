using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class resultSceneController : MonoBehaviour
{
    //�e��I�u�W�F�N�g�̐���
    public GameObject ScoreTextObject;
    public GameObject gameResultObject;
    // Start is called before the first frame update
    void Start()
    {
        //�e�팋�ʂ��I�u�W�F�N�g�ɓn��
        this.ScoreTextObject.GetComponent<TextMeshProUGUI>().text = "SCORE " + SceneData.score;

        //gameover
        if(SceneData.totalBlocks == 0)
        {
            this.gameResultObject.GetComponent<TextMeshProUGUI>().text="GAME CLEAR";
            this.gameResultObject.GetComponent<TextMeshProUGUI>().color = Color.yellow;
        }
        else
        {
            this.gameResultObject.GetComponent<TextMeshProUGUI>().text = "GAME OVER";
            this.gameResultObject.GetComponent<TextMeshProUGUI>().color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
