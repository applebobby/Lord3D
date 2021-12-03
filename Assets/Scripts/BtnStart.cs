using UnityEngine;
using UnityEngine.UI;

public class BtnStart : MonoBehaviour
{
    private GameObject btnStartObj;
    private Button btnStart;


    // Start is called before the first frame update
    void Start()
    {
        btnStartObj = GameObject.Find("BtnStart");
        btnStart = btnStartObj.GetComponent<Button>();
        btnStart.onClick.AddListener(startGame);
    }

    void startGame()
    {
        MsgManager.Instance.CallAct(MsgType.START_GAME, "aa");
    }
}
