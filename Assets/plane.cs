using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public float moveSpeed = 1; // ���ʳt��

    void FixedUpdate()
    {
        //²�檺���k����A�o�ӽd�һP�L�h���߫}���ʳ��O������
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
        }
    }
}