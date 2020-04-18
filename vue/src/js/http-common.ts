import axios from "axios";
let url: string;
if (process.env.NODE_ENV === "development") {
  url = "http://localhost:21021/api/services/app/";
} else if (process.env.NODE_ENV === "production") {
  url = "http://localhost:21021/api/services/app/";
} else {
  url = "http://localhost:21021/api/services/app/";
}

export const HTTP = axios.create({
  baseURL: url,
});
