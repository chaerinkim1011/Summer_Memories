using System;
using UnityEngine;

namespace SummerMemories.Puzzle
{
    /// <summary>Tracks piece placement and raises an event when the board is complete.</summary>
    public sealed class PuzzleBoard : MonoBehaviour
    {
        [SerializeField] private PuzzlePiece[] pieces = Array.Empty<PuzzlePiece>();

        public event Action Completed;
        public int PlacedCount { get; private set; }
        public int PieceCount => pieces.Length;

        public void RegisterPlacedPiece(PuzzlePiece piece)
        {
            if (piece == null || !piece.IsPlaced || pieces.Length == 0)
                return;

            PlacedCount = Mathf.Min(PlacedCount + 1, pieces.Length);
            if (PlacedCount == pieces.Length)
                Completed?.Invoke();
        }
    }
}
