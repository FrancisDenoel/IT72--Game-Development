using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllScript : MonoBehaviour
{
    public InputField numberIn;
    public Text numberOut;
    private string key = "0num";

    public void SaveNumber()
    {
        int i = int.Parse(numberIn.text);
        PlayerPrefs.SetInt("0num", i);
    }

    public void Shownumber()
    {
        numberOut.text = PlayerPrefs.GetInt(key).ToString();
    }

    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
    }
}
