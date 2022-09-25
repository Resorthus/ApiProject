import {useEffect, useState} from 'react'
import axios from 'axios'

export function useAxiosGet(url){

    const [response, setResponse] = useState({
        data: null,
        error: false
    })

    useEffect(() => {
        axios.get(url)
            .then(res => {
                setResponse({
                    data: res.data,
                    error: false
                })
            })
            .catch(() => {
                setResponse({
                    data: null,
                    error: true
                })
            })
    }, [url])

    return response
}