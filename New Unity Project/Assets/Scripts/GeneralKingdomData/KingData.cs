using UnityEngine;

namespace Messenger.GeneralKingdomData
{
    [CreateAssetMenu( menuName = "King", fileName = "New King from KingdomName Kingdom")]
    public class KingData : ScriptableObject
    {
        public string kingName;
        
        [SerializeField] private string[] possibleKingNames;
        
        public WritingStyle kingWritingStyle;

        public void SetRandomKingName()
        {
            
            kingName = possibleKingNames[Random.Range(0, possibleKingNames.Length)];
        }
    }
}
