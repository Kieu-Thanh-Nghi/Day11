using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStage : MonoBehaviour
{
    [SerializeField] LvlData data;
    [SerializeField] GamePlay pl;
    [SerializeField] Result rs;
    [SerializeField] EndGame eg;
    [SerializeField] Controller ctrler;
    int playingLvl = 1;
    int dataIndex = 0;

    public void setUpLvl(int playLevel)
    {
        playingLvl = playLevel;
        dataIndex = playingLvl - 1;
    }

    public void Completed(bool isComplete)
    {
        bool isNewest = (playingLvl == data.unLockLvlQuantity());
        if (isComplete)
        {
            rs.gameObject.SetActive(true);
            if (isNewest)
            {
                data.addMoreLvl();
            }
        }
        else
        {
            eg.gameObject.SetActive(true);
        }
        
    }
    public void NhapStar(int starNumber)
    {
        data.updateStar(dataIndex, starNumber);
        eg.gameObject.SetActive(true);
    }

    public void KetThuc()
    {
        rs.gameObject.SetActive(false);
        ctrler.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
