using UnityEngine;

namespace SummerMemories.Story
{
    /// <summary>Exposes the active chapter to UI and advances after a puzzle is solved.</summary>
    public sealed class StorySequenceController : MonoBehaviour
    {
        [SerializeField] private StoryChapterData[] chapters;
        private int currentChapterIndex;

        public StoryChapterData CurrentChapter =>
            chapters != null && currentChapterIndex < chapters.Length
                ? chapters[currentChapterIndex]
                : null;

        public bool Advance()
        {
            if (chapters == null || currentChapterIndex + 1 >= chapters.Length)
                return false;

            currentChapterIndex++;
            return true;
        }
    }
}
