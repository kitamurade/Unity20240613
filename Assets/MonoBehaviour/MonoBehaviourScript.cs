using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourScript : MonoBehaviour
{
    //�{�[���̈ړ��̑������w��
    public float speed = 5f;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody�ɃA�N�Z�X���ĕϐ��ɕێ����Ă���
        myRigidbody= GetComponent<Rigidbody>();
        //�E�΂�45�x�ɐi��ł���
        myRigidbody.velocity = new Vector3(speed,speed,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
