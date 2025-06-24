using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Controller : MonoBehaviour
{
    [SerializeField] int maxLevel = 20;
    [SerializeField] int currentLevel = 7;
    [SerializeField] int levelsIn1Page = 8;
    [SerializeField] int pagesCount;
    [SerializeField] int currentPages;
    [SerializeField] CreateLvlGroup conten;
    [SerializeField] PageData pd;
    [SerializeField] DotControl dc;
    [SerializeField] LvlData data;
    [SerializeField] PlayStage playstage;
    bool isChangePage = false;
    GameObject currentGroup;
    // Start is called before the first frame update
    void OnEnable()
    {
        currentLevel = data.unLockLvlQuantity();
        pagesCount = (int)Mathf.Ceil((float)maxLevel / levelsIn1Page);
        currentPages = (int)Mathf.Ceil((float)currentLevel / levelsIn1Page);
        currentGroup = conten.createAGroup(
            levelsIn1Page, currentLevel, currentPages, -1).gameObject;
    }

    private void Update()
    {
        if (isChangePage)
        {
            isChangePage = !pd.MovePages() || !dc.DotMove();
        }
    }

    public void PlayAGame(int playLevel)
    {
        playstage.setUpLvl(playLevel);
        playstage.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
    public void NextPages()
    {
        if (isChangePage)
        {
            dc.changeSpeed(2);
            pd.changeSpeed(2);
            return;
        }        
        dc.NextDot(currentPages,pagesCount);
        int LvlQuantity = levelsIn1Page;
        int LvlMax = -1;
        if(currentPages == pagesCount)
        {
            currentPages = 1;
        }
        else
        {
            currentPages++;
        }
        if(currentPages == pagesCount)
        {
            LvlQuantity = maxLevel % levelsIn1Page;
            LvlMax = maxLevel;
        }
        currentGroup = pd.ChangePage(currentGroup, true, LvlQuantity, currentLevel, currentPages, LvlMax);
        isChangePage = true;
    }
    public void PrevPages()
    {
        if (isChangePage)
        {
            dc.changeSpeed(2);
            pd.changeSpeed(2);
            return;
        }
        dc.PrevDot(currentPages, pagesCount);
        int LvlQuantity;
        int LvlMax = -1;
        if (currentPages == 1)
        {
            currentPages = pagesCount;
            LvlQuantity = maxLevel % levelsIn1Page;
            LvlMax = maxLevel;
        }
        else
        {
            currentPages--;
            LvlQuantity = levelsIn1Page;
        }
        currentGroup = pd.ChangePage(currentGroup, false, LvlQuantity, currentLevel, currentPages, LvlMax);
        isChangePage = true;
    }
}
