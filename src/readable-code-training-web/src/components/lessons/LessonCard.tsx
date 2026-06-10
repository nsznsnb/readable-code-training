import type { Lesson } from "@/types/Lesson";

type LessonCardProps = {
  lesson: Lesson;
};

export function LessonCard({ lesson }: LessonCardProps) {
  return (
    <section>
      <h2>{lesson.title}</h2>

      <p>{lesson.description}</p>

      <p>
        <strong>カテゴリ:</strong> {lesson.category}
      </p>

      <p>
        <strong>難易度:</strong> {getDifficultyText(lesson.difficulty)}
      </p>

      <p>
        <strong>状態:</strong> {lesson.isCompleted ? "完了" : "未完了"}
      </p>

      <button type="button">開始する</button>
    </section>
  );
}

function getDifficultyText(difficulty: number): string {
  switch (difficulty) {
    case 1:
      return "初級";
    case 2:
      return "中級";
    case 3:
      return "応用";
    default:
      return "未設定";
  }
}
