using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ��U�ێʂ��̉��u�� (�K�v�ɉ����ĉ���) ttps://qiita.com/SpaceCore/items/debb3c669cda5a3b0981#%E5%9F%BA%E6%9C%AC%E7%9A%84%E3%81%AA%E4%BD%9C%E3%82%8A
/*
public enum GameState
{
    // �J�n
    KeyInput, // �L�[���͑҂����v���C���[�^�[���J�n
    PlayerTurn, //�v���C���[�̍s����
    EnemyBegin, // �G�l�~�[�^�[���J�n
    EnemyTurn, //�G�l�~�[�̍s����
    TurnEnd,   // �^�[���I����KeyInput�֕ϑJ
};

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject[] EnemyObj; //�G�l�~�[�ɃA�^�b�`���Ă���֐����g�����߂̃n�R
    public GameState CurrentGameState; //���݂̃Q�[�����
    float TurnDelay = 0.20f; //�ړ����Ƃ̊Ԋu

    void Awake()
    {
        SetCurrentState(GameState.KeyInput); //������Ԃ̓L�[���͑҂�

        // �C���X�^���X�𐶐�(���ɂ���ꍇ�͔j��)
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);  // �V�[���ǂݍ��݂ŏ����Ȃ��悤�ɂ���
    }

    //���݂̃Q�[���X�e�[�^�X��ύX����֐��@�O���y�ѓ�������
    public void SetCurrentState(GameState state)
    {
        CurrentGameState = state;
        OnGameStateChanged(CurrentGameState);
    }

    void OnGameStateChanged(GameState state)
    {
        switch (state)
        {
            case GameState.KeyInput:
                break;

            case GameState.PlayerTurn:
                StartCoroutine("PlayerTurn");
                break;

            case GameState.EnemyBegin:
                SetCurrentState(GameState.EnemyTurn);
                break;

            case GameState.EnemyTurn:
                StartCoroutine("EnemyTurn");
                break;

            case GameState.TurnEnd:
                SetCurrentState(GameState.KeyInput);
                break;
        }
    }

    //�L�[���͌�v���C���[�̈ړ����̏���
    IEnumerator PlayerTurn()
    {
        yield return new WaitForSeconds(TurnDelay);
        SetCurrentState(GameState.EnemyBegin);

    }

    //�G�l�~�[�^�[���̏���
    IEnumerator EnemyTurn()
    {
        yield return new WaitForSeconds(TurnDelay);
        GameObject[] EnemyObj = GameObject.FindGameObjectsWithTag("Enemy");

        //EnemyObj�̐�����Enemy�ɃA�^�b�`���Ă���ړ����������s
        for (int x = 0; x < EnemyObj.Length; ++x)
        {
            yield return new WaitForSeconds(TurnDelay);
            EnemyObj[x].GetComponent<Enemy>().MoveEnemy();
        }

        SetCurrentState(GameState.TurnEnd);
    }
}
*/
