import React from 'react'
import { useAxiosGet } from '../Hooks/HttpRequestGet'
import 'bootstrap/dist/css/bootstrap.min.css'
import { useParams } from 'react-router-dom'
import {Link} from 'react-router-dom'

function Book(){

    const { id } = useParams()
    const url = `http://localhost:5000/api/books/${id}`
    
    let response = useAxiosGet(url)

    let content = null

    if(response.error){
        content = 
        <div>
            <div className="bg-red-300 p-3">
                Book not found.
                <div><Link to='/'><strong>Return</strong></Link></div>
            </div>
        </div>
    }

    if(response.data){
        content =
        <div>
            <header><strong>Project info</strong></header>
            <body>
                <div className="row">
                    <div className="col-sm"><b>Id:</b></div>
                    <div className="col-sm">{response.data.id}</div>
                    <div className="w-100"/>
                    <div className="col-sm"><b>Title:</b></div>
                    <div className="col-sm">{response.data.title}</div>
                    <div className="w-100"/>
                    <div className="col-sm"><b>Author:</b></div>
                    <div className="col-sm">{response.data.author}</div>
                    <div className="w-100"/>
                    <div className="col-sm"><b>Page Count:</b></div>
                    <div className="col-sm">{response.data.pageCount}</div>
                </div>
            </body>
            <footer>
                <Link to='/'><strong>Return</strong></Link>
            </footer>
        </div> 

    }

    return (
        <div className="container-sm mt-1 border rounded" style={{padding: '7px', marginBottom: '0px', background: 'white'}}>
            {content}
        </div>
    )
}

export default Book