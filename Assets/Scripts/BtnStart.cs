using UnityEngine;
using UnityEngine.UI;

public class BtnStart : MonoBehaviour
{
    private Button btnStart;


    // Start is called before the first frame update
    void Start()
    {
        btnStart = gameObject.GetComponent<Button>();
        btnStart.onClick.AddListener(startGame);
    }

    void startGame()
    {
        MsgManager.Instance.CallAct(MsgType.START_GAME, "this is log msg!");
    }
}
