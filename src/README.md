# Readable Code Training

C# と React を使って、「読みやすいコード」の考え方を新人教育するための学習アプリです。

本アプリでは、悪いコード例と改善コード例を比較しながら、命名、関数分割、条件分岐、コメント、React コンポーネント分割などを学べるようにします。

## 目的

新人が、単に「動くコード」を書くだけでなく、他人が読んで理解・修正・拡張しやすいコードを書けるようになることを目的とします。

特に以下の観点を学習対象とします。

- 分かりやすい名前を付ける
- 誤解されにくい名前を付ける
- 関数を小さくする
- 条件分岐を読みやすくする
- ネストを浅くする
- 適切なコメントを書く
- React コンポーネントを分割する
- C# の業務ロジックを読みやすく整理する

## 技術構成

| 区分           | 技術                      |
| -------------- | ------------------------- |
| フロントエンド | React / TypeScript / Vite |
| バックエンド   | ASP.NET Core Web API      |
| 開発言語       | C# / TypeScript           |
| パッケージ管理 | npm                       |
| API連携        | REST API                  |

## プロジェクト構成

```text
readable-code-training/
├─ ReadableCodeTraining.sln
├─ src/
│  ├─ ReadableCodeTraining.Api/
│  └─ readable-code-training-web/
├─ docs/
└─ README.md
```

## フロントエンド構成

```text
src/readable-code-training-web/
└─ src/
   ├─ api/
   │  └─ lessonApi.ts
   ├─ components/
   │  └─ lessons/
   │     └─ LessonCard.tsx
   ├─ pages/
   │  └─ LessonListPage.tsx
   ├─ types/
   │  └─ Lesson.ts
   ├─ App.tsx
   └─ main.tsx
```

## バックエンド構成

```text
src/ReadableCodeTraining.Api/
├─ Controllers/
│  └─ LessonsController.cs
├─ Dtos/
│  └─ LessonDto.cs
├─ Seeds/
│  └─ LessonSeed.cs
└─ Program.cs
```

## 現在の実装範囲

現在は、最初のMVPとしてレッスン一覧表示まで実装しています。

実装済みの内容は以下です。

- レッスン一覧画面
- レッスンカード表示
- レッスン一覧取得API
- React から ASP.NET Core Web API への API 呼び出し
- Vite proxy 設定
- `@` alias による import パス設定

## 起動手順

### 1. バックエンドAPIを起動する

```bash
cd src/ReadableCodeTraining.Api
dotnet run
```

起動後、以下のようなURLで API が起動します。

```text
https://localhost:7001
```

API の疎通確認は以下で行います。

```text
https://localhost:7001/api/lessons
```

レッスン一覧の JSON が返れば、バックエンドAPIは正常に動作しています。

### 2. フロントエンドを起動する

別のターミナルを開き、以下を実行します。

```bash
cd src/readable-code-training-web
npm install
npm run dev
```

起動後、以下にアクセスします。

```text
http://localhost:5173
```

レッスン一覧が表示されれば成功です。

## API一覧

### レッスン一覧取得

```text
GET /api/lessons
```

レッスン一覧を表示順に取得します。

レスポンス例：

```json
[
  {
    "id": 1,
    "title": "読みやすいコードとは",
    "category": "基礎",
    "description": "良いコードとは、他人が読んで理解・修正しやすいコードであることを学びます。",
    "difficulty": 1,
    "displayOrder": 1,
    "isCompleted": false
  }
]
```

## 開発メモ

### import パス

フロントエンドでは、相対パスではなく `@` alias を使用します。

```tsx
import { fetchLessons } from "@/api/lessonApi";
import { LessonCard } from "@/components/lessons/LessonCard";
import type { Lesson } from "@/types/Lesson";
```

### JSX ファイルの拡張子

React コンポーネントは JSX を含むため、拡張子は `.tsx` にします。

```text
LessonListPage.tsx
LessonCard.tsx
```

`.ts` にすると JSX が正しく解釈されず、構文エラーになります。

### API proxy

React 開発サーバーから ASP.NET Core API を呼び出すため、Vite の proxy を使用します。

```ts
server: {
  proxy: {
    "/api": {
      target: "https://localhost:7001",
      changeOrigin: true,
      secure: false,
    },
  },
}
```

`target` は、実際に起動している ASP.NET Core API の URL に合わせます。

## 今後の実装予定

次に実装する予定の機能は以下です。

- レッスン詳細画面
- `開始する` ボタンから詳細画面への遷移
- React Router の導入
- レッスン詳細取得API
- 悪いコード例と改善コード例の表示
- 解説表示
- クイズ機能
- 学習進捗管理
- 管理画面

## Git 管理方針

本プロジェクトは、フロントエンド、バックエンド、ドキュメントを1つの Git リポジトリで管理します。

```text
readable-code-training
```

フロントエンドとバックエンドはセットで動作するため、同じリポジトリで管理することで、API変更と画面変更の履歴をまとめて追跡しやすくします。

## 注意事項

このアプリは、「読みやすいコード」の考え方を学ぶための社内教育用アプリです。
