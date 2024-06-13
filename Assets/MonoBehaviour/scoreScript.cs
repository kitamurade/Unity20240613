using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreScript : MonoBehaviour
{
    //�N���X�̗B��̃C���X�^���X��ێ����邽�߂̐ÓI�ȕϐ�
    public static scoreScript instance;
    //�X�R�A��\�����邽�߂�text�R���|�[�l���g�ƃg�[�^���X�R�A
    public GameObject scoreText;
    private int totalScore = 0;
    //�v���C�x�[�g�R���X�g���N�^
    private void Awake()
    {
        //�C���X�^���X�����݂��Ȃ��ꍇ�͂��̃C���X�^���X��ݒ�
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);//�V�[�����܂����ł��C���X�^���X��ێ�
        }
        //���ɑ��݂���ꍇ�͐V�����C���X�^���X��j��
        else
        {
            Destroy(gameObject);
        }
    }
    //���f����邽�߂̃��\�b�h���`
    private void Start()
    {
        
    }
    //�X�R�A���X�V���āAtext�R���|�[�l���g�ɔ��f����
    public void ScoreManeger(int score)
    {
        totalScore += score;
        //�R���|�[�l���g��\������
        UpdataScoreText();
    }
    //�X�R�A��text�R���|�[�l���g�ɕ\�����郁�\�b�h
    private void UpdataScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score:"+totalScore.ToString();
    }
}
