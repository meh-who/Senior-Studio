using System;
using System.Linq;
using TMPro;
using UnityEngine;

public class Singleton<T> : MonoBehaviour
        where T : Component
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    var objs = FindObjectsOfType(typeof(T)) as T[];
                    if (objs.Length > 0)
                        _instance = objs[0];
                    if (objs.Length > 1)
                    {
                        Debug.LogError("There is more than one " + typeof(T).Name + " in the scene.");
                    }
                    if (_instance == null)
                    {
                        GameObject obj = new GameObject();
                        obj.name = string.Format("_{0}", typeof(T).Name);
                        _instance = obj.AddComponent<T>();
                    }
                }
                return _instance;
            }
        }
    }

namespace DilmerGames.Core.Utilities
{
    public class Logger : Singleton<Logger>
    {
        [SerializeField]
        private TextMeshProUGUI debugAreaText;

        [SerializeField]
        private bool enableDebug = false;

        [SerializeField]
        private int maxLines = 15;

        void OnEnable()
        {
            debugAreaText.enabled = enableDebug;
            enabled = enableDebug;
        }

        public void LogInfo(string message)
        {
            ClearLines();
            debugAreaText.text += $"{DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")} <color=\"white\">{message}</color>\n";
        }

        public void LogError(string message)
        {
            ClearLines();
            debugAreaText.text += $"{DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")} <color=\"red\">{message}</color>\n";
        }

        public void LogWarning(string message)
        {
            ClearLines();
            debugAreaText.text += $"{DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")} <color=\"yellow\">{message}</color>\n";
        }

        private void ClearLines()
        {
            if (debugAreaText.text.Split('\n').Count() >= maxLines)
            {
                debugAreaText.text = string.Empty;
            }
        }
    }
}