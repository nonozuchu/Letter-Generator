using Messenger.CoreData;
using UnityEngine;
using UnityEngine.Serialization;

namespace Messenger.MonoBehaviorScripts.LetterManagers
{
    public class LetterManager : MonoBehaviour
    {
        [FormerlySerializedAs("_kingdoms")] [SerializeField] private KingdomData[] kingdoms;
        public KingdomData senderKingdom;
        private void Awake()
        {
            senderKingdom = kingdoms[Random.Range(0,kingdoms.Length)];
        }
    }
}
