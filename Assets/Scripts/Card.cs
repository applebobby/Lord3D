using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private Animation animation;
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    public void OnEnter()
    {
        animation.Play("UpCard");
    }
    public void OnExit()
    {
        animation.Play("DownCard");
    }
}
