using UnityEngine;

namespace SaveSystem
{
    public class GameDataProvider : MonoBehaviour
    {
        [SerializeField] private GameData _currentData;

        private readonly string Key = "save.data";

        void Awake()
        {
            if (ClassPrefs.HasKey(Key))
            {
                _currentData = ClassPrefs.GetClassByKey<GameData>(Key);
                Debug.Log("Data loaded");
            }
            else
            {
                Debug.Log("New data created");

                _currentData = new GameData();
                ClassPrefs.SetClass(Key, _currentData);
            }
        }

        private void OnApplicationFocus(bool focus)
        {
            if (focus == false)
                ClassPrefs.SetClass(Key, _currentData);
        }
    }
}
