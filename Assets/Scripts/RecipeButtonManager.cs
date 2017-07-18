using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeButtonManager : MonoBehaviour {

    public GameObject textObj;

	public void increment(GameObject btn)
    {
        Text text = textObj.GetComponent<Text>();
        int val = 1;
        if(btn.gameObject.tag == "Lemon")
        {
            val = GameMaster.lemonRecipe;
            if (val < 10)
            {
                val++;
                GameMaster.lemonRecipe = val;
                text.text = val.ToString();
            }
        }else if (btn.gameObject.tag == "Ice")
        {
            val = GameMaster.iceRecipe;
            if (val < 10)
            {
                val++;
                GameMaster.iceRecipe = val;
                text.text = val.ToString();
            }
        }else if (btn.gameObject.tag == "Sugar")
        {
            val = GameMaster.sugarRecipe;
            if (val < 10)
            {
                val++;
                GameMaster.sugarRecipe = val;
                text.text = val.ToString();
            }
        }
    }

    public void decrement(GameObject btn)
    {
        Text text = textObj.GetComponent<Text>();
        int val = 1;
        if (btn.gameObject.tag == "Lemon")
        {
            val = GameMaster.lemonRecipe;
            if (val > 1)
            {
                val--;
                GameMaster.lemonRecipe = val;
                text.text = val.ToString();
            }
        }
        else if (btn.gameObject.tag == "Ice")
        {
            val = GameMaster.iceRecipe;
            if (val > 1)
            {
                val--;
                GameMaster.iceRecipe = val;
                text.text = val.ToString();
            }
        }
        else if (btn.gameObject.tag == "Sugar")
        {
            val = GameMaster.sugarRecipe;
            if (val > 1)
            {
                val--;
                GameMaster.sugarRecipe = val;
                text.text = val.ToString();
            }
        }
    }
}
