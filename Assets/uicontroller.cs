using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class uicontroller : MonoBehaviour,IcalculatorView
{
    public Text txt1;
    public Text txt2;
    public Text txtResult;

    public Presenter presenter;

    public string TxtNumberOne { get => txt1.text; set => txt1.text = value; }
    public string TxtNumberTwo { get => txt2.text; set => txt2.text = value; }
    public string TxtResult { get => txtResult.text; set => txtResult.text = value; }


    // Start is called before the first frame update
    void Start()
    {
        presenter = new Presenter(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sum()
    {
        presenter.calcSum();
    }
}
