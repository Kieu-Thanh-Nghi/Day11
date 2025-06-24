using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    [SerializeField] ToggleGroup togG;
    [SerializeField] PlayStage ps;
    public void NhapSoSao()
    {
        Toggle tg = togG.GetFirstActiveToggle();
        ps.NhapStar(int.Parse(tg.GetComponentInChildren<Text>().text));
    }
}
