/* eslint-disable linebreak-style */
import React from 'react'
import {Route, Routes} from 'react-router-dom'
import Books from './Components/Books'
import Book from './Components/Book'
import CreateBook from './Components/CreateBook'
import 'bootstrap/dist/css/bootstrap.min.css'

function App() {
    return (
        <Routes>      
            <Route exact path="/" element={<Books />}/>
            <Route path="/books/:id" element={<Book />}/>
            <Route path="/books/new" element={<CreateBook />}/>
        </Routes>
    )
}

export default App