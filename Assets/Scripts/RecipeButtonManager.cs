using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeButtonManager : MonoBehaviour {

    public GameObject textObj;

	public void increment()
    {
        Text text = textObj.GetComponent<Text>();
        int val = int.Parse(text.text);
        if (val < 10)
        {
            val++;
            text.text = val.ToString();
        }
    }

    public void decrement()
    {
        Text text = textObj.GetComponent<Text>();
        int val = int.Parse(text.text);
        if (val > 1)
        {
            val--;
            text.text = val.ToString();
        }
    }
}
