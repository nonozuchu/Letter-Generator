using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterStampManager : MonoBehaviour
{
    [SerializeField] LetterManager _letterManager;
    public void Start()
    {
        GetComponent<Image>().sprite =  _letterManager.senderKingdom.kingdomStamp;
    }
}
