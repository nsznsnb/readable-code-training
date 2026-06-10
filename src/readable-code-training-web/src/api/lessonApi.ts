import type { Lesson } from "../types/Lesson";

export async function fetchLessons(): Promise<Lesson[]> {
  const response = await fetch("/api/lessons");

  if (!response.ok) {
    throw new Error("レッスン一覧の取得に失敗しました。");
  }

  return response.json();
}
