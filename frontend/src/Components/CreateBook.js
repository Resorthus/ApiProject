import React, {useState} from 'react'
import {Link, useNavigate} from 'react-router-dom'
import {Button} from 'react-bootstrap'
import axios from 'axios'

export default function CreateProject()
{
    const [lastName, setLastName] = useState('')
    const [firstName, setFirstName] = useState('')
    const [title, setTitle] = useState('')
    const [pageCount, setPageCount] = useState('')
    const [displayError, setDisplayError] = useState(false)

    const navigate = useNavigate()
    const formElements = [lastName, firstName, title, pageCount]
    let missingElements = []

    const handleSubmit = e => {
        e.preventDefault()
        missingElements = formElements.filter(ele => Object.keys(ele).length == 0)

        if (missingElements.length !=0){
            setDisplayError(true)
        }

        else{
        
            const book = JSON.stringify({
                title: title,
                firstName: firstName,
                lastName: lastName,
                pageCount: pageCount
            })

            const customConfig = {
                headers: {
                    'Content-Type': 'application/json'
                }
            }

            axios.post('http://localhost:5000/api/books', book, customConfig) 
            navigate('/')
        }
    }

    return (
        <div>
            {displayError && <li className="text-danger">Fill all empty fields</li>}
            <header><strong>New Book</strong></header>
            <body>
                <form onSubmit={handleSubmit}>

                    <div className="form-group">
                        <label>Title</label>
                        <input type="text" onChange={e => setTitle(e.target.value)} className="form-control" required/>
                    </div>
                    
                    <div className="form-group">
                        <label>Author First Name</label>
                        <input type="text" onChange={e => setFirstName(e.target.value)} className="form-control" required/>
                    </div>

                    <div className="form-group">
                        <label>Author Last Name</label>
                        <input type="text" onChange={e => setLastName(e.target.value)} className="form-control" required/>
                    </div>

                    <div className="form-group">
                        <label>Page Count</label>
                        <input type="text" onChange={e => setPageCount(e.target.value)} className="form-control" required onKeyPress={(e) => !/[0-9]/.test(e.key) && e.preventDefault()}/>
                    </div>
                </form>
            </body>
            <footer>
                <Button style={{backgroundColor: '#000000'}} onClick={handleSubmit}>Create</Button> {' '}
                <Link to='/'><strong>Return</strong></Link>
            </footer>
        </div>
    )       
}