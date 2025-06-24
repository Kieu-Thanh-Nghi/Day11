using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotControl : MonoBehaviour
{
    [SerializeField] Transform pin0, pin1, pin2, pin3, pin4;
    [SerializeField] GameObject conten;
    [SerializeField] float speed = 1000;
    float currSpeed;
    Vector2 pin;
    bool isMoving = false;
    public void setCurrentPage(int currPage, int maxPage)
    {
        if (currPage == 1)
        {
            conten.transform.position = pin1.position;
        }
        else if(currPage == maxPage)
        {
            conten.transform.position = pin3.position;
        }
        else
        {
            conten.transform.position = pin2.position;
        }
    }

    public void NextDot(int cp, int maxPg)
    {
        currSpeed = speed;
        if (cp == 1)
        {
            conten.transform.position = pin2.position;
        }
        else if(cp == maxPg - 1){
            conten.transform.position = pin3.position;
        }
        else if(cp == maxPg)
        {
            conten.transform.position = pin0.position;
            pin = pin1.position;
            isMoving = true;
        }
        else
        {
            conten.transform.position = pin3.position;
            pin = pin2.position;
            isMoving = true;
        }
    }

    public void PrevDot(int cp, int maxPg)
    {
        currSpeed = speed;
        if (cp == maxPg)
        {
            conten.transform.position = pin2.position;
        }
        else if (cp == 2)
        {
            conten.transform.position = pin1.position;
        }
        else if (cp == 1)
        {
            conten.transform.position = pin4.position;
            pin = pin3.position;
            isMoving = true;
        }
        else
        {
            conten.transform.position = pin1.position;
            pin = pin2.position;
            isMoving = true;
        }
    }

    public bool DotMove()
    {
        if (!isMoving)
        {
            return true;
        }
        Vector2 groupPos = conten.transform.position;
        if (groupPos == pin)
        {
            isMoving = false;
            return true;
        }

        var step = currSpeed * Time.deltaTime;
        conten.transform.position = Vector2.MoveTowards(
            groupPos, pin, step);
        return false;
    }

    public void changeSpeed(int times)
    {
        currSpeed = currSpeed * times;
    }

    private void OnDisable()
    {
        conten.transform.position = pin1.position;
        isMoving = false;
    }
}
