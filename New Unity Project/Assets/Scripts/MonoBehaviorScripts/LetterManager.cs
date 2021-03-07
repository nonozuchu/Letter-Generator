using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterManager : MonoBehaviour
{
    [SerializeField] KingdomData[] _kingdoms;
    public KingdomData senderKingdom;
    void Awake()
    {
        senderKingdom = _kingdoms[Random.Range(0,_kingdoms.Length)];
    }
}
