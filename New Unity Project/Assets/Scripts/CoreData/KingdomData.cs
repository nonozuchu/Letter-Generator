using Messenger.GeneralKingdomData;
using Messenger.GeneralKingdomData.ScriptableObjects;
using UnityEngine;

namespace Messenger.CoreData
{
    [CreateAssetMenu( menuName = "Kingdom Data", fileName = "KingdomName Data")]
    public class KingdomData : ScriptableObject
    {
        public KingData king;
        public string kingdomName;
        public Sprite kingdomStamp;
    }
}
