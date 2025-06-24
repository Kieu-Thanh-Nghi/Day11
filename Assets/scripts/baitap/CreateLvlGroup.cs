using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLvlGroup : MonoBehaviour
{
    [SerializeField] GameObject clb;
    [SerializeField] Controller ctrler;
    [SerializeField] LvlData data;
    // Start is called before the first frame update
    public CreateLvlButtons createAGroup(int levelsIn1Page, int currentLevel, int currentPages, int LvlMax)
    {
        GameObject LvlButtons = Instantiate(clb, transform);
        CreateLvlButtons aGroup = LvlButtons.GetComponent<CreateLvlButtons>();
        aGroup.updateController(ctrler, data);
        aGroup.create(levelsIn1Page, currentLevel, currentPages, LvlMax);
        return aGroup;
    }
}
