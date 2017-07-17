using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

    public GameObject moneyObj;
    public GameObject lemonObj;
    public GameObject iceObj;
    public GameObject sugarObj;
    public GameObject cupsObj;

    public static long cash;
    public static int lemon;
    public static int cups;
    public static int ice;
    public static int sugar;

    private void Start()
    {
        cash = 1000;
    }

    void Update(){
        moneyObj.GetComponentInChildren<Text>().text = "$" + cash;
        lemonObj.GetComponentInChildren<Text>().text = lemon.ToString();
        cupsObj.GetComponentInChildren<Text>().text = cups.ToString();
        sugarObj.GetComponentInChildren<Text>().text = sugar.ToString();
        iceObj.GetComponentInChildren<Text>().text = ice.ToString();
    }
}
