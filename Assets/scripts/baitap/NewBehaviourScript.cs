using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] int maxLevel = 20;
    [SerializeField] int currentLevel = 7;
    [SerializeField] int levelsIn1Page = 8;
    [SerializeField] int pagesCount;
    [SerializeField] int currentPages;
    [SerializeField] CreateLvlButtons clb;
    // Start is called before the first frame update
    void Start()
    {
        pagesCount = maxLevel / levelsIn1Page + 1;
        currentPages = currentLevel / levelsIn1Page + 1;
        clb.create(levelsIn1Page, currentLevel, currentPages);
    }
}
