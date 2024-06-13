using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class blockGenerator : MonoBehaviour
{
    //gameObject�̒ǉ�
    public GameObject blockPrefab;
    //�X�p��
    float span = 0.3f;
    int row = 4;
    int col = 7;
    int blockScaleX = 2;
    int blockScaleY = 1;
    // Start is called before the first frame update
    void Start()
    {
        //�{�^���̃|�W�V����
        int px, py;
        px = -5;
        py = 5;
        //�u���b�N�̔z�u
        for(int i = 0;i< row; i++)
        {
            for(int j = 0;j< col; j++)
            {
                //gemeObject�̐���
                GameObject go=Instantiate(blockPrefab);
                go.transform.position = new Vector3(px + (j * (span + blockScaleX)), py+(i*(span+blockScaleY)), 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
