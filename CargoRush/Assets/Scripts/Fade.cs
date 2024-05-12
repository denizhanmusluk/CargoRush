using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    private static Fade _instance = null;
    public static Fade Instance => _instance;

    private Image image;
    [SerializeField] private float duration;

    private void Awake()
    {
        _instance = this;

        image = GetComponent<Image>();
        //if(GameController.Level==1)
        //    image.color = new Color(0,0,0,1);
    }

    private void Start(){
        Show();
        //if(GameController.Level==1)
        //this.Wait(0.1f,()=>{
        //    Show();
        //});
    }
    public void Hide()
    {
        image.DOFade(1, duration);
    }

    public void Show()
    {
        image.DOFade(0, duration);
    }
}