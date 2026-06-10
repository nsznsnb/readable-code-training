import { useEffect, useState } from "react";
import { fetchLessons } from "@/api/lessonApi";
import { LessonCard } from "@/components/lessons/LessonCard";
import type { Lesson } from "@/types/Lesson";

export function LessonListPage() {
  const [lessons, setLessons] = useState<Lesson[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [errorMessage, setErrorMessage] = useState("");

  useEffect(() => {
    async function loadLessons() {
      try {
        setIsLoading(true);
        setErrorMessage("");

        // 初回表示時にレッスン一覧を取得する
        const lessons = await fetchLessons();

        setLessons(lessons);
      } catch {
        // API障害時に画面が空白にならないよう、利用者向けのメッセージを表示する
        setErrorMessage("レッスン一覧を取得できませんでした。");
      } finally {
        // 成功・失敗に関係なく、読み込み状態を解除する
        setIsLoading(false);
      }
    }

    loadLessons();
  }, []);

  if (isLoading) {
    return <p>読み込み中...</p>;
  }

  if (errorMessage) {
    return <p>{errorMessage}</p>;
  }

  return (
    <main>
      <h1>リーダブルコード学習</h1>

      <p>C#とReactのコード例を使って、読みやすいコードの書き方を学びます。</p>

      <div>
        {lessons.map((lesson) => (
          <LessonCard key={lesson.id} lesson={lesson} />
        ))}
      </div>
    </main>
  );
}
