using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageData : MonoBehaviour
{
    [SerializeField] Transform pinpoint1, pinpoint2, pinpoint3;
    [SerializeField] CreateLvlGroup conten;
    [SerializeField] float speed = 10;
    float currentSpeed;
    Transform directPin;
    GameObject newGroup;
    GameObject CurrentGroup;
    public GameObject ChangePage(GameObject currentGr, bool isNext, int levelsIn1Page, int currentLevel, int currentPages, int MaxLvl)
    {
        currentSpeed = speed;
        CurrentGroup = currentGr;
        newGroup = conten.createAGroup(levelsIn1Page, currentLevel, currentPages, MaxLvl).gameObject;
        if (isNext)
        {
            newGroup.transform.position = pinpoint3.position;
            directPin = pinpoint1;
        }
        else
        {
            newGroup.transform.position = pinpoint1.position;
            directPin = pinpoint3;
        }
        return newGroup;
    }

    public bool MovePages()
    {
        if (newGroup.transform.position == pinpoint2.position)
        {
            DoneChange();
            return true;
        }
        var step = speed * Time.deltaTime;
        CurrentGroup.transform.position = Vector2.MoveTowards(
            CurrentGroup.transform.position, directPin.position, step);
        newGroup.transform.position = Vector2.MoveTowards(
            newGroup.transform.position, pinpoint2.position, step);
        return false;
    }

    public void DoneChange()
    {
        Destroy(CurrentGroup);
    }

    public void changeSpeed(int times)
    {
        currentSpeed = currentSpeed * times;
    }
}
