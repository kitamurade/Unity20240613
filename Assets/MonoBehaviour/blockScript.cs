using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class blockScript : MonoBehaviour
{
    public int score = 0;
    //�Ȃɂ��ƂԂ������Ƃ��r���h�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        score += 10;
        //�Q�[���I�u�W�F�N�g��r��
        Destroy(gameObject);
    }
}
