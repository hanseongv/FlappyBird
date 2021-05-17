using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollX : MonoBehaviour
{
    private float speedX = -1;

    //public static bool die = false;
    public float minX = -30;

    // Update is called once per frame
    private void Update()
    {
        if (minX > transform.position.x)
        {
            //오른쪽으로 가로 크기 *2만큼 보내기.
            //가로크기 20.48
            transform.Translate(20.48f * 2, 0, 0);
        }

        transform.Translate(speedX * Time.deltaTime, 0, 0);
        //var pos = transform.position;
        //pos.x += speedX*Time.deltaTime;
        //transform.position = pos;
    }
}