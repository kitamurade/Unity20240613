using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barScript : MonoBehaviour
{
    //�v���C���[�̈ړ����x
    public float speed = 10;
    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //���E�̃L�[����͂���Ƒ��x��ύX���Ĉړ�
        myRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
