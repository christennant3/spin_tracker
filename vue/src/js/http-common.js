import axios from 'axios';
if (process.env.NODE_ENV === 'development') {
    export const HTTP = axios.create({

        baseURL: `http://localhost:21021/api/services/app/`,

    })
}

else if (process.env.NODE_ENV === 'production') {
    export const HTTP = axios.create({

        baseURL: `http://localhost:21021/api/services/app/`,

    })

}


else {
   export const HTTP = axios.create({

        baseURL: `http://localhost:21021/api/services/app/`,

    })
}


