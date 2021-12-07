using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject panel;
    private GameObject environment;
    private GameObject table;
    private GameObject ownhands;
    // Start is called before the first frame update
    void Start()
    {
        // ui界面
        GameObject scene = GameObject.Find("Canvas");
        panel = scene.transform.Find("Panel").gameObject;

        // 游戏场景
        GameObject gameRoot = GameObject.Find("GameRoot");
        environment = gameRoot.transform.Find("Environment").gameObject;
        table = environment.transform.Find("Table").gameObject;
        ownhands = environment.transform.Find("OwnHands").gameObject;

        RegistEvent();
    }

    private void RegistEvent()
    {
        MsgManager.Instance.RegisterAct(MsgType.START_GAME, OnStart);
    }

    void OnStart(object obj)
    {
        panel.SetActive(false);
        environment.SetActive(true);
    }
}
