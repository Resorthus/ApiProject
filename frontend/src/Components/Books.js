/* eslint-disable react/jsx-key */
import React from 'react'
import { useAxiosGet } from '../Hooks/HttpRequestGet'
import 'bootstrap/dist/css/bootstrap.min.css'
import Table from 'react-bootstrap/Table'
import {Link} from 'react-router-dom'
import { Button } from 'react-bootstrap'

function Books(){
    const url = 'http://localhost:5000/api/books'
    
    let response = useAxiosGet(url)

    let content = null

    if(response.data){
        content = 
            <Table striped bordered hover>
                <thead className="thead-dark">
                    <tr>
                        <th scope="col">Id</th>
                        <th scope="col">Title</th>
                        <th scope="col">Author</th>
                        <th style={{textAlign: 'center'}} scope="col">Page Count</th>
                    </tr>
                </thead>
                <tbody>
                    {response.data.map((book) => (
                        <tr>
                            <Link to={`/books/${book.id}`}><th scope="row">{book.id}</th></Link>
                            <td>{book.title}</td>
                            <td>{book.author}</td>
                            <td style={{textAlign: 'center'}}>{book.pageCount}</td>
                        </tr>
                    ))}
                </tbody>
            </Table>
    }

    return (
        <div className="container-sm mt-1 border rounded" style={{padding: '7px', marginBottom: '0px', background: 'white'}}>
            <Link to='/books/new'>
                <Button style={{backgroundColor: '#000000'}}>New Book</Button>
            </Link>
            {content}
        </div>
    )
}

export default Books