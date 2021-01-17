using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 player_pos;
   

    private void Update()
    {
        //左矢印押されたとき
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0); //左に「3」動かす
        }

        //右矢印が押された時
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0); //右動く
        
        }

        player_pos = transform.position;//player'sposition
        player_pos.x = Mathf.Clamp(player_pos.x, -8.0f, 8.0f);//X位置監視
    transform.position = new Vector2(player_pos.x, player_pos.y);//範囲内であればその位置入る
            }

}
