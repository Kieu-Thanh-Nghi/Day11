using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLvl : MonoBehaviour
{
    [SerializeField] Text tx;
    [SerializeField] Image Star1;
    [SerializeField] Image Star2;
    [SerializeField] Image Star3;
    [SerializeField] Sprite spStar1;
    [SerializeField] Sprite spStar2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changeTextLvl(int lvl)
    {
        tx.text = lvl.ToString();
    }
}
