using SummerMemories.Story;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SummerMemories.UI
{
    /// <summary>Displays the title, story excerpt, and image for the current chapter.</summary>
    public sealed class StoryPanelController : MonoBehaviour
    {
        [SerializeField] private StorySequenceController story;
        [SerializeField] private TMP_Text titleLabel;
        [SerializeField] private TMP_Text storyLabel;
        [SerializeField] private Image illustration;

        private void OnEnable() => Refresh();

        public void Refresh()
        {
            StoryChapterData chapter = story != null ? story.CurrentChapter : null;
            if (chapter == null)
                return;

            if (titleLabel != null) titleLabel.text = chapter.Title;
            if (storyLabel != null) storyLabel.text = chapter.OpeningText;
            if (illustration != null) illustration.sprite = chapter.CompletedPuzzleImage;
        }
    }
}
