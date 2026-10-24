using UnityEngine;

namespace SummerMemories.Puzzle
{
    /// <summary>Runtime state for one draggable piece of a puzzle image.</summary>
    public sealed class PuzzlePiece : MonoBehaviour
    {
        [SerializeField] private int pieceIndex;
        [SerializeField] private Transform snapTarget;

        public int PieceIndex => pieceIndex;
        public bool IsPlaced { get; private set; }

        public void Configure(int index, Transform target)
        {
            pieceIndex = index;
            snapTarget = target;
            IsPlaced = false;
        }

        public bool TryPlace(float snapDistance)
        {
            if (IsPlaced || snapTarget == null)
                return false;

            if (Vector3.Distance(transform.position, snapTarget.position) > snapDistance)
                return false;

            transform.SetPositionAndRotation(snapTarget.position, snapTarget.rotation);
            IsPlaced = true;
            return true;
        }
    }
}
