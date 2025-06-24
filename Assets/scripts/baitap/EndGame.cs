using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] PlayStage ps;
    public void KetThuc()
    {
        gameObject.SetActive(false);
        ps.KetThuc();
    }
}
