using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 playerPos = player.transform.position;

        //�J�����ƃv���C���[�̈ʒu�𓯂��ɂ���
        transform.position = new Vector3(playerPos.x, playerPos.y, -10);
    }
}
