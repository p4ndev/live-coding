import axios from "axios";

const HttpClient = axios.create({
    baseURL: "https://localhost:44362"
});

export default HttpClient;