using Messenger.CoreData;
using UnityEngine;


namespace Messenger.MonoBehaviorScripts.LetterManagers
{
    public class LetterManager : MonoBehaviour
    {
        [SerializeField] private KingdomData[] kingdoms;
        public KingdomData senderKingdom;
        private void Awake()
        {
            senderKingdom = kingdoms[Random.Range(0,kingdoms.Length)];
            senderKingdom.king.SetRandomKingName();
            
        }
    }
}
