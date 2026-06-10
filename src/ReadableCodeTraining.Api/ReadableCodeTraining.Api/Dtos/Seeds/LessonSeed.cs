namespace ReadableCodeTraining.Api.Dtos.Seeds
{
    public static class LessonSeed
    {
        public static List<LessonDto> Lessons = new()
    {
        new LessonDto
        {
            Id = 1,
            Title = "読みやすいコードとは",
            Category = "基礎",
            Description = "良いコードとは、他人が読んで理解・修正しやすいコードであることを学びます。",
            Difficulty = 1,
            DisplayOrder = 1,
            IsCompleted = false
        },
        new LessonDto
        {
            Id = 2,
            Title = "分かりやすい名前を付ける",
            Category = "命名",
            Description = "変数名、関数名、クラス名から意図が伝わる名前の付け方を学びます。",
            Difficulty = 1,
            DisplayOrder = 2,
            IsCompleted = false
        },
        new LessonDto
        {
            Id = 3,
            Title = "誤解されにくい名前を付ける",
            Category = "命名",
            Description = "似た意味の単語や曖昧な名前を避け、読み手に誤解されない命名を学びます。",
            Difficulty = 1,
            DisplayOrder = 3,
            IsCompleted = false
        },
        new LessonDto
        {
            Id = 4,
            Title = "関数を小さくする",
            Category = "関数",
            Description = "1つの関数に複数の責務を持たせず、目的ごとに分割する考え方を学びます。",
            Difficulty = 2,
            DisplayOrder = 4,
            IsCompleted = false
        },
        new LessonDto
        {
            Id = 5,
            Title = "条件分岐を読みやすくする",
            Category = "条件分岐",
            Description = "複雑なif文を、読みやすい条件式や名前付きメソッドに整理する方法を学びます。",
            Difficulty = 2,
            DisplayOrder = 5,
            IsCompleted = false
        },
        new LessonDto
        {
            Id = 6,
            Title = "コメントの書き方",
            Category = "コメント",
            Description = "コードを見れば分かるコメントではなく、理由や背景を説明するコメントの書き方を学びます。",
            Difficulty = 2,
            DisplayOrder = 6,
            IsCompleted = false
        },
        new LessonDto
        {
            Id = 7,
            Title = "Reactコンポーネントを分割する",
            Category = "React",
            Description = "JSXが複雑になりすぎないように、役割ごとにコンポーネントを分割する方法を学びます。",
            Difficulty = 2,
            DisplayOrder = 7,
            IsCompleted = false
        },
        new LessonDto
        {
            Id = 8,
            Title = "C#の業務ロジックを読みやすくする",
            Category = "C#",
            Description = "業務条件、計算処理、判定処理を読みやすく整理する方法を学びます。",
            Difficulty = 3,
            DisplayOrder = 8,
            IsCompleted = false
        }
    };
    }
}
