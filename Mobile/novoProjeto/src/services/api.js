import axios from 'axios' ;

const api = axios.create({
    baseURL: 'http://http://192.168.5.235:5000/api'
});

export default api;