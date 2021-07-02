﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    //시간이 지남에 따라 점점 파도가 커지는 함수
    public void SizeUp()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0f);
    }
    //특정 조건이 만족되면 파괴되기 - 육지에 도달 시 파괴
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Land")
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SizeUp();
    }
}
