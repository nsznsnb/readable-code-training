import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";
import path from "path";

// https://vite.dev/config/
export default defineConfig({
  plugins: [react()],
  resolve: {
    alias: {
      // src配下を @ で参照できるようにする
      "@": path.resolve(__dirname, "./src"),
    },
  },
  server: {
    proxy: {
      // React側の /api へのアクセスを ASP.NET Core API に転送する
      "/api": {
        target: "https://localhost:7197",
        changeOrigin: true,
        secure: false,
      },
    },
  },
});
