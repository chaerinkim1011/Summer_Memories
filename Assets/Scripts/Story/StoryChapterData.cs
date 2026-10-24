using UnityEngine;

namespace SummerMemories.Story
{
    [CreateAssetMenu(fileName = "StoryChapter", menuName = "Summer Memories/Story Chapter")]
    public sealed class StoryChapterData : ScriptableObject
    {
        [SerializeField] private string chapterId;
        [SerializeField] private string title;
        [TextArea(3, 8)] [SerializeField] private string openingText;
        [SerializeField] private Sprite completedPuzzleImage;
        [SerializeField, Min(2)] private int columns = 3;
        [SerializeField, Min(2)] private int rows = 3;

        public string ChapterId => chapterId;
        public string Title => title;
        public string OpeningText => openingText;
        public Sprite CompletedPuzzleImage => completedPuzzleImage;
        public int Columns => columns;
        public int Rows => rows;
    }
}
