using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	// ���x
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
		// ���݈ʒu��Position�ɑ��
		Vector2 Position = transform.position;
		// ���L�[�����������Ă�����
		if (Input.GetKey("left"))
		{
			// �������Position�ɑ΂��ĉ��Z���Z���s��
			Position.x -= SPEED.x;
		}
		else if (Input.GetKey("right"))
		{ // �E�L�[�����������Ă�����
		  // �������Position�ɑ΂��ĉ��Z���Z���s��
			Position.x += SPEED.x;
		}
		else if (Input.GetKey("up"))
		{ // ��L�[�����������Ă�����
		  // �������Position�ɑ΂��ĉ��Z���Z���s��
			Position.y += SPEED.y;
		}
		else if (Input.GetKey("down"))
		{ // ���L�[�����������Ă�����
		  // �������Position�ɑ΂��ĉ��Z���Z���s��
			Position.y -= SPEED.y;
		}
		// ���݂̈ʒu�ɉ��Z���Z���s����Position��������
		transform.position = Position;
	}
}
