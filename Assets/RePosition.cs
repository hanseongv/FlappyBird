using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RePosition : MonoBehaviour
{
    public float minX = -30; // �� ������ ��ġ x�� �۾����� ���������� ������.

    [SerializeField]
    private float minXTest = -30; //[SerializeField]

    // Update is called once per frame
    private void Update()
    {
        if (minX > transform.position.x)
        {
            //���������� ���� ũ�� *2��ŭ ������.
            //����ũ�� 20.48
            transform.Translate(20.48f * 2, 0, 0);
        }
    }
}