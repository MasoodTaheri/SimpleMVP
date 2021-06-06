using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface IcalculatorView 
{
    string TxtNumberOne { get; set; }
    string TxtNumberTwo { get; set; }
    string TxtResult { get; set; }
}
