using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{ 
    GameObject car;
    GameObject flag;
    GameObject distance;
    void Start()
    {
        //オブジェクトの情報を獲得
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    /// <summary>
    /// 2点間の距離のプログラム
    /// </summary>
    void Update()
    {
        
        float length = this.flag.transform.position.x - this.car.transform.position.x;
          //2点間の距離が0より大きければ
        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "ゴールまであと" + length.ToString("F2") + "m";
        }
        //0より小さければ
        else
        {
            this.distance.GetComponent<Text>().text = "ゲームオーバー";
        }
    }
}
