using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    public int score = 10;
    //�Ȃɂ��ƂԂ������Ƃ��r���h�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        //�X�R�A���u���b�N�X�N���v�g�ɒǉ�
        if(scoreScript.instance!=null)
        {
            scoreScript.instance.ScoreManeger(score);
        }
        else
        {
            Debug.LogError("�C���X�^���X������܂���");
        }
        //�Q�[���I�u�W�F�N�g��r��
        Destroy(gameObject);
    }
}
