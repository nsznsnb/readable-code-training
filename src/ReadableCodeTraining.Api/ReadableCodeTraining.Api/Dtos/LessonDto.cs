namespace ReadableCodeTraining.Api.Dtos
{
    /// <summary>
    /// レッスン情報
    /// </summary>
    public class LessonDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int Difficulty { get; set; }

        public int DisplayOrder { get; set; }

        public bool IsCompleted { get; set; }
    }
}
