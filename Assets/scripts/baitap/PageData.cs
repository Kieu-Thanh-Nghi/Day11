using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageData : MonoBehaviour
{
    [SerializeField] Transform pinpoint1, pinpoint2, pinpoint3;
    [SerializeField] GameObject LvlGroup1, LvlGroup2;
    [SerializeField] float speed = 10;
    public bool changePage()
    {
        if (LvlGroup1.transform.position == pinpoint1.position)
        {
            return true;
        }
        var step = speed * Time.deltaTime;
        LvlGroup1.transform.position = Vector2.MoveTowards(
            LvlGroup1.transform.position, pinpoint1.position, step);
        LvlGroup2.transform.position = Vector2.MoveTowards(
            LvlGroup2.transform.position, pinpoint2.position, step);
        return false;
    }

    public void DoneChange()
    {
        LvlGroup1.transform.position = pinpoint3.position;
        GameObject temp = LvlGroup1;
        LvlGroup1 = LvlGroup2;
        LvlGroup2 = temp;
    }
}
