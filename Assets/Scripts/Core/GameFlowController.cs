using UnityEngine;
using UnityEngine.SceneManagement;

namespace SummerMemories.Core
{
    /// <summary>Coordinates high-level transitions between the menu and a story chapter.</summary>
    public sealed class GameFlowController : MonoBehaviour
    {
        [SerializeField] private string menuScene = "MainMenu";
        [SerializeField] private string gameplayScene = "Gameplay";

        public void OpenMenu() => LoadScene(menuScene);

        public void StartStory() => LoadScene(gameplayScene);

        private static void LoadScene(string sceneName)
        {
            if (string.IsNullOrWhiteSpace(sceneName))
            {
                Debug.LogError("A scene name is required to change scenes.");
                return;
            }

            SceneManager.LoadScene(sceneName);
        }
    }
}
