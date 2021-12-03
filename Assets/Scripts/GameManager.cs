using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MsgManager.Instance.RegisterAct(MsgType.START_GAME, OnStart);
    }

    void OnStart(object obj)
    {

    }
}
