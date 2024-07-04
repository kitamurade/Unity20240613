using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManeger : MonoBehaviour
{
    //�B��̃C���X�^���X�Ƃ��ĐÓI�ϐ��𐶐�
    public static GameManeger instance;
    public void Awake()
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //�X�^�[�g���\�b�h
    public void StartGame()
    {
        SceneData.score = 0;
        SceneManager.LoadScene("Game");
    }
    //�G���h���\�b�h
    public void EndGame(int Blocks)
    {
        //�l�������X�R�A�ƃ��U���g��ʂ֑J��
        SceneData.score = scoreScript.instance.GetCurrentScore();
        SceneData.totalBlocks=Blocks;
        SceneManager.LoadScene("Result");
    }
    //���X�^�[�g���\�b�h
}
