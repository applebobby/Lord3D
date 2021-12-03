using System;
using System.Collections.Generic;
using UnityEngine;

public class MsgManager
{
    private static MsgManager instance = null;

    public static MsgManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new MsgManager();
            }
            return instance;
        }
    }

    private Dictionary<ushort, List<Action<object[]>>> ActDic = new Dictionary<ushort, List<Action<object[]>>>();

    public void RegisterAct(Enum e, Action<object[]> act)
    {
        var id = Convert.ToUInt16(e);

        if (!ActDic.ContainsKey(id))
        {
            var list = new List<Action<object[]>>();
            ActDic.Add(id, list);
        }

        var actList = ActDic[id];
        if (!actList.Contains(act))
        {
            actList.Add(act);
        }
        else
        {
            Debug.LogWarning("重复添加Act");
        }
    }

    public void unRegisterAct(Enum e, Action<object[]> act)
    {
        var id = Convert.ToUInt16(e);

        if (!ActDic.ContainsKey(id))
        {
            Debug.LogWarning("");
            return;
        }

        var list = ActDic[id];
        if (!list.Contains(act))
        {
            Debug.LogWarning("");
            return;
        }
        else
        {
            list.Remove(act);
            if (list.Count == 0)
            {
                ActDic.Remove(id);
            }
        }
    }

    public void CallAct(Enum e, params object[] args)
    {
        var id = Convert.ToUInt16(e);
        if (!ActDic.ContainsKey(id))
        {
            Debug.LogWarning($"ActDic 中没有注册{e.ToString()}");
            return;
        }
        ActDic[id][0](args);
    }

    public void CallallAct(Enum e, params object[] args)
    {
        var id = Convert.ToUInt16(e);
        if (!ActDic.ContainsKey(id))
        {
            Debug.LogWarning($"ActDic 中没有注册{e.ToString()}");
            return;
        }
        for (int i = 0; i < ActDic.Count; i++)
        {
            ActDic[id][i](args);
        }
    }
}
