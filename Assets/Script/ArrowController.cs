using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
     void Start()
    {
        this.player = GameObject.Find("player");

    }
    
    void Update()
    {
        //フレームごとに等速落下
        transform.Translate(0, -0.08f, 0);
        //画面外から出たらオブジェクト破壊
        if (transform.position.y < -5.0f) 
        {
            Destroy(gameObject);
        }
        //当たり判定
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f; //屋の半径
        float r2 = 0.05f; //playerの半径
        if(d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            //衝突した場合は屋を消す
            Destroy(gameObject);
        }
    }
}
