using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLvl : MonoBehaviour
{
    [SerializeField] Text tx;
    [SerializeField] Image[] Star;
    [SerializeField] Sprite spStar1;
    [SerializeField] Sprite spStar2;
    int lv = 1;

    public void changeTextLvl(int lvl)
    {
        lv = lvl;
        tx.text = lvl.ToString();
    }
    public void setFunction(Controller ctrler)
    {
        GetComponent<Button>().onClick.AddListener(() => ctrler.PlayAGame(lv));
    }
    public void ChangeStar(int StarNumber)
    {
        for(int i = 0; i < Star.Length; i++)
        {
            if(i < StarNumber)
            {
                Star[i].sprite = spStar1;
                continue;
            }
            Star[i].sprite = spStar2;
        }
    }
}
