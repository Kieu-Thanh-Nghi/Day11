using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLvlButtons : MonoBehaviour
{
    [SerializeField] GameObject ButtonPrefab;
    [SerializeField] GameObject ButtonLockPrefab;
    LvlData Data;
    Controller ctrler;
    public void updateController(Controller ctr, LvlData Dt)
    {
        Data = Dt;
        ctrler = ctr;
    }
    public void create(int quatity, int currentLvl, int currentPage, int MaxLvl)
    {
        int total;
        int start;
        if(MaxLvl > 0) { total = MaxLvl + 1; }
        else { total = currentPage * quatity + 1;  }
        start = total - quatity;
        for(int i = start; i < total; i++)
        {
            if (i <= currentLvl)
            {
                GameObject pref = Instantiate(ButtonPrefab, gameObject.transform);
                ButtonLvl btLv = pref.GetComponent<ButtonLvl>();
                btLv.changeTextLvl(i);
                btLv.setFunction(ctrler);
                btLv.ChangeStar(Data.getStar(i-1));
            }
            else
            {
                GameObject pref = Instantiate(ButtonLockPrefab, gameObject.transform);
                pref.GetComponent<ButtonLvl>().changeTextLvl(i);
            }
        }
    }
    private void OnDisable()
    {
        Destroy(this.gameObject);
    }
}
