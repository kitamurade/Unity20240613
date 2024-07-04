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
    //�Ȃɂ��ƂԂ������Ƃ��r���h�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        //�X�R�A���X�R�A�X�N���v�g�ɒǉ�
        if (scoreScript.instance != null) 
        {
            scoreScript.instance.ScoreManeger(score);
        }
        else
        {
            Debug.LogError("ScoreScript instance is not set.");
        }
        //�g�[�^���u���b�N�̍폜���\�b�h
        generator.BlocklDestroyed();
        //�Q�[���I�u�W�F�N�g��r��
        Destroy(gameObject);
    }
}
