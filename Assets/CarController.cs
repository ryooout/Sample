using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //マウスをクリックした座標
            this.startPos = Input.mousePosition;
        }
        //クリックを辞めたときの処理
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            //2点間の距離
            float swipeLength = endPos.x - startPos.x;
            this.speed = swipeLength / 500f;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed, 0, 0);//移動
        this.speed *= 0.98f;
    }
}
