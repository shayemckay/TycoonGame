using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void buyLemon(GameObject btn) {
        CostManager costMan = btn.GetComponent<CostManager>();
        int quan = costMan.quantity;
        int cost = costMan.cost;
        if (btn.gameObject.tag.Equals("10"))
        {
            if (GameMaster.cash - cost >= 0)
            {
                GameMaster.cash -= cost;
                GameMaster.lemon += quan;
            }
        }
        else if (btn.gameObject.tag.Equals("50"))
        {
            if (GameMaster.cash - cost >= 0)
            {
                GameMaster.cash -= cost;
                GameMaster.lemon += quan;
            }
        }
    }

    public void buyIce(GameObject btn)
    {
        CostManager costMan = btn.GetComponent<CostManager>();
        int quan = costMan.quantity;
        int cost = costMan.cost;
        if (btn.gameObject.tag.Equals("50"))
        {
            if (GameMaster.cash - cost >= 0)
            {
                GameMaster.cash -= cost;
                GameMaster.ice += quan;
            }
        }
        else if (btn.gameObject.tag.Equals("200"))
        {
            if (GameMaster.cash - cost >= 0)
            {
                GameMaster.cash -= cost;
                GameMaster.ice += quan;
            }
        }
    }

    public void buyCups(GameObject btn)
    {
        CostManager costMan = btn.GetComponent<CostManager>();
        int quan = costMan.quantity;
        int cost = costMan.cost;
        if (btn.gameObject.tag.Equals("50"))
        {
            if (GameMaster.cash - cost >= 0)
            {
                GameMaster.cash -= cost;
                GameMaster.cups += quan;
            }
        }
        else if (btn.gameObject.tag.Equals("200"))
        {
            if (GameMaster.cash - cost >= 0)
            {
                GameMaster.cash -= cost;
                GameMaster.cups += quan;
            }
        }
    }

    public void buySugar(GameObject btn)
    {
        CostManager costMan = btn.GetComponent<CostManager>();
        int quan = costMan.quantity;
        int cost = costMan.cost;
        if (btn.gameObject.tag.Equals("10"))
        {
            if (GameMaster.cash - cost >= 0)
            {
                GameMaster.cash -= cost;
                GameMaster.sugar += quan;
            }
        }
        else if (btn.gameObject.tag.Equals("50"))
        {
            if (GameMaster.cash - cost >= 0)
            {
                GameMaster.cash -= cost;
                GameMaster.sugar += quan;
            }
        }
    }
}
