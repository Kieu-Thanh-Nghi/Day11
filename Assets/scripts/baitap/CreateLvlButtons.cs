using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateLvlButtons : MonoBehaviour
{
    [SerializeField] GameObject ButtonPrefab;
    [SerializeField] GameObject ButtonLockPrefab;
    public void create(int quatity, int currentLvl, int currentPage)
    {
        int total = currentPage * quatity + 1;
        int start = total - quatity;
        int check = start + currentLvl - 1;
        for(int i = start; i < total; i++)
        {
            if (i <= check)
            {
                GameObject pref = Instantiate(ButtonPrefab, gameObject.transform);
                pref.GetComponent<ButtonLvl>().changeTextLvl(i);
            }
            else
            {
                GameObject pref = Instantiate(ButtonLockPrefab, gameObject.transform);
                pref.GetComponent<ButtonLvl>().changeTextLvl(i);
            }
        }
        
    }
}
