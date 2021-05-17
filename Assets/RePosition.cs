using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RePosition : MonoBehaviour
{
    public float minX = -30; // 이 값보다 위치 x가 작아지면 오른쪽으로 보내자.

    [SerializeField]
    private float minXTest = -30; //[SerializeField]

    // Update is called once per frame
    private void Update()
    {
        if (minX > transform.position.x)
        {
            //오른쪽으로 가로 크기 *2만큼 보내기.
            //가로크기 20.48
            transform.Translate(20.48f * 2, 0, 0);
        }
    }
}