using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mine : MonoBehaviour,IPointerClickHandler
{
    int idx;

    bool isMarked;

    MainCtrl ctrl;

    void Start()
    {
        //GetComponent<Image>().color = Color.blue;
        var btn = gameObject.AddComponent<Button>();
        //btn.onClick.AddListener(Click);
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
        if (isMarked)
        {
            Debug.Log(idx+"is marked");
            return;
        }
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

    public void Mark()
    {
        isMarked = true;
        GetComponentInChildren<Text>().text = "F";
    }

    public void UnMark()
    {
        isMarked = false;
        GetComponentInChildren<Text>().text = "";
    }

    public void OnPointerClick(PointerEventData evenData)
    {
        //Debug.Log(evenData);
        if (evenData.button == PointerEventData.InputButton.Right)
        {
            if (isMarked)
            {
                UnMark();
            }
            else
            {
                Mark();
            }
        }
        else
        {
            ctrl.SendMessage("Clear", idx);
        }
    }

}
