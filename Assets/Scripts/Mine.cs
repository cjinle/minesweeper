using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mine : MonoBehaviour,IPointerClickHandler
{
    int idx;

    MainCtrl ctrl;

    void Start()
    {
        //GetComponent<Image>().color = Color.blue;
        var btn = gameObject.AddComponent<Button>();
        //btn.onClick.AddListener(Click);
    }

    void Click()
    {
        ctrl.SendMessage("Clear", idx);
    }
        

    public void SetIdx(int i)
    {
        idx = i;
        this.name = "mine"+i;
    }

    public void SetCtrl(MainCtrl obj)
    {
        ctrl = obj;
    }

    public void SetFlag(string flag)
    {
        Color c;
        string txt;
        switch (flag)
        {
            case "Mine":
                txt = "B";
                c = Color.red;
                break;
            case "Empty":
                txt = "";
                c = Color.gray;
                break;
            default:
                txt = flag;
                c = Color.blue;
                break;
        }
        GetComponent<Image>().color = Color.gray;
        GetComponentInChildren<Text>().text = txt;
        GetComponentInChildren<Text>().color = c;
    }

    public void OnPointerClick(PointerEventData evenData)
    {
        Debug.Log(evenData);
        ctrl.SendMessage("Clear", idx);
    }

}
