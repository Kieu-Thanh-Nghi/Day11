using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    [SerializeField] Toggle toggle;
    [SerializeField] PlayStage ps;
    public void play()
    {
        ps.Completed(toggle.isOn);
    }
}
