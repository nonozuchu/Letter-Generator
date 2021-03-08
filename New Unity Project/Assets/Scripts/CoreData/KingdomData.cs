using Messenger.GeneralKingdomData;
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
