using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
	// 速度
	public Vector2 SPEED = new Vector2(0.05f, 0.05f);

	void Start()
    {


    }


    void Update()
    {
        Move();
    }
	void Move()
	{
		// 現在位置をPositionに代入
		Vector2 Position = transform.position;
		// 左キーを押し続けていたら
		if (Input.GetKey("left"))
		{
			// 代入したPositionに対して加算減算を行う
			Position.x -= SPEED.x;
		}
		else if (Input.GetKey("right"))
		{ // 右キーを押し続けていたら
		  // 代入したPositionに対して加算減算を行う
			Position.x += SPEED.x;
		}
		else if (Input.GetKey("up"))
		{ // 上キーを押し続けていたら
		  // 代入したPositionに対して加算減算を行う
			Position.y += SPEED.y;
		}
		else if (Input.GetKey("down"))
		{ // 下キーを押し続けていたら
		  // 代入したPositionに対して加算減算を行う
			Position.y -= SPEED.y;
		}
		// 現在の位置に加算減算を行ったPositionを代入する
		transform.position = Position;
	}
}
