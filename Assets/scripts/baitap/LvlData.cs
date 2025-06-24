using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlData : MonoBehaviour
{
    [SerializeField] List<int> LvlStar;

    public void addMoreLvl()
    {
        LvlStar.Add(-1);
    }
    public int unLockLvlQuantity()
    {
        return LvlStar.Count;
    }

    public void updateStar(int index, int starNumber)
    {
        if(LvlStar[index] < starNumber) LvlStar[index] = starNumber;
    }
    public int getStar(int index)
    {
        return LvlStar[index];
    }
}
